using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4Shop
{
    public class Admin : User
    {
        // Properties
        public DateTime LastLogin { get; set; }
         private static List<Admin> admins = new List<Admin>();
        private static List<Product> products = new List<Product>();

        // Constructor
        public Admin(int userID, string userName, string password, string email, string phoneNumber, string addressStreet, string addressCity)
            : base(userID, userName, password, email, phoneNumber, addressStreet, addressCity)
        {
            UserID = userID;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            AddressStreet = addressStreet;
            AddressCity = addressCity;
        }  
        

        // Method to view users (admin can only access)
        public static void ViewAllUsers()
        {
            var users = User.GetAllUsers();
            if (users.Count > 0)
            {
                Console.WriteLine("List of all the registered users in the system");
                foreach (var user in users)
                {
                    Console.WriteLine($"UserID: {user.UserID}, UserName: {user.UserName}, Email: {user.Email}");
                }
            }
            else
            {
                Console.WriteLine("No users found on the system");
            }
        }

        public static List<Admin> GetAllAdmins()
        {
            return admins;
        }

        // Method that can delete user (admin can only access)
        public static void DeleteUser(int userID)
        {
            var userToDelete = User.GetAllUsers().Find(u => u.UserID == userID);
            if (userToDelete != null)
            {
                User.GetAllUsers().Remove(userToDelete);
                Console.WriteLine($"User with ID {userID} was deleted");
            }
            else
            {
                Console.WriteLine("No users found on the system");
            }
        }

        // Adding a product
        public static void addProduct(Product newProduct)
        {

            products.Add(newProduct);

            Console.WriteLine($"Added {newProduct.ProductName} item to product list");
        }

        // Removing a product
        public static void removeProduct(string productName)
        {
            var productToDelete = products.Find(p => p.ProductName == productName);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
                Console.WriteLine($"Product '{productName}' was removed from list");
            }
            else
            {
                Console.WriteLine("No product found on the system");
            }
        }

        // Updating product stock
        public static void UpdateStock(string productName, int stockCount)
        {
            var productToUpdate = products.Find(p => p.ProductName == productName);
            if (productToUpdate != null)
            {
                productToUpdate.Stock = stockCount;
                Console.WriteLine($"Stock for '{productName}' has been updated to the following: {stockCount}");
            }
            else
            {
                Console.WriteLine("No product found on the system");
            }
        }

        //Adding items to the products stock
        public static void AddItemToStock(string productName, int quantity)
        {
            var product = products.Find(product => product.ProductName == productName);
            if (product != null)
            {
                product.Stock += quantity;
                Console.WriteLine($"{quantity} items of '{productName}' added to stock");
            }
            else
            {
                Console.WriteLine("No product found on the system");
            }
        }

        //Removing items from the products stock
        public static void RemoveProduct(string productName, int quantity)
        {
            var product = products.Find(product => product.ProductName == productName);
            if (product != null && product.Stock >= quantity)
            {
                product.Stock -= quantity;
                Console.WriteLine($"{quantity} items of '{productName}' removed from stock");
            }
            else
            {
                Console.WriteLine("No product found on the system");
            }
        }
        public static void AddAdmin(Admin newAdmin)
        { 
            admins.Add(newAdmin);
        }
    }
}
