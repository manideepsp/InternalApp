﻿using BusinessLayer;
using BusinessModel;

namespace ConsoleApp
{
    public class Authentication
    {
        BALAuthentication authenticate = new BALAuthentication();
        bool decision;
        public int Login(User user, Literal lit)
        {
            decision = authenticate.Login(user, lit);
            if (decision)
            {
                return 4;
            }
            else return 1;
        }
        public int Logout(Literal lit)
        {
            decision = authenticate.Logout(lit);
            if (decision)
            {
                return 1;
            }
            return 4;
        }
        public int Register(User user, Literal lit)
        {
            decision = authenticate.Register(user, lit);
            return 1;
        }
        public int ForgotPassword(User user, Literal lit)
        {
            decision = authenticate.ForgotPassword(user, lit);
            if (decision)
            {
                return 1;
            }
            return 1;
        }
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
