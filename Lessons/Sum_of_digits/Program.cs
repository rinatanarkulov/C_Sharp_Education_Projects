﻿namespace Sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sumOfDigits(string x)
            {
                
                for(int i = 0; i < x.Length; i++)
                {
                    switch (Convert.ToString(x[i]))
                    {
                        case "1":
                            sum+=1;
                            break;
                        case "2":
                            sum+= 2;
                            break;
                        case "3":
                            sum+=3;
                            break;
                        case "4":
                            sum+=4;
                            break;
                        case "5":
                            sum+=5;
                            break;
                        case "6":
                            sum+=6;
                            break;
                        case "7":
                            sum+=7;
                            break;
                        case "8":
                            sum+=8;
                            break;
                        case "9":
                           sum+=9;
                            break;
                        default:
                            sum+=0;
                            break;
                }
                }
                return sum;
              
            }
            Console.WriteLine("Введите число, чтобы узнать сумму его цифр:");
            string ? r = Console.ReadLine();
            sumOfDigits(r);
            string result="";
            for (int i = 0; i < r.Length-1; i++)
            {
                result += (r[i] + " + ");
            }
            result += r[^1] + " = " + sum;
            Console.WriteLine(result);
        }
    }
}