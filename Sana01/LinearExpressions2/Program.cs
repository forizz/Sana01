double a, b, x, m, n;
double z1, z2, y;
Console.WriteLine("Write number a: ");
double.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Write number b: ");
double.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Write number x: ");
double.TryParse(Console.ReadLine(), out x);
Console.WriteLine("Write number m: ");
double.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Write number n: ");
double.TryParse(Console.ReadLine(), out n);

z1 = ((m-1)*Math.Sqrt(m) - (n-1)*Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m, 3)*n) + n*m + m*m - m);
Console.WriteLine($"z1 = {z1:F6}");

z2 = (Math.Sqrt(m) - Math.Sqrt(n))/m;
Console.WriteLine($"z2 = {z2:F6}");

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"y = {y:F2}");
