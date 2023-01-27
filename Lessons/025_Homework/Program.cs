namespace _025_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aSide, bSide;
            {
                Console.Write("The \"a\" side of a rectangle is: ");
                aSide = Convert.ToDouble(Console.ReadLine());
                Console.Write("The \"b\" side of a rectangle is: ");
                bSide= Convert.ToDouble(Console.ReadLine());
            }
            double dblResult;
            string strResult, unit;
            {
                Console.WriteLine("Type PERIMETER or AREA if whichever you want to calculate");
                strResult = Console.ReadLine();
                bool isPerimeter = strResult.ToLower() == "perimeter",
                     isArea = strResult.ToLower() == "area";
                if (isPerimeter)
                {
                    dblResult = (aSide + bSide) * 2;
                    unit = "cm";
                }
                else if(isArea)
                {
                    dblResult = aSide * bSide;
                    unit = "square cm";
                }
                else
                {
                    dblResult = 0;
                    unit = "";
                    Console.WriteLine("Incorrect comand!");
                }


            }
            string output;
            {
                string addInfo;
                {
                    bool isSquare = aSide == bSide;
                    if (isSquare)
                    {
                        addInfo = ". This rectangle is also a SQUARE";
                    }
                    else
                    {
                        addInfo = "";
                    }
                }
                output = $"The {strResult} of this rectangle is {dblResult} {unit}" + addInfo;
            }
            Console.WriteLine(output);
            Console.ReadKey();
            switch (aSide)
            {
                default:
                    {
                        break;
                    }
            }
        }
    }
}