namespace ReservationSystemForGamingPub
{
    public class GamingPub
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private int _maxNumberOfClients;

        private List<Reservation> _reservations;

        public List<Tuple<GamingPlatform, bool>> GamingPlatforms { get; set; }

        private ISchedule _schedule;

        public ISchedule Schedule { get { return _schedule; } }

        public int MaxNumberOfClients
        {
            get { return _maxNumberOfClients; }
        }

        public GamingPub(int id, string name, string address, int maxNumberOfClients, ISchedule schedule)
        {
            Id=id;
            Name = name;
            Address = address;
            _maxNumberOfClients = maxNumberOfClients;
            _schedule = schedule;
        }
    }
}