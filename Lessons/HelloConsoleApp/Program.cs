/*Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.WriteLine($"{num1}>{num2}");
}
else if (num1<num2)
{
    Console.WriteLine($"{num1}<{num2}");
}
else
{
    Console.WriteLine($"{num1}={num2}");
}*/
/*Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 5 || num1 == 10) Console.WriteLine("Число либо равно 5 и либо равно 10");
else Console.WriteLine("Неизвестное число");*/
/*Console.WriteLine("Введите сумму вклада: ");
double dep = Convert.ToDouble(Console.ReadLine());
if (dep < 100) dep *= 1.05;
else if (dep <= 200) dep *= 1.07;
else dep *= 1.1;
dep += 15;
Console.WriteLine($"Сумма вклада после начисления процентов:{dep}");*/
/*Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер операции: \n1.Сложение \n2.Вычитание \n3.Умножение ");
int input = Convert.ToInt32(Console.ReadLine());
switch(input)
{
    case 1:
        Console.WriteLine($"{num1+num2}");
        break;
    case 2:
        Console.WriteLine($"{num1-num2}");
        break;
    case 3:
        Console.WriteLine($"{num1 * num2}");
        break;
    default:
        Console.WriteLine("Операция неопределена");
        break;
}*/

/* Console.WriteLine("Введите сумму вклада: ");
decimal vklad = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество месяцев");
int m = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= m; i++)
{
    vklad *= 1.07M;
}
Console.WriteLine($"После {m} месяцев сумма вклада составит {vklad}"); */

/*Console.WriteLine("Введите сумму вклада: ");
decimal vklad = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество месяцев");
int m = Convert.ToInt32(Console.ReadLine());

while(m > 0)
{
    vklad *= 1.07M;
    m--;
}
Console.WriteLine($"После {m} месяцев сумма вклада составит {vklad}");*/

/*for (int i = 1; i<10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i*j}\t");
    }
    Console.WriteLine(); 
}*/
//while (true)
//{
//    Console.WriteLine("Введите первое число: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Введите второе число: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());

//    if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
//    {
//        Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
//    }
//    else
//    {
//        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//        break;
//    }
//}

//int[] numbers = {1, 2, 3};
//numbers[0] = 745;
//var n = numbers[0];
//Console.WriteLine(numbers[^1]);
//foreach (int i in numbers)
//{
//    Console.Write(i);
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//int[,,] nums3 = new int [4, 5, 6];


//int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
//int result = 0;
//foreach(int number in numbers)
//{
//    if (number > 0)
//    {
//        result++;
//    }
//}
//Console.WriteLine(result);

//int[] numbers = { -5,-4, -3, -2, -1, 0, 1, 2, 3, 4,5 };

//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for (int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach (int i in numbers)
//{
//    Console.Write($"{i} ");
//}

//int[] nums = { 56, 8, -59, 2, 4, 21, 32, 44, -5, 92, 9, 41, 78, -125 };
//int temp;
//for (int i = 0; i < nums.Length-1; i++)
//{
//    for (int j = i+1; j < nums.Length; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//            temp = nums[j];
//            nums[j] = nums[i];
//            nums[i] = temp;
//        }
//    }

//}
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.Write($"{nums[i]} ");
//}



//void SayGoodByeEn()
//{
//    Console.WriteLine("GoodBye, Motherfucker");
//}
//void SayGoodByeRu()
//{
//    Console.WriteLine("Пока, епта");
//}
//void SayGoodByeFr()
//{
//    Console.WriteLine("Au Revoir, Motherfucker");
//}
//void SayGoodByeIt() => Console.WriteLine("Arrividerci, Motherfucker");

//Console.WriteLine("Введите язык: en, ru, fr или it");
//string ? language = Console.ReadLine();
//switch (language)
//{
//    case "en":
//        SayGoodByeEn();
//        break;
//    case "ru":
//        SayGoodByeRu();
//        break;
//    case "fr":
//        SayGoodByeFr();
//        break;
//    case "it":
//        SayGoodByeIt();
//        break;
//}

//void PrintMessage(string message) => Console.WriteLine(message);
//PrintMessage("Я люблю Сюзи");

//void Sum(int x, int y)
//{
//    Console.WriteLine($"{x} + {y} = {x + y}");
//}
//Sum(12, 18);
//int a = 15;
//int c = 19;
//Sum(a, c);

//void PrintPerson(string name, int age = 1, string company = "Undefined")
//{
//    Console.WriteLine($"Name: {name}, Age: {age}, Company: {company}");
//}
//PrintPerson("Rinat", company:"Google", age:24);

//string GetMessage()
//{
//    return "Hello";
//}
//Console.WriteLine(GetMessage());

//int Multiplication(int x, int y)
//{
//    return x * y;
//}
//Console.WriteLine(Multiplication(5, 9));

//string GetBye() => "Bye";
//Console.WriteLine(GetBye());

//int Sum(int a, int b) => a + b;
//Console.WriteLine(Sum(6, 7));

//void PrintPerson(string name, int age)
//{
//    if (age > 120 || age < 1)
//    {
//        Console.WriteLine("Недопустимый возраст");
//        return;
//    }
//    Console.WriteLine($"Имя: {name} Возраст: {age}");
//}
//PrintPerson("Rinat", 24);
//PrintPerson("Siuzy", 26);
//PrintPerson("Choro", 121);

//void Sum(params int[] nums)
//{
//    int result = 0;
//    foreach(int num in nums)
//    {
//        result += num;
//    }
//    Console.WriteLine(result);
//}
//Sum(1, 2, 3, 7);



//Person tom = new Person();
//string personName = tom.name;
//int personAge = tom.age;
//Console.WriteLine($"Имя:{personName} Возраст:{personAge}");

//tom.name = "Tom";
//tom.age = 24;

//tom.Print();


//class Person
//{
//    public string name = "Непонятный хер с горы";
//    public int age;

//    public  void Print()
//    {
//        Console.WriteLine($"Имя:{name} Возраст:{age}");
//    }
//}

//Chel rinat = new Chel();
//rinat.name = "Rinat";
//rinat.age = 24;
//rinat.Print();

//class Chel
//{
//    public const string type = "Humanoid";
//    public string name = "Undefined";
//    public int age;
//    public void Print() => Console.WriteLine($"{type}: {name} - {age}");
//}

//Person tom = new Person();
//tom.name = "Tom";
//tom.Print();
//int n = 65;
//Console.WriteLine(n/10);

//double x = 0;
//x = -1 + 4 * 6;
//Console.WriteLine(x);
//x += (35 + 5) % 7;
//Console.WriteLine(x);
//x += 14 + 4 * 6 / 11;
//Console.WriteLine(x);
//x /= 2 + 15 / 6.0 * 1 - 7 % 2;
//Console.WriteLine($"{x:0.00}") ;

//Console.WriteLine("Введите имя:");
//string? name = Console.ReadLine();
//Console.WriteLine("Введите год рождения:");
//int year = Convert.ToInt32(Console.ReadLine());
//int age = Convert.ToInt32(DateTime.Now.Year) - year;
//string let_god;
//if (age % 10 < 5 && age % 10 > 0) let_god = "года";
//else let_god = "лет";
//Console.WriteLine($"Привет {name}, вам {age} {let_god}");

//while (true)
//{
//    Console.WriteLine("Введите трехзначное число");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num > 999 || num < 100) Console.WriteLine("Число должно быть трехзначным");
//    else
//    {
//        string str = num.ToString();
//        Console.WriteLine($"{str[0]}, {str[1]}, {str[2]}");
//        break;
//    }

//}

//Console.WriteLine("Введите номер месяца:");
//int month = Convert.ToInt32(Console.ReadLine());
//switch (month)
//{
//    case 1:
//        Console.WriteLine("Январь");
//        break;
//    case 2:
//        Console.WriteLine("Февраль");
//        break;
//    case 3:
//        Console.WriteLine("Март");
//        break;
//    case 4:
//        Console.WriteLine("Апрель");
//        break;
//    case 5:
//        Console.WriteLine("Май");
//        break;
//    case 6:
//        Console.WriteLine("Июнь");
//        break;
//    case 7:
//        Console.WriteLine("Июль");
//        break;
//    case 8:
//        Console.WriteLine("Август");
//        break;
//    case 9:
//        Console.WriteLine("Сентябрь");
//        break;
//    case 10:
//        Console.WriteLine("Октябрь");
//        break;
//    case 11:
//        Console.WriteLine("Ноябрь");
//        break;
//    case 12:
//        Console.WriteLine("Декабрь");
//        break;
//    default:
//        Console.WriteLine("Число должно быть от 1 до 12");
//        break;
//}

////Задача А. Сумма, произведение и среднее арифметическое
//Console.WriteLine("Введите число а:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите число b:");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите число с:");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
//Console.WriteLine($"{a} * {b} * {c} = {a * b * c}");
//double result = (a + b + c) / 3;
//if (result % 1 == 0) Console.WriteLine($"({a} + {b} + {c})/3 = {result}");
//else Console.WriteLine($"({a} + {b} + {c})/3 = {result:0.00}");

//Console.WriteLine("Введите числа:");
//Console.WriteLine("a:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("b:");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("c:");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("d:");
//double d = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("e:");
//double e = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("f:");
//double f = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("k:");
//double k = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("p:");
//double p = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("g:");
//double g = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{(((a+b)*c+d*e/f)/(k+p*b/a+g)*4/5):0.0000}");

//int[] nums = { 2, 45, 6, 12, 15, 33, 40, 3, 94, 7 };
//int temp;
//for (int i = 0; i < nums.Length-1; i++)
//{
//for (int j = i+1; j<nums.Length; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//           temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//        }
//}
//Console.WriteLine(nums[^1]);

//Console.WriteLine("Вас приветствует счетчик букв в слове\nВведите свое слово:");
//string? word = Console.ReadLine();
//string? letter;
//while (true)
//{
//    Console.WriteLine("Введите букву");
//    letter = Console.ReadLine();
//    if (letter != null && word!= null && letter.Length == 1)
//        break;
//    else Console.WriteLine("Вы должны ввести 1 букву");
//}
//char l = Convert.ToChar(letter);
//int count = 0;
//for(int i=0; i < word.Length; i++)
//{
//    if (l == word[i])
//    {
//        count++;
//    }
//}

//Console.WriteLine($"Количество букв {letter} в слове {word} составляет {count}");


//Console.WriteLine("Является ли ABC треугольником? Давайте узнаем\nВведите угол А:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите угол B:");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите угол С:");
//double c = Convert.ToDouble(Console.ReadLine());
//if (a == 0 || b == 0 || c == 0)
//{
//    Console.WriteLine("Угол треугольника не может быть 0");
//}
//else if ((a + b + c) == 180)
//{
//    Console.WriteLine("ABC является треугольником");
//}
//else Console.WriteLine("ABC не является треугольником");

//Console.WriteLine("Округление числа. Введите параметры округления");
//double num = 1.111;
//Console.WriteLine("сколько знаков после запятой оставить?:");
//int dgts = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Выберите каким способом будете округлять и введите:\n" +
//    "1 - Округление до четного\n" +
//    "2 - Округление \"дальше от нуля\"\n" +
//    "3 - Округление до ПОЛА\n" +
//    "4 - Округление до ПОТОЛКА\n" +
//    "5 - Округление к нулю");
//int op = Convert.ToInt32(Console.ReadLine());
//while (num != 0)
//{
//    Console.WriteLine("Введите число с плавающей точкой. А чтобы выйти из программы введите 0");
//    num = Convert.ToDouble(Console.ReadLine());
//    switch (op)
//    {
//        case 1:
//            Console.WriteLine(Math.Round(num, dgts, MidpointRounding.ToEven));
//            break;
//        case 2:
//            Console.WriteLine(Math.Round(num, dgts, MidpointRounding.AwayFromZero));
//            break;
//        case 3:
//            Console.WriteLine(Math.Floor(num));
//            break;
//        case 4:
//            Console.WriteLine(Math.Ceiling(num));
//            break;
//        case 5:
//            Console.WriteLine(Math.Truncate(num));
//            break;
//        default:
//            Console.WriteLine("Операций всего 5");
//            break;
//    }
//}

// Задача. Четные нечетные числа до N
Console.WriteLine("Программа выводит четные или нечетные числа до вашего числа\n" +
    "Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Натуральное число - это целое положительное число");
}
else
{
    Console.WriteLine("Введите 1 если хотите нечетные числа, и 2 если четные");
    int oe = Convert.ToInt32(Console.ReadLine());
    switch (oe)
    {
        case 1:
            if (n % 2 == 0)
            {
                for (int i = 1; i < n - 2; i += 2)
                {
                    Console.Write($"{i}, ");
                }
                Console.Write(n - 1);
            }
            else
            {
                if (n == 1) Console.Write(n);
                else
                {
                    for (int i = 1; i < n - 2; i += 2)
                    {
                        Console.Write($"{i}, ");
                    }
                    Console.Write(n - 2);
                }
            }
            break;
        case 2:
            if (n % 2 == 0)
            {
                for (int i = 2; i < n - 2; i += 2)
                {
                    Console.Write($"{i}, ");
                }
                Console.Write(n - 2);
            }
            else
            {
                if (n == 1) Console.Write(n);
                else
                {
                    for (int i = 2; i < n - 2; i += 2)
                    {
                        Console.Write($"{i}, ");
                    }
                    Console.Write(n - 1);
                }
            }
            break;
        default:
            Console.WriteLine("Принимаются значения 1 или 2");
            break;
    }
    Console.WriteLine("\nПоказать простые числа? (0-нет, 1-да)");
    int pn = Convert.ToInt32(Console.ReadLine());
    switch (pn)
    {
        case 0:
            Console.WriteLine("А я все равно покажу");
            goto case 1;
        case 1:
            for (int i = 2; i <= n; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 & i % 1 == 0)
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    Console.Write("{0} ", i);
                }
            }
            break;
        default:
            break;
    }
    Console.WriteLine("\nЯ вам еще посчитал сумму четных и нечетных чисел:");
    int sum_odd = 0;
    int sum_even = 0;
    for (int i = 1; i <= n; i += 2)
    {
        sum_odd += i;
    }
    for (int i = 2; i <= n; i += 2)
    {
        sum_even += i;
    }
    Console.WriteLine("Сумма нечетных чисел - " + sum_odd);
    Console.WriteLine("Сумма четных чисел - " + sum_even);
}