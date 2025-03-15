namespace TelegramReminder
{
    /// <summary>
    /// Интерфейс для работы с состояниями пользователей.
    /// </summary>
    public interface IStatesRepository
    {
        /// <summary>
        /// Получает текущее состояние пользователя по его идентификатору.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Задачу на получения состояния пользователя.</returns>
        Task<CurrentState> GetUserStateByIdAsync(int userId);

        /// <summary>
        /// Сохраняет текущее состояние пользователя.
        /// </summary>
        /// <param name="currentState">Текущее состояние пользователя.</param>
        /// <returns>Задачу на сохранение текущего состояния пользователя.</returns>
        Task SetUserCurrentStateAsync(CurrentState currentState);
    }
}
