namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "*";
            string space = " ";
            Console.WriteLine("Введите размер треугольника (int):");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s > 0)
            {
                for (int i = 1; i <= s; i++)
                {
                    //for(int j= 1; j < s*2; j++)
                    //{
                    //    Console.Write($"{str} ");
                    //}
                    if (i == 1)
                    {
                        for (int j = 1; j <= s * 2; j++)
                        {
                            if (j != s) Console.Write(space);
                            else Console.Write(str);
                        }
                    }
                    else if (i == s)
                    {
                        for (int j = 1; j <= s; j++)
                        {
                            Console.Write(str + space);
                        }

                    }
                    else
                    {
                        //for(int j = 1; j <= s*2; j++)
                        //{
                        for (int k = 1; k <= s - i; k++)
                        {
                            Console.Write(space);
                        }
                        Console.Write(str);
                        for (int k = 1; k <= i * 2 - 3; k++)
                        {
                            Console.Write(space);
                        }
                        Console.Write(str);
                        for (int k = 1; k <= s - i; k++)
                        {
                            Console.Write(space);
                        }
                        //}
                    }
                    Console.WriteLine("\n");
                }
            }
            else Console.WriteLine("Вы должны ввести положительное число, перезапустите программу");





            //int n = int.Parse(Console.ReadLine());

            //// n итераций
            //for (int i = 1; i <= n; i++)
            //{
            //    // выведет линию из i звездочек
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



        }
    }
}