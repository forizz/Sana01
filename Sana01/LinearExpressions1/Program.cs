Console.WriteLine("Write 4 numbers: ");
int a, b, c, d, x, y, z, r;
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
int.TryParse(Console.ReadLine(), out c);
int.TryParse(Console.ReadLine(), out d);

x = (a + 2 * b - c + d) / c * d + (a + b) / (c - d) - (a * a) / (b * b);
Console.WriteLine("X = {0}", x);

y = (5 * (a + b) * (c - d)) / (c / 2) + d * d * ((a * a) - (b * b) / (b - a));
Console.WriteLine("Y = {0}", y);
