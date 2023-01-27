namespace _024_ComplexityAndImaginaryActions
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
                decimal discountPercentage;
                {
                    const decimal MIN_TILE_QTY_FOR_50_PCT = 1000,
                                  MIN_TILE_QTY_FOR_20_PCT = 500;
                    if (tileQuantity >= MIN_TILE_QTY_FOR_50_PCT)
                    {
                        discountPercentage = 0.5m;
                    }
                    else if (tileQuantity >= MIN_TILE_QTY_FOR_20_PCT)
                    {
                        discountPercentage = 0.2m;
                    }
                    else
                    {
                        discountPercentage = 0;
                    }
                }
                discount = tileCost * discountPercentage;
            }
            decimal paymentAmount = tileCost - discount;
            Console.WriteLine($"Total cost     : {tileCost} KGS");
            Console.WriteLine($"Discount amount: {discount} KGS");
            Console.WriteLine($"Payment amount : {paymentAmount} KGS");

            Console.ReadKey(); //delay
        }
    }
}