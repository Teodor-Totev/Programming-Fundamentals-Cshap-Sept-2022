using System;
using System.Text;

namespace _07._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            string command;
            while((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(' ');
                string cmdType = cmdArgs[0];
                if (cmdType == "TakeOdd")
                {
                    //Take odd
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    //string substring = sb.ToString().Substring(index, length);
                    //int indexOf = sb.ToString().IndexOf(substring);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);

                }
                else if (cmdType == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
