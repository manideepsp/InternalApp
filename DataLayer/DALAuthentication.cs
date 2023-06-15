using BusinessModel;

namespace DataLayer
{
	public class DALAuthentication
	{
		public bool Register(User user)
		{
			DataSources.listData.Add(user.Username);
			DataSources.listData.Add(user.Password);
			DataSources.listData.Add(user.Mobile);
			DataSources.listData.Add(user.Email);

			DataSources.userData.Add(DataSources.listData);
			return true;
		}

		public bool IsExisting(string username)
		{
			for (int i = 0; i < DataSources.userData.Count; i++)
			{
				if (DataSources.userData[i].Contains(username))
					return true;
			}
			return false;
		}
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
