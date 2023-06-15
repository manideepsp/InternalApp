using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DALAuthentication
    {
        DataSources data = new DataSources();

        public bool Register(User user)
        {
            data.listData.Add(user.Username);
            data.listData.Add(user.Password);
            data.listData.Add(user.Mobile);
            data.listData.Add(user.Email);

            data.userData.Add(data.listData);
            return true;
        }

        public bool IsExisting(string username)
        {
            for (int i = 0; i < data.userData.Count; i++)
            {
                if (data.userData[i].Contains(username))
                    return true;
            }
            return false;
        }
        public bool IsExisting(string username, string password)
        {
            for (int i = 0; i < data.userData.Count; i++)
            {
                if (data.userData[i].Contains(username) && data.userData[i].Contains(password))
                    return true;
            }
            return false;
        }
    }
}
