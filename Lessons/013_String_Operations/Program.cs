using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_String_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            bool b = "55" < "60";
            Console.WriteLine();
            Console.WriteLine("Please, write a word. Program will split it by each character");
            sentence = Console.ReadLine();
            
            foreach (char chr in sentence)
            { 
                Console.WriteLine(chr);
            }
            Console.WriteLine(sentence[0]);   
            Console.ReadKey();
        }


    }
}
