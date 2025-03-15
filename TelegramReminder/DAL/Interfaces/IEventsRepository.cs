namespace TelegramReminder
{
    /// <summary>
    /// Интерфейс для работы с событиями.
    /// </summary>
    public interface IEventsRepository
    {
        /// <summary>
        /// Добавляет событие.
        /// </summary>
        /// <param name="newEvent">Новое событие.</param>
        /// <returns>Задачу на добавление события.</returns>
        Task AddAsync(Event newEvent);
        
        /// <summary>
        /// Обновляет событие.
        /// </summary>
        /// <param name="currentEvent">Текущее событие.</param>
        /// <returns>Задачу на обновление события.</returns>
        Task UpdateAsync(Event currentEvent);
        
        /// <summary>
        /// Удаляет событие.
        /// </summary>
        /// <param name="eventId">Идентификатор события.</param>
        /// <returns>Задачу на удаление события</returns>
        Task DeleteAsync(int eventId);
        
        /// <summary>
        /// Получает событие по идентификатору.
        /// </summary>
        /// <param name="eventId">Идентификатор события.</param>
        /// <returns>Задачу на получение события.</returns>
        Task<Event> GetEventByIdAsync(int eventId);
        
        /// <summary>
        /// Получает постранично события пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="pageNumber">Номер получаемой страницы.</param>
        /// <param name="pageSize">Количество событий на странице (по умолчанию, 10 событий).</param>
        /// <returns>Задачу на постраничное получение событий пользователя.</returns>
        Task<List<Event>> GetUserPagedEventsAsync(int userId, int pageNumber, int pageSize = 10);
        
        /// <summary>
        /// Получает наступающие события.
        /// </summary>
        /// <returns>Задачу на получение списка наступающих событий.</returns>
        Task<List<Event>> GetUpcomingEventsAsync();
    }
}
