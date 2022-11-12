namespace _04._Caesar_Cipher
{
    using System;
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (var ch in text)
            {
                int currCh = (int)ch + 3;
                char newChar = (char)currCh;
                encryptedText.Append(newChar);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
