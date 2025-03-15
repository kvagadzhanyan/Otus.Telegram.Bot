using TelegramReminder.Enums;

namespace TelegramReminder
{
    /// <summary>
    /// Модель данных события.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Идентификатор события.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        public int UserId { get; set; }
        
        /// <summary>
        /// Наименование события.
        /// </summary>
        public string? Name { get; set; }
        
        /// <summary>
        /// Тип события.
        /// </summary>
        public EventTypes? EventType { get; set; }
        
        /// <summary>
        /// Дата и время наступления события.
        /// </summary>
        public DateTime? EventDateTime { get; set; }
        
        /// <summary>
        /// Участник/и события.
        /// </summary>
        public string? Participant { get; set; }
        
        /// <summary>
        /// Место проведения события.
        /// </summary>
        public string? Location { get; set; }
        
        
        /// <summary>
        /// За сколько минут до наступления события отправлять уведомление.
        /// </summary>
        public int? NotificationBeforeMinutes { get; set; }
        
        /// <summary>
        /// Уведомление отправлено.
        /// </summary>
        public bool? IsNotified { get; set; }
    }
}
