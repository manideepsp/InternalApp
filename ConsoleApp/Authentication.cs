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
        public int Login(User user, Literal lit)
        {
            decision = authenticate.Login(user, lit);
            if (decision)
            {
                return 4;
            }
            else return 1;
        }

        //Implements logout authentication signature
        public int Logout(Literal lit)
        {
            decision = authenticate.Logout(lit);
            if (decision)
            {
                return 1;
            }
            return 4;
        }

        //Implements Register authentication signature
        public int Register(User user, Literal lit)
        {
            decision = authenticate.Register(user, lit);
            return 1;
        }

        //Implements ForgotPassword authentication signature
        public int ForgotPassword(User user, Literal lit)
        {
            decision = authenticate.ForgotPassword(user, lit);
            if (decision)
            {
                return 1;
            }
            return 1;
        }

        //Implements SwitchDefault signature
        public int SwitchDefault(Literal lit)
        {
            decision = authenticate.SwitchDefault(lit);
            if (decision)
            {
                return 0;
            }
            return 1;
        }
    }
}
