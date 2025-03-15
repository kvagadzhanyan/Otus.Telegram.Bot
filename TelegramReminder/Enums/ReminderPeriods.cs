namespace TelegramReminder
{
    /// <summary>
    /// Периодичность наступления события.
    /// </summary>
    public enum ReminderPeriods
    {
        /// <summary>
        /// Один раз.
        /// </summary>
        Single = 1,
        
        /// <summary>
        /// Каждый день
        /// </summary>
        EveryDay = 2,

        /// <summary>
        /// Каждую неделю.
        /// </summary>
        EveryWeek = 3,

        /// <summary>
        /// Каждый месяц.
        /// </summary>
        EveryMonth = 4,

        /// <summary>
        /// Каждый год.
        /// </summary>
        EveryYear = 5
    }
}
