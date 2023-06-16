using BusinessModel;

namespace DataLayer
{
	public  class DALAuthentication
	{

		internal DALAuthentication() { }

		/// <summary>
		/// adds the user details to the database
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public bool Register(User user)
		{
			DataSources.listData.Add(user.Username);
			DataSources.listData.Add(user.Password);
			DataSources.listData.Add(user.Mobile);
			DataSources.listData.Add(user.Email);

			DataSources.userData.Add(DataSources.listData);
			return true;
		}

		/// <summary>
		/// checks if the username, overloaded with another method with similar functionality
		/// </summary>
		/// <param name="username"></param>
		/// <returns></returns>
		public bool IsExisting(string username)
		{
			for (int i = 0; i < DataSources.userData.Count; i++)
			{
				if (DataSources.userData[i].Contains(username))
					return true;
			}
			return false;
		}

		/// <summary>
		/// checks if username and password pair exist in database or not
		/// </summary>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public bool IsExisting(string username, string password)
		{
			for (int i = 0; i < DataSources.userData.Count; i++)
			{
				if (DataSources.userData[i].Contains(username) && DataSources.userData[i].Contains(password))
					return true;
			}
			return false;
		}
	}
}
