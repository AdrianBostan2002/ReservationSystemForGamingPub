namespace ReservationSystemForGamingPub
{
    public class GamingPubSchedule
    {
        Dictionary<DayOfWeek, Tuple<int, int>> _schedule;

        public Dictionary<DayOfWeek, Tuple<int, int>> Schedule { get { return _schedule; } }

        public GamingPubSchedule() { }
    }
}