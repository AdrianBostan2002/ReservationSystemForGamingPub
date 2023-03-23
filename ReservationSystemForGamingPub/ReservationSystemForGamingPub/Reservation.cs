namespace ReservationSystemForGamingPub
{
    public class Reservation
    {
        private Customer _customer;

        private GamingPub _gamingPub;

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }

        public Reservation(Customer customer, GamingPub gamingPub, DateTime startDate, DateTime endDate)
        {
            _customer = customer;
            _gamingPub = gamingPub;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}