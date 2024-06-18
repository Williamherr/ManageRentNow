using ManageRentNow.Api.Models;

public class Property
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string Type { get; set; } // e.g., Apartment, House, Commercial
    public User Landlord { get; set; } // Association to a User with Role "Landlord"
    public List<Lease> Leases { get; set; } // Leases associated with this property

    public Property(string address, string type, User landlord)
    {
        Address = address;
        Type = type;
        Landlord = landlord;
        Leases = new List<Lease>();
    }

    // Method to add a lease to the property
    public void AddLease(Lease lease)
    {
        Leases.Add(lease);
    }

    // Additional methods specific to property management
}