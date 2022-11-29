using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+(?<barcode>[A-Z]+[A-Za-z0-9]{4,}[A-Z]+)@#+";
            //Regex pattern = new Regex(@"@#+(?<barcode>[A-Z]+[A-Za-z0-9]{4,}[A-Z]+)@#+);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string barcode = match.Groups["barcode"].Value;
                    //char[] digits = barcode.Where(x => char.IsDigit(x)).ToArray();

                    GetDigitOrLetterValueAndPrint(barcode);
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
        static void GetDigitOrLetterValueAndPrint (string barcode)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < barcode.Length; i++)
            {
                if (char.IsDigit(barcode[i]))
                {
                    int currDigit = barcode[i] - '0';
                    string currDigitToStr = currDigit.ToString();
                    sb.Append(currDigitToStr);
                }
            }
            if (sb.Length == 0)
            {
                Console.WriteLine("Product group: 00");
            }
            else
            {
                Console.WriteLine($"Product group: {sb}");
            }
        }
    }
}
