using BusinessModel;
using System;
//using DataLayer;

namespace ConsoleApp
{
    /// <summary>
    /// Represents the main program logic for user authentication.
    /// </summary>
    class Program
    {
        private Authentication auth;  // Object to handle authentication operations
        private User user;  // Object representing user information

        /// <summary>
        /// Constructor for the Program class.
        /// Initializes the auth and user objects.
        /// </summary>
        public Program()
        {
            auth = new Authentication();
            user = new User();
        }

        /// <summary>
        /// Runs the main program logic.
        /// Displays a menu, takes user input, and performs the corresponding actions.
        /// </summary>
        public void Run()
        {
            Console.WriteLine(Literal.div);
            Console.WriteLine(Literal.menu);
            int input = Convert.ToInt32(Console.ReadLine());
            int redirect = input;
            bool flag = true;
            while (flag)
            {
                switch (redirect)
                {
                    // Exit
                    case 0:
                        flag = false;
                        break;
                    // Login
                    case 1:
                        Console.WriteLine(Literal.div, Literal.login);
                        redirect = auth.Login(user);
                        break;
                    // Register
                    case 2:
                        Console.WriteLine(Literal.div, Literal.register);
                        redirect = auth.Register(user);
                        break;
                    // Forgot password
                    case 3:
                        Console.WriteLine(Literal.div, Literal.forgotPassword);
                        redirect = auth.ForgotPassword(user);
                        break;
                    // Logout
                    case 4:
                        Console.WriteLine(Literal.div, Literal.loggedIn, Literal.logout);
                        redirect = auth.Logout();
                        break;
                    // Default
                    default:
                        Console.WriteLine(Literal.div, Literal.switchDefault);
                        redirect = auth.SwitchDefault();
                        break;
                }
            }
        }

        /// <summary>
        /// The entry point of the program.
        /// Creates an instance of the Program class and calls the Run method to start the program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
    }
}
