using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = Console.ReadLine();
            //string[] fileInfo = filePath
            //    .Split('\\')
            //    .Last()
            //    .Split('.')
            //    .ToArray();
            //string fileName = string.Join(".", fileInfo.Take(fileInfo.Length - 1));
            //string fileExtension = fileInfo.Last();
            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {fileExtension}");


            //string lastWord = string.Empty;
            //for (int i = 0; i < filePath.Length; i++)
            //{
            //    if (i == filePath.Length - 1)
            //    {
            //        lastWord = filePath[i];
            //    }
            //}
            //string[] result = lastWord.Split(".");
            //Console.WriteLine($"File name: {result[0]}");
            //Console.WriteLine($"File extension: {result[1]}");

            string filePath = Console.ReadLine();
            //C:\Internal\training-internal\Template.pptx.exe

            string fileInfo = filePath.Substring(filePath.LastIndexOf("\\") + 1);

            int dotIndex = fileInfo.LastIndexOf('.');

            string fileName = fileInfo.Substring(0, dotIndex);
            string fileExtension = fileInfo.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
