// S2.1. Compose a program:
// a) calculating the value of the function y=7x^2+3x+6 for any value of x;
Console.Write("S2.1.a. Enter a number X: ");
double x = Convert.ToDouble(Console.ReadLine());
double y = 7*Math.Pow(x,2)+3*x+6;
Console.WriteLine($"The function y=7x^2+3x+6 is equal to {y}");
// b) calculating the value of the function x=12a^2+7a+12 for any value of a.
Console.Write("S2.1.b. Enter a number A: ");
double a = Convert.ToDouble(Console.ReadLine());
x = 12 * Math.Pow(a, 2) + 7 * a + 12;
Console.WriteLine($"The function x=12a^2+7a+12 is equal to {x}");

// S2.2. Given the side of a square. Find its perimeter
int side2 = 4;   // for example
Console.WriteLine($"S2.3. The side of a square is {side2} so its perimeter equals to {side2*4}");

// S2.3. Given the radius of a circle. Find its diameter.
int radius3 = 5;  // for example
Console.WriteLine($"S2.3. Radius = {radius3} => Diameter = {radius3*2}");

// S2.4. Assuming that the Earth is an ideal sphere with a radius R=6350 km,
// determine the distance to the horizon line from point B with a given height
// h=AB above the Earth.
double OA, OG = OA = 6350;
Console.Write("S2.4. Enter the height AB (in km): ");
double AB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The BG = {Math.Round(Math.Sqrt(Math.Pow((OA+AB),2)- Math.Pow(OG, 2)),2)} km");

// S2.5. Given the length of an edge of a cube.
// Find the volume of a cube and its lateral surface area.
Console.Write("S2.5. The length of an edge of a cube is (cm) ");
double length5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"So the volume is {Math.Pow(length5,3)} cm^3 and its lateral surface area is {length5*length5*6} cm^2");

// S2.6. Given the radius of a circle. Find the circumference and area of ​​a circle.
Console.Write("S2.6. The radius of a circle is (cm) ");
double radius6 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The circumference of a circle equals to {Math.Round(Math.PI*radius6,2)} cm and area is {Math.Round(Math.PI*radius6 * radius6, 2)} cm^2");

// S2.7. You are given two integers. Find: a) their arithmetic mean; b) their geometric mean.
Console.Write("S2.7. Enter two integer numbers to find their: a) their arithmetic mean; b) their geometric mean"+
                    "\nFirst number: ");
int a7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
int b7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"a) {(a7+b7)/2}; b) {Math.Round(Math.Sqrt(a7*b7), 2)}");

// S2.8. The volume and weight of the body are known.
// Determine the density of the material of this body.
double v8 = 0.056; // 56 cubic decimeters
double w8 = 60;  // 60 kg
Console.WriteLine($"S2.8. Average density of body weighing {w8}kg and having a volume of {v8*1000} dm^3 is {Math.Round(w8/v8,2)} kg per m^3 ");

// S2.9. The number of inhabitants in Kyrgyzstan is 6'694'000 and the area of ​​its territory is 199 900 km^2.
// Determine the population density in this state.
double i9 = 6_694_000;
double a9 = 199_900;
Console.WriteLine($"S2.9. The population density of Kyrgyz Republic is {Math.Round(i9/a9,2)} per km^2");

// S2.10. Write a program for solving the linear equation ax+b=0  ( a ≠ 0).
Console.Write("S2.10. Given a linear equation ax+b=0 (a ≠ 0). Find the x \n a = ");
double a10 = Convert.ToDouble(Console.ReadLine());
if (a10 == 0)
{
    Console.Write("a cannot be 0. Please enter a number again \n a = ");
    a10 = Convert.ToDouble(Console.ReadLine());
}
Console.Write("b = ");
double b10 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"x = -{b10}/{a10} = {-b10/a10}");

// S2.11. Given the legs of a right triangle - AB = 3, BC = 4. Find its hypotenuse AC
double AB11 = 3;
double BC11 = 4;
double AC11 = Math.Round(Math.Sqrt(Math.Pow(AB11, 2) + Math.Pow(BC11,2)), 2);
Console.WriteLine($"S2.11. AC = {AC11}");

// S2.12. Find the area of ​​the ring given the given outer and inner radii.
Console.Write("S2.12. Outer radius is (cm) ");
double outer12 = Convert.ToDouble(Console.ReadLine());
Console.Write("Inner radius is (cm) ");
double inner12 = Convert.ToDouble(Console.ReadLine());
double ring12 = Math.Round((Math.PI * (outer12 * outer12 - inner12*inner12)), 2);
Console.WriteLine($"The area of ring is equal to {ring12} cm^2");

// S2.13. Given the legs of a right triangle. Find its perimeter
Console.Write("S2.13. AB and BC are legs of a right triangle, find its perimeter. Enter AB = ");
double AB13 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter BC = ");
double BC13 = Convert.ToDouble(Console.ReadLine());
double AC13 = Math.Round(Math.Sqrt(AB13*AB13+BC13*BC13),2); // hypotenuse
double perimeter13 = AB13 + BC13 + AC13;
Console.WriteLine($"Perimeter of ABC triangle is {perimeter13}");

// S2.13A. Two numbers are given. Find the arithmetic mean and geometric mean of their modules.
Console.Write("S2.13A. Enter two numbers to find the arithmetic and geometric means of their modules. Enter first number ");
double num13a1= Math.Abs(Convert.ToDouble(Console.ReadLine()));
Console.Write("The second number ");
double num13a2 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
double am13a = (num13a1 + num13a2) / 2;
double gm13a = Math.Round(Math.Sqrt(num13a1 * num13a2), 2);
Console.WriteLine($"Arithmetic mean = {am13a} and geomtric mean = {gm13a}");

// S2.14. Given the bases and height of an isosceles trapezoid. Find its perimeter.
Console.Write("S2.14. Find the perimeter of isosceles trapezoid. Upper base is equal to (cm) ");
double ub14 = Convert.ToDouble(Console.ReadLine());
Console.Write("Lower base (cm) = ");
double lb14 = Convert.ToDouble(Console.ReadLine());
Console.Write("And the height (cm) = ");
double h14 = Convert.ToDouble(Console.ReadLine());
double side14 = Math.Round(Math.Sqrt(h14*h14+Math.Pow(Math.Abs(ub14-lb14)/2,2)), 2);
double p14 = ub14+lb14+side14*2;
Console.WriteLine($"Perimeter is equal to {p14} cm");

// S2.14A. Given the sides of a rectangle. Find its perimeter and the length of the diagonal.
Console.Write("S2.14A Find a perimeter of a rectangle and the length of the diagonal. Enter the side a=");
double a14a = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Side b = ");
double b14a = Convert.ToDouble(Console.ReadLine());
double p14a = (a14a + b14a) * 2; // perimeter
double d14a = Math.Round(Math.Sqrt(a14a * a14a + b14a * b14a),2); // diagonal
Console.WriteLine($"Perimeter: {p14a}, diagonal: {d14a}");

//






//Delay
Console.Write("Enter any key to close the window...");
Console.ReadLine();