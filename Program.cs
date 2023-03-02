using Budweg.Models;
using Budweg.Repositories;
using Budweg.Views;

class Program
{
    static Budweg.Repositories.EmployeeRepository userRepository = new Budweg.Repositories.EmployeeRepository();
    static Menus menus = new Menus();

    static void Main(string[] args)
    {
        // Add a test user to the repository
        var testUser = new User
        {
            Id = 1,
            Name = "John Doe",
            Email = "john.doe@example.com",
            Password = "1234",
            Role = Role.Foreman
        };
        userRepository.AddUser(testUser);

        // Prompt the user for credentials
        Console.WriteLine("Enter your email:");
        var email = Console.ReadLine();
        Console.WriteLine("Enter your password:");
        var password = Console.ReadLine().ToString(); 

        // Authenticate the user
        if (userRepository.AuthenticateUser(email, password))
        {
            Console.WriteLine("Authentication successful!");
        }

        var user = userRepository.GetUserByEmail(email);
        if (user != null && userRepository.AuthenticateUser(email, password))
        {
            Console.WriteLine("Authentication successful!");
            menus.LoadMenu(user);
        }
        else
        {
            Console.WriteLine("Authentication failed.");
        }

        // Prompt the user to create a new user
        Console.WriteLine("Enter a new user's name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter a new user's email:");
        email = Console.ReadLine();
        Console.WriteLine("Enter a new user's role (Foreman, ProductionWorker, or QualityAssurance):");
        var roleString = Console.ReadLine();
        if (Enum.TryParse<Role>(roleString, out var role))
        {
            var newUser = new User
            {
                Id = userRepository.GetAllUsers().Count + 1,
                Name = name,
                Password = password,
                Email = email,
                Role = role
            };
            userRepository.AddUser(newUser);
            Console.WriteLine($"User {newUser.Name} added!");
         
        }
        else
        {
            Console.WriteLine("Invalid role entered.");
        }
    }

}

