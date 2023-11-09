Console.WriteLine("Write 4 numbers: ");
int a, b, c, d;
double x, y, z, r;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
int.TryParse(Console.ReadLine(), out c);
int.TryParse(Console.ReadLine(), out d);

x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (a * a) / (b * b);
Console.WriteLine($"X = {x:F2}");

y = (5 * (a + b) * (c - d)) / (c / 2) + d * d * ((a * a) - (b * b) / (b - a));
Console.WriteLine($"Y = {y:F2}");

z = (((Math.Pow(x * x - 2 * x, 3)) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
Console.WriteLine($"Z = {z:F2}");

r = ((a / 2) + (3*b / 4) - (7.0 / 5)) / (3*c + 1) + (1 / (a - c));
Console.WriteLine($"R = {r:F2}");


