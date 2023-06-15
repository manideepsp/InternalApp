using BusinessModel;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public class BALValidations
    {
        DALAuthentication authenticate = new DALAuthentication();
        public bool IsValidUsername(string userName)
        {
            if(!authenticate.IsExisting(userName))
            {
                return true;
            }
            return false;
        }
        public bool IsValidLogin(string userName, string password)
        {
            if (authenticate.IsExisting(userName, password))
            {
                return true;
            }
            return false;
        }
        public bool IsValidPassword(string password)
        {
            if (password == null || password.Length < 8 || Regex.IsMatch(password, "[a-z]") == false || Regex.IsMatch(password, "[A-Z]") == false || Regex.IsMatch(password, "[0-9]") == false)
            {
                return false;
            }
            return true;
        }
        public bool IsPasswordEquals(string a, string b)
        {
            if (a.Equals(b)) return true;
            else return false;
        }
        public bool IsValidEmail(string email)
        {
            if(email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.IndexOf("."))
            {
                return true;
            }
            return false;
        }
        public bool IsValidMobile(string mobileNumber)
        {
            if (mobileNumber.Count() == 10 && IsDigitsOnly(mobileNumber))
            {
                return true;
            }
            else return false;
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
