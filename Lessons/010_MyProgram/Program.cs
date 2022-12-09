using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_MyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 fullname = 1;
            int shortname = 2;
            Console.WriteLine(fullname); 
            Console.WriteLine(shortname);

            Console.WriteLine(); // separator

            int negativenumber = -1; // 1111 1111 1111 1111 1111 1111 1111 1111
            uint naturalnumber = 4294967295; // 1111 1111 1111 1111 1111 1111 1111 1111

            Console.WriteLine(negativenumber); 
            Console.WriteLine(naturalnumber);

            Console.WriteLine(Convert.ToString(negativenumber,2));
            Console.WriteLine(Convert.ToString(naturalnumber, 2));

            Console.WriteLine(); // separator

            byte im_valueOfLowerType = 255;
            int im_valueOfGreaterType = im_valueOfLowerType; // implicit conversion

            Console.WriteLine(im_valueOfLowerType);
            Console.WriteLine(im_valueOfGreaterType);

            int ex_valueOfGreaterType = 256; // explicit conversion
            byte ex_valueOfLowerType = (byte)ex_valueOfGreaterType;

            Console.WriteLine(ex_valueOfLowerType);
            Console.WriteLine(ex_valueOfGreaterType);

            Console.WriteLine(); // separator

            byte a = 255;
            sbyte b = -128;
            ushort c = 65_535;
            short d = -32_768;

            uint e = 4_294_967_295U;
            int f = -2_147_483_648;

            ulong g = 18_446_744_073_709_551_615UL;
            long h = -9_223_372_036_854_775_808L;

            float i = -1.12345F;
            double j = -1.12345D;
            decimal k = -1.12345M;


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
