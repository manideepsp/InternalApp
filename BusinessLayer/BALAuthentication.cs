﻿using BusinessModel;
using DataLayer;
using System;

namespace BusinessLayer
{
    public class BALAuthentication
    {
        BALValidations validate = new BALValidations();
        DataSources dataOperation = new DataSources();
        bool decision = false;
        public bool Login(User user, Literal lit)
        {
            Console.Write(lit.username);
            user.Username = Console.ReadLine();
            Console.WriteLine(lit.password);
            user.Password = Console.ReadLine();

            decision = validate.IsValidLogin(user.Username, user.Password);
            return decision;

        }
        bool flag = true;
        public bool Register(User user, Literal lit)
        {
            Console.Write(lit.username);
            user.Username = Console.ReadLine();
            flag = validate.IsValidUsername(user.Username); //returns true if username is valid, not already exist
            if (!flag)
            {
                Console.WriteLine(lit.userExist);
                return false;
            }

            Console.Write(lit.password);
            user.Password = Console.ReadLine();
            flag = validate.IsValidPassword(user.Password); //returns true if password is valid
            while (!flag)
            {
                Console.Write(lit.password);
                user.Password = Console.ReadLine();
                flag = validate.IsValidPassword(user.Password);
            }
            Console.Write(lit.confirmPassword);
            user.ConfirmPassword = Console.ReadLine();
            flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword); //returns true id password mathces
            while (!flag)
            {
                Console.Write(lit.confirmPassword);
                user.ConfirmPassword = Console.ReadLine();
                flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword);
            }

            Console.Write(lit.mobile);
            user.Mobile = Console.ReadLine();
            flag = validate.IsValidMobile(user.Mobile); //returns true if mobile is valid
            while (!flag)
            {
                Console.Write(lit.mobile);
                user.Mobile = Console.ReadLine();
                flag = validate.IsValidMobile(user.Mobile);
            }

            Console.Write(lit.email);
            user.Email = Console.ReadLine();
            flag = validate.IsValidEmail(user.Email); //returns true if email is valid
            while (!flag)
            {
                Console.Write(lit.email);
                user.Email = Console.ReadLine();
                flag = validate.IsValidEmail(user.Email);
            }

            decision = dataOperation.Register(user);
            Console.WriteLine(lit.success);
            return decision;

        }
        public bool ForgotPassword(User user, Literal lit)
        {
            Console.WriteLine(lit.username);
            user.Username = Console.ReadLine();
            decision = validate.IsValidUserName(user.Username); //returns true if username is valid, not already exist
            if (!decision)
            {
                Console.Write(lit.userExist);
                return false;
            }

            Console.Write(lit.password);
            user.Password = Console.ReadLine();
            flag = validate.IsValidPassword(user.Password); //returns true if password is valid
            while (!flag)
            {
                Console.Write(lit.password);
                user.Password = Console.ReadLine();
                flag = validate.IsValidPassword(user.Password);
            }
            Console.Write(lit.confirmPassword);
            user.ConfirmPassword = Console.ReadLine();
            flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword); //returns true id password mathces
            while (!flag)
            {
                Console.Write(lit.confirmPassword);
                user.ConfirmPassword = Console.ReadLine();
                flag = validate.IsPasswordEquals(user.Password, user.ConfirmPassword);
            }
            Console.WriteLine(lit.success);
            return true;
        }
        public bool Logout(User user, Literal lit)
        {
            Console.WriteLine(lit.logout);
            ConsoleKeyInfo cki = Console.ReadKey();
            if(cki.Key == ConsoleKey.Y)
            {
                decision = true;
            }
            else
            {
                decision= false;
            }
            return decision;
        }
        public bool switchDefault(User user, Literal lit)
        {
            Console.WriteLine(lit.switchDefault);
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Y)
            {
                decision = true;
            }
            else
            {
                decision = false;
            }
            return decision;
        }
    }
}