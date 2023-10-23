using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Task1 : BaseTask 
    {
        
        public static void WriteText(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
