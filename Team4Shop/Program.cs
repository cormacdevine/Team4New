using System;
using Team4Shop;

public class Program
{
    public static void Main(string[] args)
    {
        // Register users
        User.Register( "caolan158", "xyZk65", "mullincaolan@gmail.com", "07562140759", "15 Claggan Road", "Omagh");
        User.Register( "Syed675", "89Cv2", "meeransyed@gmail.com", "0987654321", "456 Derry Rd", "Derry");

        // login for administrators
        Admin admin = new Admin(1, "administrator1", "Code567", "malonekevin@gmail.com", "55890126", "47 Loughlin Rd", "Armagh City");
        Admin.AddAdmin(admin);

        Admin admin2 = new Admin(2, "administrator2", "Code567", "devinecormac@gmail.com", "1127698", "17 Omagh Rd", "Omagh");
        Admin.AddAdmin(admin2);

      

        // View users (admin only)
        Admin.ViewAllUsers();

        // Deleting users (admin only)
        Admin.DeleteUser(2);

        //Managing product stocklist (admin only)
       
        Admin.AddItemToStock("Samsung TV", 50);
        Admin.UpdateStock("Samsung TV", 100);
        Admin.RemoveProduct("Samsung TV", 1);

        // User Login
        User user = User.Login("caolan158", "xyZk65");
        User user1 = User.Login("Syed675", "89Cv2");

        //Products

        Product product1 = new Product(1, "LEDTV", 459.99, 5, "1", "Samsung");
        Product.AddProduct(product1);

        Product product2 = new Product(2, "Vacuum Cleaner", 599.99, 10, "2", "Dyson V11");
        Product.AddProduct(product2);

        Product product3 = new Product(3, "Running Shoes", 120.00, 20, "3", "Nike Pegasus");
        Product.AddProduct(product3);

        Product product4 = new Product(4, "Software Programming", 12.99, 25,"4 ", "C# for beginners");
        Product.AddProduct(product4);

        Product product5 = new Product(5, "Blender", 89.99, 15, "2", "NutriBullet Pro");
        Product.AddProduct(product5);

        Product product6 = new Product(6, "SmartPhone", 999.99, 8, "5", "iPhone 13");
        Product.AddProduct(product6);


        MainMenu();
    }

    static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Admin Login");
            Console.WriteLine("2. User Login");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    adminLogin();
                    break;
                case "2":
                    customerLogin();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void customerLogin()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Customer Menu:");
                Console.WriteLine("1. View Profile");
                Console.WriteLine("2. Update Profile");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewCustomerProfile();
                        break;
                    case "2":
                        UpdateCustomerProfile();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            static void ViewCustomerProfile()
            {
                // Assume this method will display the customer's profile
                Console.Clear();
                Console.WriteLine("Viewing Customer Profile...");
                // Display the user's profile information here
                Console.WriteLine("User ID: 1");
                Console.WriteLine("Username: Cormac");
                Console.WriteLine("Email: devinecormac@gmail.com");
                Console.WriteLine("Phone: 123-456-7890");
                Console.WriteLine("Address: 123 Main St, Omagh");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
            }

            static void UpdateCustomerProfile()
            {
                // Assume this method allows the customer to update their profile information
                Console.Clear();
                Console.WriteLine("Updating Customer Profile...");
                Console.Write("Enter new phone number: ");
                string newPhoneNumber = Console.ReadLine();
                Console.Write("Enter new address: ");
                string newAddress = Console.ReadLine();

                // Here we would update the customer's information in the system.
                // For this example, we just display a success message.
                Console.WriteLine("Profile updated successfully!");
                Console.WriteLine($"New Phone: {newPhoneNumber}");
                Console.WriteLine($"New Address: {newAddress}");
                Console.WriteLine("Press any key to return to the menu.");
                Console.ReadKey();
            }



        }
        static void checkAdmin()
        {
            Console.WriteLine("Enter username");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

        }

        static void adminLogin()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu:");
                Console.WriteLine("1. Manage Products");
                Console.WriteLine("2. Manage Categories");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ProductMenu();
                        break;
                    case "2":
                        CategoryMenu();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            
            static void ProductMenu()
            {
                while (true)
                {
                    Console.WriteLine("\nProduct Menu:");
                    Console.WriteLine("1. Add Product");
                    Console.WriteLine("2. Remove Product");
                    Console.WriteLine("3. Update Product");
                    Console.WriteLine("4. View All Products");
                    Console.WriteLine("5. Search Product by Name");
                    Console.WriteLine("6. Back to Main Menu");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter Product ID: ");
                            int productId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Product Name: ");
                            string productName = Console.ReadLine();
                            Console.Write("Enter Product Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter stock");
                            int stock = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter category");
                            string category = Console.ReadLine();
                            Console.WriteLine("Enter description");
                            string description = Console.ReadLine();
                            Product.AddProduct(new Product(productId, productName, price, stock, category, description));
                            break;
                        case "2":
                            Console.Write("Enter Product ID to remove: ");
                            int removeProductId = int.Parse(Console.ReadLine());
                            Product.RemoveProduct(removeProductId);
                            break;
                        case "3":
                            Console.Write("Enter Product ID to update: ");
                            int updateProductId = int.Parse(Console.ReadLine());
                            Console.Write("Enter new Product Name: ");
                            string newProductName = Console.ReadLine();
                            Console.Write("Enter new Product Price: ");
                            double newPrice = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter stock");
                            int upstock = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter category");
                            string upcategory = Console.ReadLine();
                            Console.WriteLine("Enter description");
                            string updescription = Console.ReadLine();
                            Product.UpdateProduct(updateProductId, newProductName, newPrice,upstock, upcategory, updescription);
                            break;
                        case "4":
                            Product.ViewAllProducts();
                            break;
                        case "5":
                            Console.Write("Enter Product Name to search: ");
                            string searchProductName = Console.ReadLine();
                            Product.SearchProductByName(searchProductName);
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }

            static void CategoryMenu()
            {
                while (true)
                {
                    Console.WriteLine("\nCategory Menu:");
                    Console.WriteLine("1. Add Category");
                    Console.WriteLine("2. Remove Category");
                    Console.WriteLine("3. Update Category");
                    Console.WriteLine("4. View All Categories");
                    Console.WriteLine("5. Search Category by Name");
                    Console.WriteLine("6. Back to Main Menu");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter Category ID: ");
                            int categoryId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Category Name: ");
                            string categoryName = Console.ReadLine();
                            Console.Write("Enter Category Description: ");
                            string description = Console.ReadLine();
                            Category.AddCategory(new Category(categoryId, categoryName, description));
                            break;
                        case "2":
                            Console.Write("Enter Category ID to remove: ");
                            int removeCategoryId = int.Parse(Console.ReadLine());
                            Category.RemoveCategory(removeCategoryId);
                            break;
                        case "3":
                            Console.Write("Enter Category ID to update: ");
                            int updateCategoryId = int.Parse(Console.ReadLine());
                            Console.Write("Enter new Category Name: ");
                            string newCategoryName = Console.ReadLine();
                            Console.Write("Enter new Category Description: ");
                            string newDescription = Console.ReadLine();
                            Category.UpdateCategory(updateCategoryId, newCategoryName, newDescription);
                            break;
                        case "4":
                            Category.ViewAllCategories();
                            break;
                        case "5":
                            Console.Write("Enter Category Name to search: ");
                            string searchCategoryName = Console.ReadLine();
                            Category.SearchCategoryByName(searchCategoryName);
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }


        }
    }
}
