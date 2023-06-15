using BusinessModel;
using System;
using System.Collections.Generic;
//using DataSources;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            User user = new User();
            Literal lit = new Literal();
            Authentication authenticate = new Authentication();

            //DataSources.userData.Add(new List<string> { "name", "password", "emial", "mobile" });
            //Console.WriteLine(DataSources.userData[0][1]);

            Console.WriteLine(lit.div);
            Console.WriteLine(lit.menu);
            user.Input = Convert.ToInt32(Console.ReadLine());
            int redirect = user.Input;
            bool flag = true;
            while (flag)
            {
                switch (redirect)
                {
                    //exit
                    case 0:
                        flag = false;
                        break;

                    //login
                    case 1:
                        Console.WriteLine(lit.div, lit.login);
                        redirect = authenticate.Login(user, lit);
                        break;

                    //register
                    case 2:
                        Console.WriteLine(lit.div, lit.register);
                        redirect = authenticate.Register(user, lit);
                        break;

                    //forgot password
                    case 3:
                        Console.WriteLine(lit.div, lit.forgotPassword);
                        redirect = authenticate.ForgotPassword(user, lit);
                        break;

                    //logout
                    case 4:
                        Console.WriteLine(lit.div, lit.loggedIn, lit.logout);
                        redirect = authenticate.Logout(lit);
                        break;

                    //default
                    default:
                        Console.WriteLine(lit.div, lit.switchDefault);
                        redirect = authenticate.SwitchDefault(lit);
                        break;
                }
            }
        }
    }
}
