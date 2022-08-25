Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a;
double c = Math.Abs(Math.Pow(a, 2));

while (b != 0)
{
    Console.Write("Введите число: ");
    a = int.Parse(Console.ReadLine());
    b += a;
    c = c + Math.Abs(Math.Pow(a, 2));
    if (b == 0)
    break;
}
Console.WriteLine(c);