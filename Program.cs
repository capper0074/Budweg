using Budweg.Models;
using Budweg.Repositories;
using Budweg.Views;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        UserRepository userRepository = new UserRepository();
        User currentUser = null;
        // Add a test user to the repository
        var testUser = new User
        {
            Id = 1,
            Name = "Test User",
            Email = "test@example.com",
            Password = "1234",
            Role = Role.Foreman
        };
        userRepository.AddUser(testUser);

        OrderRepository orders = new OrderRepository();
        orders.AddOrder(new Order("Order 1", "This is order 1", userRepository.GetUserById(1)));
        orders.AddOrder(new Order("Order 2", "This is order 2", userRepository.GetUserById(2)));
        orders.AddOrder(new Order("Order 3", "This is order 3", userRepository.GetUserById(1)));

        //get user information

        while (currentUser == null)
        {
            Console.Write("Enter your email address: ");
            string Email = Console.ReadLine();

            currentUser = userRepository.GetUserByEmail(Email); //checks repository for email, if no email program continues, always no email rn, update at some point

            if (currentUser == null)
            {
                Console.WriteLine("User not found");
                Console.WriteLine("Would you like to create a new account? (Y/N): ");
                string createAccount = Console.ReadLine().ToUpper();

                if (createAccount.Equals("Y", StringComparison.InvariantCultureIgnoreCase)) //StringComparison is redundant because of ToUpper(), however, fun to use
                {
                    Console.WriteLine("Enter your name: ");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Enter your email address: ");
                    Email = Console.ReadLine();

                    Console.Write("Enter your role (Foreman/ProductionWorker/QualityAssurance): ");
                    string roleString = Console.ReadLine();
                    Enum.TryParse(roleString, out Role Role); //TryParse the string to Enum in order to check for role. Create swifter version in order to transform to WPF. Potentially a button which determines role or a list of employee IDs of predetermined roles

                    currentUser = userRepository.CreateUser(Name, Email, Role);
                    Console.WriteLine("User created successfully!");
                    Console.ReadLine(); 
                }
            }
        }

        Menus.LoadMenu(currentUser, orders);

    } 

   
   
    


    //    // Prompt the user for credentials
    //    Console.WriteLine("Enter your email:");
    //    var email = Console.ReadLine();
    //    Console.WriteLine("Enter your password:");
    //    var password = Console.ReadLine().ToString(); 

    //    // Authenticate the user
    //    if (userRepository.AuthenticateUser(email, password))
    //    {
    //        Console.WriteLine("Authentication successful!");
    //    }

    //    var user = userRepository.GetUserByEmail(email);
    //    if (user != null && userRepository.AuthenticateUser(email, password))
    //    {
    //        Console.WriteLine("Authentication successful!");
    //        User currentUser = userRepository.GetUserByEmail(email);
    //        menus.LoadMenu(currentUser, OrderRepository currentUser);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Authentication failed.");
    //    }

    //    // Prompt the user to create a new user
    //    Console.WriteLine("Enter a new user's name:");
    //    var name = Console.ReadLine();
    //    Console.WriteLine("Enter a new user's email:");
    //    email = Console.ReadLine();
    //    Console.WriteLine("Enter a new user's role (Foreman, ProductionWorker, or QualityAssurance):");
    //    var roleString = Console.ReadLine();
    //    if (Enum.TryParse<Role>(roleString, out var role))
    //    {
    //        var newUser = new User
    //        {
    //            Id = userRepository.GetAllUsers().Count + 1,
    //            Name = name,
    //            Password = password,
    //            Email = email,
    //            Role = role
    //        };
    //        userRepository.AddUser(newUser);
    //        Console.WriteLine($"User {newUser.Name} added!");
         
    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid role entered.");
    //    }
    //}

}

