using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Task2 : BaseTask 
    {
        public static void ReverseWords(string[] words)
        {
            Array.Reverse (words);
            string result = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i] + ' ';
            }
            Console.WriteLine(result);
        }
    }
}

