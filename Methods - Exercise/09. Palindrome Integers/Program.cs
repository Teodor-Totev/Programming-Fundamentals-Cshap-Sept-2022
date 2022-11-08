using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(command != "END")
            {
                bool isPalindrome = IsPalindromeInteger(command);
                Console.WriteLine(isPalindrome);
                command = Console.ReadLine();
            }

        }
        static bool IsPalindromeInteger (string num)
        {
            string currNum = string.Empty;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                currNum += num[i];
            }
            if (currNum == num)
            {
                return true;
            }
            return false;
        }
    }
}
