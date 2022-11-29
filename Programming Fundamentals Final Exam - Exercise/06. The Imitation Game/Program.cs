using System;

namespace _06._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = command.Split('|');
                string cmdType = cmdArgs[0];
                if (cmdType == "Move")
                {
                    //Moves the first n letters to the back of the string
                    int lettersToMove = int.Parse(cmdArgs[1]);
                    string substring = message.Substring(0, lettersToMove);
                    message = message.Remove(0, lettersToMove);
                    message += substring;
                    
                }
                else if (cmdType == "Insert")
                {
                    //Inserts the given value before the given index in the string
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    message = message.Insert(index, value);
                }
                else if (cmdType == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                    }
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
