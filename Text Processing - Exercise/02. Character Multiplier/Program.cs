namespace _02._Character_Multiplier
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string firstStr = input.Substring(0, input.IndexOf(' '));
            string secondStr = input.Substring(input.IndexOf(' ') + 1);

            int result = 0;
            if (firstStr.Length > secondStr.Length)
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    int ch1Value = (int)firstStr[i];
                    if (i >= secondStr.Length)
                    {
                        result += ch1Value;
                        continue;
                    }
                    int ch2Value = (int)secondStr[i];
                    result += ch1Value * ch2Value;
                }
            }
            else if (secondStr.Length > firstStr.Length)
            {
                for (int i = 0; i < secondStr.Length; i++)
                {
                    int ch2Value = (int)secondStr[i];
                    if (i >= firstStr.Length)
                    {
                        result += ch2Value;
                        continue;
                    }
                    int ch1Value = (int)firstStr[i];
                    result += ch1Value * ch2Value;
                }
            }
            else
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    int ch1Value = (int)firstStr[i];
                    int ch2Value = (int)secondStr[i];
                    result += ch1Value * ch2Value;
                }
            }


            //if (firstStr.Length > secondStr.Length)
            //{
            //    for (int i = 0; i < firstStr.Length; i++)
            //    {
            //        int ch1Value = (int)firstStr[i];
            //        int ch2Value = (int)secondStr[i];
            //        result += ch1Value * ch2Value;
            //    }
            //    int count = firstStr.Length - secondStr.Length;
            //    string reminder = firstStr.Substring(firstStr.Length - count);
            //    for (int i = 0; i < reminder.Length; i++)
            //    {
            //        int addToResult = (int)reminder[i];
            //        result += addToResult;
            //    }
            //}
            //else if (secondStr.Length > firstStr.Length)
            //{
            //    for (int i = 0; i < firstStr.Length; i++)
            //    {
            //        int ch1Value = (int)firstStr[i];
            //        int ch2Value = (int)secondStr[i];
            //        result += ch1Value * ch2Value;
            //    }
            //    int count = secondStr.Length - firstStr.Length;
            //    string reminder = secondStr.Substring(secondStr.Length - count);
            //    for (int i = 0; i < reminder.Length; i++)
            //    {
            //        int addToResult = (int)reminder[i];
            //        result += addToResult;
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < firstStr.Length; i++)
            //    {
            //        int ch1Value = (int)firstStr[i];
            //        int ch2Value = (int)secondStr[i];
            //        result += ch1Value * ch2Value;
            //    }
            //}
            Console.WriteLine(result);
        }
    }
}
