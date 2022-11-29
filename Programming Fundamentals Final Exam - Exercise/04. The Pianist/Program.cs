namespace _04._The_Pianist
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');

                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                if (!pieces.ContainsKey(piece))
                {
                    pieces[piece] = new List<string>();
                    pieces[piece].Add(composer);
                    pieces[piece].Add(key);
                }
            }

            string command;
            while((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command.Split("|");
                string cmdType = cmdArg[0];
                string piece = cmdArg[1];

                if (cmdType == "Add")
                {
                    string composer = cmdArg[2];
                    string key = cmdArg[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces[piece] = new List<string>();
                        pieces[piece].Add(composer);
                        pieces[piece].Add(key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (cmdType == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (cmdType == "ChangeKey")
                {
                    string newKey = cmdArg[2];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece].RemoveAt(1);
                        pieces[piece].Insert(1, newKey);
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var piece in pieces)
            {
                //"{Piece} -> Composer: {composer}, Key: {key}"
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
