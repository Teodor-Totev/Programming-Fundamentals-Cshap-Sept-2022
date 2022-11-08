using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string cmdType = cmdArg[0];
                if(cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    FixInvalidIndexes(words, ref startIndex, ref endIndex);
                    MergedWords(words, startIndex, endIndex);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArg[1]);
                    int partitions = int.Parse(cmdArg[2]);

                    string word = words[index];
                    List<string> partitionsList = DivideWord(word, partitions);

                    words.RemoveAt(index);
                    words.InsertRange(index, partitionsList);
                }
            }
            Console.WriteLine(string.Join(" ", words));
        }

        static void FixInvalidIndexes (List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }

            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }
        }

        static void MergedWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex];
                mergedText += currWord;
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, mergedText);
        }

        static List<string> DivideWord (string word, int partitions)
        {
            int substringLength = word.Length / partitions;
            int lastSubstringLength = word.Length - ((partitions - 1) * substringLength);

            List<string> partitionsList = new List<string>();
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringLength;
                if (i == partitions - 1)
                {
                    desiredLength = lastSubstringLength;
                }
                char[] newPartitionArr = word
                    .Skip(i * substringLength)
                    .Take(desiredLength)
                    .ToArray();
                string newPartiton = string.Join("", newPartitionArr);
                partitionsList.Add(newPartiton);
            }
            return partitionsList;
            
        }
    }
}
