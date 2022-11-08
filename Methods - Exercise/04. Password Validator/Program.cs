﻿using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool isLengthValid = IsPasswordLengthValid(inputPassword);
            bool isPassAlphaNumeric = IsPasswordAlphaNumeric(inputPassword);
            bool hasTwoDigits = IsPasswordContaingAtLeastTwoDigits(inputPassword);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPassAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLengthValid && isPassAlphaNumeric && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthValid (string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordContaingAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;
        }
    }
}
