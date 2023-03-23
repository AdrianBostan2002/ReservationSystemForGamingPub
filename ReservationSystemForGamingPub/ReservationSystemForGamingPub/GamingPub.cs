namespace ReservationSystemForGamingPub
{
    public class GamingPub
    {
        public string Name { get; set; }

        public string Address { get; set; }

        private int _maxNumberOfClients;

        public int MaxNumberOfClients
        {
            get { return _maxNumberOfClients; }
        }

        public GamingPub(string name, string address, int maxNumberOfClients)
        {
            Name = name;
            Address = address;
            _maxNumberOfClients = maxNumberOfClients;
        }
    }
}