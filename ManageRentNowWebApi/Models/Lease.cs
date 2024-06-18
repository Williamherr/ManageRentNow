namespace ManageRentNow.Api.Models
{
    public class Lease
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentAmount { get; set; }
        public User Tenant { get; set; } // Association to a User with Role "Tenant"

        public Lease(DateTime startDate, DateTime endDate, decimal rentAmount, User tenant)
        {
            StartDate = startDate;
            EndDate = endDate;
            RentAmount = rentAmount;
            Tenant = tenant;
        }

        // Additional methods for lease management
    }
}
