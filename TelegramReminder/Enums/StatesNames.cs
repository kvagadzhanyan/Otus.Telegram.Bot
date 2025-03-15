namespace TelegramReminder
{
    /// <summary>
    /// Текущий статус действий пользователя.
    /// </summary>
    public enum EventStatesNames
    {
        /// <summary>
        /// Нет сохраненного состояния.
        /// </summary>
        None = 0,

        /// <summary>
        /// Ожидание ввода наименования события.
        /// </summary>
        AddingEventName = 1,

        /// <summary>
        /// Ожидание ввода типа события.
        /// </summary>
        AddingEventType = 2,

        /// <summary>
        /// Ожидание ввода даты и времени события.
        /// </summary>
        AddingEventDateTime = 3,

        /// <summary>
        /// Ожидание ввода участников события.
        /// </summary>
        AddingEventParticipant = 4,

        /// <summary>
        /// Ожидание ввода места проведения события.
        /// </summary>
        AddingEventLocation = 5,

        
        /// <summary>
        /// Ожидание ввода времени до начала события, за которое необходимо отправить уведомления.
        /// </summary>
        AddingNotificationBefore = 6
    }
}