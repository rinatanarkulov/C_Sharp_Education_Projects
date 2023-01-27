namespace _021_Checked_and_Unchecked_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint minutesQuarter;
            {
                // 1. Request the amount of minutes per month from an accountant
                Console.Write("Enter the number of minutes of calls for January: ");
                uint minutesJanuary = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Enter the number of minutes of calls for February: ");
                uint minutesFebruary = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Enter the number of minutes of calls for March: ");
                uint minutesMarch = Convert.ToUInt32(Console.ReadLine());

                checked
                {
                    // 2. Calculate the number of minutes per quarter
                    minutesQuarter = minutesJanuary + minutesFebruary + minutesMarch;
                }
            }
            decimal totalCost; // KGS
            {
                // 3. Calculate the cost of all calls per quarter
                decimal price = 2; // KGS
                totalCost = minutesQuarter* price;

            }
            decimal tax; // KGS
            {
                // 4. Calculate the number of taxes per quarter
                decimal taxRate = 0.2m; // 20%
                tax = totalCost* taxRate;
            }
            // 5. Display on screen: the total number of minutes per quarter,
            //                       the total cost of all minutes and the tax
            Console.WriteLine($"The total number of minutes per quarter = {minutesQuarter}, " +
                $"the total cost of all minutes = {totalCost} KGS and the tax = {tax} KGS");

            // Delay
            Console.ReadKey();

            /* Sample of using checked and unchecked
            int a = int.MaxValue;
            int b = checked(a + 1);
            Console.WriteLine(b);

            int c = int.MaxValue;
            int d = unchecked(c + 1);
            Console.WriteLine(d);

            int e = int.MinValue;
            int f = checked(e - 1);
            Console.WriteLine(f);


            Converting
            long a = long.MaxValue;
            int b = checked((int)a);
            Console.WriteLine(b);

            ulong c = ulong.MaxValue;
            uint d = checked((uint)c);
            Console.WriteLine(d);

            double e = double.MaxValue;
            int f = checked((int)e);
            Console.WriteLine(f);
             */
        }
    }
}