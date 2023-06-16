using BusinessModel;
using System;
using System.Collections.Generic;
//using DataLayer;

namespace ConsoleApp
{
	/// <summary>
	/// program class
	/// </summary>
	public class Program
	{
		/// <summary>
		/// main method
		/// </summary>
		public static void Main()
		{
			//objects creation
			Authentication authenticate = new Authentication();
			User user = new User();

			//DataSources.userData.Add(new List<string> { "name", "password", "emial", "mobile" });
			//Console.WriteLine(DataSources.userData[0][1]);

			Console.WriteLine(Literal.div);
			Console.WriteLine(Literal.menu);
			int input = Convert.ToInt32(Console.ReadLine());
			int redirect = input;
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
						Console.WriteLine(Literal.div, Literal.login);
						redirect = authenticate.Login(user);
						break;
					//register
					case 2:
						Console.WriteLine(Literal.div, Literal.register);
						redirect = authenticate.Register(user);
						break;
					//forgot password
					case 3:
						Console.WriteLine(Literal.div, Literal.forgotPassword);
						redirect = authenticate.ForgotPassword(user);
						break;
					//logout
					case 4:
						Console.WriteLine(Literal.div, Literal.loggedIn, Literal.logout);
						redirect = authenticate.Logout();
						break;
					//default
					default:
						Console.WriteLine(Literal.div, Literal.switchDefault);
						redirect = authenticate.SwitchDefault();
						break;
				}
			}
		}
	}
}
