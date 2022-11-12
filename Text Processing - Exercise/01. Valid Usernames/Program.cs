namespace _01._Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
            .Split(", ");

            List<string> validUserNames = new List<string>();

            foreach (var currUser in userNames)
            {
                if (currUser.Length >= 3 && currUser.Length <= 16)
                {
                    bool validUsernames = ValidUserNames(currUser);
                    if (validUsernames == true)
                    {
                        validUserNames.Add(currUser);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }
        private static bool ValidUserNames(string user)
        {
            foreach (var ch in user)
            {
                if (char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
