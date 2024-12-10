using System;
using Team4Shop;

public class Customer : User
{
    private string role;
    private string status;

    public string Role
    {
        get { return role; }
        set { role = value; }
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    public Customer(int id, string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity, string role, string status)
        : base(id, userName, password, email, phoneNumber, addressStreet, addressCity)
    {
        this.role = role;
        this.status = status;
    }
}