using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Arithmetical_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10, y = 12, z = 3;
            x += y - x++ * z;  // -8
            Console.WriteLine(x);
            z = --x - y * 5; // -69
            Console.WriteLine(z);
            y /= x + 5 % z; // -3
            Console.WriteLine(y);
            z = x++ + y * 5; //-24
            Console.WriteLine(z);
            
            x = y - x++ * z; // -195
            Console.WriteLine(x);
            Console.ReadKey(); 
        }
    }
}
