
internal class Program
{ 
    private static void Main(string[] args)
    {
        Console.Write("Фамилия запросившего субсидию: ");
        string? name = Console.ReadLine();

        Console.Write($"{name} является пенсионером? : ");
        bool isPensioner = Console.ReadLine().Contains("yes");

        Console.Write($"{name} состоит на учёте в службе занятости? : ");
        bool isUnemployed = Console.ReadLine().Contains("yes");

        Console.Write($"{name} имеет трудоустройство? : ");
        bool isEmployment = Console.ReadLine().Contains("yes");

        bool subsidyAllowed = (isPensioner | isUnemployed) & !isEmployment;

        Console.Write($"{name} имеет право на субсидию : {subsidyAllowed}");

        // Delay
        Console.ReadKey();
    }
}