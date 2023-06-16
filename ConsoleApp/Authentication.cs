using BusinessLayer;
using BusinessModel;
using System;

namespace ConsoleApp
{
	/// <summary>
	/// Class that does authentication in Presentation layer
	/// </summary>
	public class Authentication
	{
		private BALAuthentication balAuth;
		public Authentication()
		{
			balAuth = new BALAuthentication();
		}
		bool decision;

		/// <summary>
		/// Implements login authentication signature
		/// </summary>
		/// <param name="user"></param>
		/// <param name="lit"></param>
		/// <returns></returns>
		public int Login(User user)
		{
			Console.WriteLine(Literal.login);
			Console.Write(Literal.username);
			user.Username = Console.ReadLine();
			Console.WriteLine(Literal.password);
			user.Password = Console.ReadLine();

			if (balAuth.Login(user))
			{
				Console.WriteLine(Literal.loginSuccess);
				return 4;
			}
			else
			{
				Console.WriteLine(Literal.loginFail);
				return 1;
			}
		}

		//Implements logout authentication signature
		public int Logout()
		{
			decision = balAuth.Logout();
			if (decision)
			{
				return 1;
			}
			return 4;
		}

		//Implements Register authentication signature
		public int Register(User user)
		{
			decision = balAuth.Register(user);
			return 1;
		}

		//Implements ForgotPassword authentication signature
		public int ForgotPassword(User user)
		{
			decision = balAuth.ForgotPassword(user);
			if (decision)
			{
				return 1;
			}
			return 1;
		}

		//Implements SwitchDefault signature
		public int SwitchDefault()
		{
			decision = balAuth.SwitchDefault();
			if (decision)
			{
				return 0;
			}
			return 1;
		}
	}
}
