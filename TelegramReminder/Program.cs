using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace TelegramReminder
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);

            CreateConfiguration(builder);
            CreateServiceCollection(builder);

            builder.ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                });
                
            var host = builder.Build();

            MigrateDb(host);

            await host.RunAsync();
        }

        private static void CreateConfiguration(IHostBuilder builder)
        {
            builder.ConfigureAppConfiguration((hostingContext, config) =>
             {
                 config.SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Configs")
                       .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", false, false)
                       .AddEnvironmentVariables();
             });
        }

        private static void CreateServiceCollection(IHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {                
                // Подключаем менеджер работы с БД
                services.AddDbContext<DbContextManager>(options =>
                    options.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection")));

                // Регистрируем TelegramBotClient как синглтон
                services.AddSingleton(new TelegramBotClient(context.Configuration["TelegramReminder:BotToken"]));

                // Регистрируем репозитории
                services.AddScoped<IEventRepository, EventRepository>();
                services.AddScoped<IEventTypeRepository, EventTypeRepository>();
                services.AddScoped<IUserStateRepository, UserStateRepository>();

                // Регистрируем сервис для работы с мероприятиями
                services.AddScoped<IEventService, EventService>();

                // Регистрируем обработчик Telegram-бота (как фоновой сервис)
                services.AddHostedService<BotService>();

                // Регистрируем сервис уведомлений (фоновой сервис)
                services.AddHostedService<NotificationService>();

            });
        }

        private static void MigrateDb(IHost host)
        {
            using (var scope = host.Services.GetService<IServiceProvider>().CreateScope())
            {
                var logger = host.Services.GetRequiredService<ILogger<Program>>();
                logger.LogInformation("Начинаем миграцию БД.");

                var dbContext = scope.ServiceProvider.GetRequiredService<DbContextManager>();
                dbContext.Database.Migrate();

                logger.LogInformation("Миграция БД завершена.");
            }
        }
    }
}
