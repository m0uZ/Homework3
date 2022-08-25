Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = number;
double sum = Math.Abs(Math.Pow(number, 2));

while (count != 0)
{
    Console.Write("Введите число: ");
    number = int.Parse(Console.ReadLine());
    count += number;
    sum += Math.Abs(Math.Pow(number, 2));
    if (count == 0)
    break;
}
Console.WriteLine(sum);