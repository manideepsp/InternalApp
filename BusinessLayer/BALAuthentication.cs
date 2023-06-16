using BusinessModel;
using DataLayer;
using System;

namespace BusinessLayer
{
    public class BALAuthentication
    {
        private BALValidations validate;
        private DALAuthentication dataOperation;
        public BALAuthentication()
        {
            validate = new BALValidations();
            dataOperation = new DALAuthentication();
        }

        bool decision = false;

        /// <summary>
        /// Implements Login Functionality, checks if username and password pair is present and returns bool
        /// </summary>
        /// <param name="user"></param>
        /// <param name="lit"></param>
        /// <returns></returns>
        public bool Login(User user)
        {
            Console.WriteLine(Literal.login);
            Console.Write(Literal.username);
            user.Username = Console.ReadLine();
            Console.WriteLine(Literal.password);
            user.Password = Console.ReadLine();

            decision = validate.IsValidLogin(user.Username, user.Password);
            Console.WriteLine(Literal.loggedIn);
            return decision;

        }
        bool flag = true;

        /// <summary>
        /// Implements Register user functionality, validates all the inputs given and calls method to write it to database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="lit"></param>
        /// <returns></returns>
        public bool Register(User user)
        {
            Console.WriteLine(Literal.register);
            Console.Write(Literal.username);
            user.Username = Console.ReadLine();
            flag = validate.IsValidUsername(user.Username); //returns true if username is valid, not already exist
            if (!flag)
            {
                Console.WriteLine(Literal.userExist);
                return false;
            }

            Console.Write(Literal.password);
            user.Password = Console.ReadLine();
            flag = validate.IsValidPassword(user.Password); //returns true if password is valid
            while (!flag)
            {
                Console.Write(Literal.password);
                user.Password = Console.ReadLine();
                flag = validate.IsValidPassword(user.Password);
            }
            Console.Write(Literal.confirmPassword);
            user.ConfirmPassword = Console.ReadLine();
            flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword); //returns true id password mathces
            while (!flag)
            {
                Console.Write(Literal.confirmPassword);
                user.ConfirmPassword = Console.ReadLine();
                flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword);
            }

            Console.Write(Literal.mobile);
            user.Mobile = Console.ReadLine();
            flag = validate.IsValidMobile(user.Mobile); //returns true if mobile is valid
            while (!flag)
            {
                Console.Write(Literal.mobile);
                user.Mobile = Console.ReadLine();
                flag = validate.IsValidMobile(user.Mobile);
            }

            Console.Write(Literal.email);
            user.Email = Console.ReadLine();
            flag = validate.IsValidEmail(user.Email); //returns true if email is valid
            while (!flag)
            {
                Console.Write(Literal.email);
                user.Email = Console.ReadLine();
                flag = validate.IsValidEmail(user.Email);
            }

            decision = dataOperation.Register(user);
            Console.WriteLine(Literal.successRegistration);
            return decision;

        }

        /// <summary>
        /// Implements forgotpassword functionality, validates the password, calls the method to update in database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="lit"></param>
        /// <returns></returns>
        public bool ForgotPassword(User user)
        {
            Console.WriteLine(Literal.forgotPassword);
            Console.Write(Literal.username);
            user.Username = Console.ReadLine();
            decision = validate.IsValidUsername(user.Username); //returns true if username is valid, not already exist
            if (!decision)
            {
                Console.Write(Literal.userExist);
                return false;
            }

            Console.Write(Literal.password);
            user.Password = Console.ReadLine();
            flag = validate.IsValidPassword(user.Password); //returns true if password is valid
            while (!flag)
            {
                Console.Write(Literal.password);
                user.Password = Console.ReadLine();
                flag = validate.IsValidPassword(user.Password);
            }
            Console.Write(Literal.confirmPassword);
            user.ConfirmPassword = Console.ReadLine();
            flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword); //returns true id password mathces
            while (!flag)
            {
                Console.Write(Literal.confirmPassword);
                user.ConfirmPassword = Console.ReadLine();
                flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword);
            }
            Console.WriteLine(Literal.successForgotPassword);
            return true;
        }

        /// <summary>
        /// Implements the logout functionality
        /// </summary>
        /// <param name="lit"></param>
        /// <returns></returns>
        public bool Logout()
        {
            Console.WriteLine(Literal.logout);
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Y)
            {
                decision = true;
                Console.WriteLine(Literal.successLogout);
            }
            else
            {
                decision = false;
            }
            return decision;
        }

        /// <summary>
        /// Implements the Switch default functionality
        /// </summary>
        /// <param name="lit"></param>
        /// <returns></returns>
        public bool SwitchDefault()
        {
            Console.WriteLine(Literal.switchDefault);
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Y)
            {
                decision = true;
            }
            else
            {
                decision = false;
            }
            return decision;
        }
    }
}
