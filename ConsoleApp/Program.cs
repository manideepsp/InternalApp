using BusinessModel;
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            User user = new User();
            Literal lit = new Literal();
            Authentication authenticate = new Authentication();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine(lit.div);
                Console.WriteLine(lit.menu);
                user.Input = Convert.ToInt32(Console.ReadLine());
                int redirect = user.Input;


                switch (redirect)
                {
                    case 0:
                        flag = false;
                        break;
                    case 1:
                        Console.WriteLine(lit.div, lit.login);
                        redirect = authenticate.Login(user, lit);
                        break;

                    case 2:
                        Console.WriteLine(lit.div, lit.register);
                        redirect = authenticate.Register(user, lit);
                        break;

                    case 3:
                        Console.WriteLine(lit.div, lit.forgotPassword);
                        redirect = authenticate.ForgotPassword(user, lit);
                        break;
                    case 4:
                        Console.WriteLine(lit.div,lit.loggedIn, lit.logout);
                        redirect = authenticate.Logout(user, lit);
                        break;
                    default:
                        Console.WriteLine(lit.div, lit.switchDefault);
                        redirect = authenticate.switchDefault(user, lit);
                        break;
                }
            }
        }
    }
}
