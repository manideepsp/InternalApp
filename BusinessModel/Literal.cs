﻿namespace BusinessModel
{
    /// <summary>
    /// This class contains all the string literals used in the Application
    /// </summary>
    public static class Literal
    {
        #region "commented out"
        //string userUsername;
        //string userPassword;
        //string userEmail;
        //string userMobile;
        //string userConfirmPassword;
        //public Literal(User user)
        //{
        //    userUsername = user.Username;
        //    userPassword = user.Password;
        //    userEmail = user.Email;
        //    userMobile = user.Mobile;
        //    userConfirmPassword = user.ConfirmPassword;
        //}
        #endregion

        public static string menu = "Welcome to Landing page"
                + "\n  Enter: "
                + "\n* 1. To Login"
                + "\n* 2. To Register As new user"
                + "\n* 3. To Forgot/Change Password"
                + "\n* enter any other key to exit";
        public static string div = "\n*********************************************";
        public static string switchDefault = "\ndo you want to exit y/n ?";
        public static string registrationSuccess = "\nUser created Successfully !" +
                                                    "\nPress 1 to Login" +
                                                    "\nPress any other key to exit";
        public static string logoutSuccess = "\nLogged out successfully, redirecting to login page.";
        public static string exit = "\nExiting the Application...";

        public static string loginSuccess = "\nLogin successfull, welcome User.";
        public static string loginFail = "\nLogin failed..." +
                                        "\n\tPress 1 to create new user" +
                                        "\n\tPress 2 if you Forgot your password" +
                                        "\n\tPress 3 to login again" +
                                        "\n\tPress any other key to exit the application";
        public static string logout = "\nDo you want to logout press y";
        public static string login = "\nWelcome to Login Page:";
        public static string register = "\nWelcome to New User, enter your details to create new account:";

        public static string forgotPassword = "\nWelcome to forgot Password page";
        public static string forgotPasswordSuccess = "\npassword updated successfully, redirecting you to login page...";
        public static string forgotPasswordFail = "\n\nUser doesnot exist...\n\tPress 1 to retry\n\tPress 2 to login\n\tPress 3 to register\n\tPress any other key to exit";

        public static string userExist = "\n user already exist, redirecting to login page.";

        public static string validPassword = "\nPassword should be at least 8 characters long\r" +
                                        "\nContains at least one uppercase letter (A-Z)\r" +
                                        "\nContains at least one lowercase letter (a-z)\r" +
                                        "\nContains at least one digit (0-9)\r" +
                                        "\nContains at least one special character (!@#$%^&*())";
        public static string username = "\nEnter Username: ";
        public static string password = "\nEnter Password: ";
        public static string passwordAgain = "\nEnter Valid Password: ";
        public static string confirmPassword = "\nConfirm your Password: ";
        public static string mobile = "\nEnter Mobile number : ";
        public static string mobileAgain = "\nEnter Valid Mobile number : ";
        public static string email = "\nEnter Email ID: ";
        public static string emailAgain = "\nEnter Valid Email ID: ";

        // Regex pattern for password validation
        public static string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*()])[A-Za-z\d!@#$%^&*()]{8,}$";
        // Regex pattern for email validation
        public static string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        // Regex pattern for validating Indian mobile numbers
        public static string mobilePattern = @"^[6-9]\d{9}$";

    }
}
