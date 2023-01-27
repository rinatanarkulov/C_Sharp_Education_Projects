namespace _024_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value;
            int g = 0, x = 1, y = 2, z = 3;

            if (x > y && Convert.ToInt32(Console.ReadLine())<15)
            {
                g = y;
                value = g + 3.1415926535897931;
                Console.WriteLine($"число g = {g}, значение value ={value}");
            }
            else if (z == y && z < 4)
            {
                g = z;
                value = g + 3.1415926535897931 * 2;
                Console.WriteLine($"число g = {g}, значение value = {value}");
            }
            Console.ReadKey();
        }
    }
}