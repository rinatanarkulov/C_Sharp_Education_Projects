namespace S1_The_Simplest_Programs___Arithmetic_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // s1.1. Leave only two digits after the dot
            Console.WriteLine("s1.1. " + String.Format("{0:0.00}", 12.34567)); // 12.35

            // s1.2. Display the number e (the base of the natural logarithm) to the nearest tenth.
            Console.WriteLine("s1.2. " + Math.Round(Math.E, 2)); // 2.72

            /* s1.3. Write a program to display the number entered from the keyboard. 
              The displayed number must be preceded by the message "You have entered a number." */
            Console.Write("s1.3. Input a number: ");
            Console.WriteLine("s1.3. You have input a number " + Console.ReadLine());

            /* s1.4. Write a program to display the number entered from the keyboard. 
            After the displayed number, the message “- this is the number you entered” should follow.*/
            Console.Write("s1.4. Input a number: ");
            Console.WriteLine("s1.4 " + Console.ReadLine() + " - this is the number you entered");

            // s1.5. Print the numbers 1, 13 and 49 on one line with one space between them
            Console.WriteLine("s1.5. " + "1 13 49");

            // s1.6. Print on one line the numbers 7, 15 and 100 with two spaces between them.
            Console.WriteLine("s1.6. " + "7  15  100");

            // s1.7. Write a program to display on the screen in one
            // line three any numbers with two spaces between them.
            Console.WriteLine("s1.7. 3  4  5");

            // s1.8. Write a program to display on the screen in one
            // line four any numbers with one space between them.
            Console.WriteLine("s1.8. 6  7  8  9");

            // s1.9. Display the numbers 50 and 10 one below the other.
            Console.WriteLine("s1.9. 50");
            Console.WriteLine("      10");

            // s1.10. Display the numbers 5, 10 and 21 one below the other.
            Console.WriteLine("s1.10. 5");
            Console.WriteLine("      10");
            Console.WriteLine("      21");

            // s1.11. Write a program to display a "column" of four any numbers on the screen.
            Console.WriteLine("s1.11. 9");
            for (int i = 10; i < 13; i++)
                Console.WriteLine("       " + i);

            // s1.12. Write a program to display the following information on the screen:
            // 5 10
            // 7 cm
            Console.WriteLine("s1.12. 5 10 \n       7 cm");

            // s1.13. Write a program to display the following information on the screen:
            // 2 kg
            // 13 17
            Console.WriteLine("s1.13 2 kg \n      13 17");

            // Delay
            Console.ReadKey();

        }
    }
}