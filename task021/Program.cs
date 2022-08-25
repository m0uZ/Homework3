Console.Write("введите координату х1 ");
int x1 = int.Parse (Console.ReadLine());
Console.Write("введите координату y1 ");
int y1 = int.Parse (Console.ReadLine());
Console.Write("введите координату z1 ");
int z1 = int.Parse (Console.ReadLine());
Console.Write("введите координату x2 ");
int x2 = int.Parse (Console.ReadLine());
Console.Write("введите координату y2 ");
int y2 = int.Parse (Console.ReadLine());
Console.Write("введите координату z2 ");
int z2 = int.Parse (Console.ReadLine());           

double S = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

Console.WriteLine(S);

try
{
Console.WriteLine(S);
}
catch
{
Console.WriteLine("Надо было вводить именно целые числа");  
}
