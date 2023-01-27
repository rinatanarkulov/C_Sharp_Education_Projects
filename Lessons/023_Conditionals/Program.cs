namespace _023_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal tileQuantity, tilePrice;
            {
                Console.Write("The number of tiles in square meters: ");
                string? strQuantity = Console.ReadLine();
                tileQuantity = Convert.ToUInt32(strQuantity);

                Console.Write("The price of a tile per square meter: ");
                string? strPrice = Console.ReadLine();
                tilePrice = Convert.ToUInt32(strPrice);
            }
            decimal tileCost = tileQuantity * tilePrice; // KGS
            decimal discount;
            {
                const decimal MIN_TILE_QUANTITY_FOR_DISCOUNT = 100;
                bool discountAvailable = tileQuantity >= MIN_TILE_QUANTITY_FOR_DISCOUNT;
                if (discountAvailable)
                {
                    const decimal DISCOUNT_PERCENTAGE = 0.1m; // 10%
                    discount = tileCost * DISCOUNT_PERCENTAGE;
                }
                else
                {
                    discount = 0;
                }
                    
            }
            decimal paymentAmount = tileCost - discount;
            Console.WriteLine($"Total cost     : {tileCost} KGS");
            Console.WriteLine($"Discount amount: {discount} KGS");
            Console.WriteLine($"Payment amount : {paymentAmount} KGS");

            Console.ReadKey(); //delay
        }
    }
}