using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string bigNum = (Console.ReadLine());
            int multiplyNum = int.Parse(Console.ReadLine());

            if (multiplyNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int multiplyResult = 0;
            int remainder = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                int currDigit = bigNum[i] - '0';
                multiplyResult = currDigit * multiplyNum;
                multiplyResult += remainder;
                sb.Insert(0, multiplyResult % 10);
                remainder = multiplyResult / 10;
            }

            if (remainder > 0)
            {
                sb.Insert(0, remainder);
            }

            Console.WriteLine(sb);
        }
    }
}
