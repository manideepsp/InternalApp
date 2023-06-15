namespace BusinessModel
{
    /// <summary>
    /// This class contains all the string literals used in the Application
    /// </summary>
    public class Literal
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

        public string menu = "Welcome to Landing page"
                + "\n  Enter: "
                + "\n* 1. To Login"
                + "\n* 2. To Register As new user"
                + "\n* 3. If you forgot you password"
                + "\n* enter any other key to exit";
        public string div = "\n*********************************************";
        public string switchDefault = "\ndo you want to exit y/n ?";
        public string successRegistration = "\nUser created Successfully ! ";
        public string successForgotPassword = "\nPassword changed successfully, redirecting to login page";
        public string successLogout = "\nLogged out successfully, redirecting to login page.";

        public string loggedIn = "\nLogin successfull, welcome User.";
        public string logout = "\nDo you want to logout press y";
        public string login = "\nWelcome to Login Page:";
        public string register = "\nWelcome to New User, enter your details to create new account:";
        public string forgotPassword = "\nWelcome to forgot Password page";
        public string userExist = "\n user already exist, redirecting to login page.";

        public string username = "\nEnter Username: ";
        public string password = "\nEnter Password: ";
        public string confirmPassword = "\nConfirm your Password: ";
        public string mobile = "\nEnter Mobile number : ";
        public string email = "\nEnter Email ID: ";
    }
}
