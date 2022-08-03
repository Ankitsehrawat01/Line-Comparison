// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x1 =" +x1);
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 =" +y1);
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2 =" +x2);
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 =" +y2);
double line = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) * 1.0));
Console.WriteLine("Length of a Line " + line);