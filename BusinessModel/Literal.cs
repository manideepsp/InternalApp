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

                + "\n* enter any other key to exit";
        public static string div = "\n*********************************************";
        public static string switchDefault = "\ndo you want to exit y/n ?";
        public static string successRegistration = "\nUser created Successfully ! ";
        public static string successForgotPassword = "\nPassword changed successfully, redirecting to login page";
        public static string successLogout = "\nLogged out successfully, redirecting to login page.";

        public static string loginSuccess = "\nLogin successfull, welcome User.";
        public static string loginFail = "\nLogin failed, create new user";
        public static string logout = "\nDo you want to logout press y";
        public static string login = "\nWelcome to Login Page:";
        public static string register = "\nWelcome to New User, enter your details to create new account:";
        public static string forgotPassword = "\nWelcome to forgot Password page";
        public static string userExist = "\n user already exist, redirecting to login page.";

        public static string username = "\nEnter Username: ";
        public static string password = "\nEnter Password: ";
        public static string confirmPassword = "\nConfirm your Password: ";
        public static string mobile = "\nEnter Mobile number : ";
        public static string email = "\nEnter Email ID: ";
    }
}
