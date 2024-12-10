using System;
using System.Collections.Generic;
using System.IO;
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

    
    public static List<Customer> LoadCustomersFromCSV(string filePath)
    {
        List<Customer> customers = new List<Customer>();

        
        using (var reader = new StreamReader(filePath))
        {
            
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                try
                {
                    
                    Customer customer = new Customer(
                        int.Parse(values[0]),    
                        values[1],               
                        values[2],               
                        values[3],               
                        values[4],               
                        values[5],               
                        values[6],               
                        values[7],               
                        values[8]                
                    );

                    customers.Add(customer);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing line: {line}. Details: {ex.Message}");
                }
            }
        }

        return customers;
    }
}
