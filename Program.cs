// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 =" +y1);
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2 =" +x2);
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 =" +y2);
double line = (double)Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) * 1.0));
Console.WriteLine("Length of a Line " + line);
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a1 =" + a1);
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b1 =" + b1);
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a2 =" + a2);
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b2 =" + b2);
double line2 = (double)Math.Sqrt(Math.Pow(a2 - a1, 2) + (Math.Pow(b2 - b1, 2) * 1.0));
Console.WriteLine("Length of a Line2 " + line2);
if (line == line2)
{
    Console.WriteLine("Lines are equal");
}
else
{
    Console.WriteLine("Lines are not equal");
}
