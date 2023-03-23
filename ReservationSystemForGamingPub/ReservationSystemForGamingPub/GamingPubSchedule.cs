namespace ReservationSystemForGamingPub
{
    public class GamingPubSchedule : IGamingPubSchedule
    {
        Dictionary<DayOfWeek, Tuple<int, int>> _schedule;

        public Dictionary<DayOfWeek, Tuple<int, int>> Schedule { get { return _schedule; } }

        public GamingPubSchedule()
        {
            _schedule = new Dictionary<DayOfWeek, Tuple<int, int>>();
        }

        public void PrintSchedule()
        {
            foreach (var keyValue in _schedule)
            {
                Console.WriteLine($"{keyValue.Key}: {keyValue.Value.Item1}-{keyValue.Value.Item2}");
            }
        }

        public bool CheckIfScheduleIsValid(DayOfWeek day, int startHour, int endHour)
        {
            if (startHour >= 0 && startHour <= 23)
            {
                if (endHour >= 0 && endHour <= 23)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddDaySchedule(DayOfWeek day, int startHour, int endHour)
        {
            if (CheckIfScheduleIsValid(day, startHour, endHour))
            {
                if (!_schedule.ContainsKey(day))
                {
                    _schedule.Add(day, new Tuple<int, int>(startHour, endHour));
                    return true;
                }
            }
            return false;
        }

        public bool EditDaySchedule(DayOfWeek day, int startHour, int endHour)
        {
            if (CheckIfScheduleIsValid(day, startHour, endHour))
            {
                if (_schedule.ContainsKey(day))
                {
                    _schedule[day] = new Tuple<int, int>(startHour, endHour);
                    return true;
                }
            }
            return false;
        }
    }
}