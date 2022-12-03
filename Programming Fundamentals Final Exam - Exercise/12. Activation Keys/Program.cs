using System;

namespace _12._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command;
            while((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = command.Split(">>>");
                string cmdType = cmdArgs[0];

                if (cmdType == "Contains")
                {
                    string subString = cmdArgs[1];

                    if (activationKey.Contains(subString))
                    {
                        Console.WriteLine($"{activationKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmdType == "Flip")
                {
                    string upperOrLowerCommand = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);

                    string subString = activationKey.Substring(startIndex, endIndex - startIndex);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

                    if (upperOrLowerCommand == "Upper")
                    {
                        //subString = subString.ToUpper();
                        activationKey = activationKey.Insert(startIndex, subString.ToUpper());
                    }
                    else if (upperOrLowerCommand == "Lower")
                    {
                        activationKey = activationKey.Insert(startIndex,subString.ToLower());
                    }

                    Console.WriteLine(activationKey);
                }
                else if (cmdType == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
