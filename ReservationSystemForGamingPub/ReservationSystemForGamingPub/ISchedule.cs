namespace ReservationSystemForGamingPub
{
    public interface ISchedule
    {
        Dictionary<DayOfWeek, Tuple<int, int>> Schedule { get; }

        bool AddDaySchedule(DayOfWeek day, int startHour, int endHour);
        bool CheckIfScheduleIsValid(DayOfWeek day, int startHour, int endHour);
        bool EditDaySchedule(DayOfWeek day, int startHour, int endHour);
        void PrintSchedule();
    }
}