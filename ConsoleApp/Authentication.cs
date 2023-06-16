using BusinessLayer;
using BusinessModel;

namespace ConsoleApp
{
    /// <summary>
    /// Class that does authentication in Presentation layer
    /// </summary>
    public class Authentication
    {
        BALAuthentication authenticate = new BALAuthentication();
        bool decision;

        /// <summary>
        /// Implements login authentication signature
        /// </summary>
        /// <param name="user"></param>
        /// <param name="lit"></param>
        /// <returns></returns>
        public int Login(User user)
        {
            decision = authenticate.Login(user);
            if (decision)
            {
                return 4;
            }
            else return 1;
        }

        //Implements logout authentication signature
        public int Logout()
        {
            decision = authenticate.Logout();
            if (decision)
            {
                return 1;
            }
            return 4;
        }

        //Implements Register authentication signature
        public int Register(User user)
        {
            decision = authenticate.Register(user);
            return 1;
        }

        //Implements ForgotPassword authentication signature
        public int ForgotPassword(User user)
        {
            decision = authenticate.ForgotPassword(user);
            if (decision)
            {
                return 1;
            }
            return 1;
        }

        //Implements SwitchDefault signature
        public int SwitchDefault()
        {
            decision = authenticate.SwitchDefault();
            if (decision)
            {
                return 0;
            }
            return 1;
        }
    }
}
