namespace TelegramReminder
{
    public class CurrentState
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Текущее состояние действий пользователя.
        /// </summary>
        public EventStatesNames State { get; set; }

        /// <summary>
        /// Временные данные текущего состояния.
        /// </summary>
        public string? CurrentStateData { get; set; }
    }
}
