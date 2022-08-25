Console.Write("Введе число: ");
int number = Int32.Parse(Console.ReadLine());
int number1 = number;
int result = 0;
        
while (number1 > 0) 
{
    result *= 10;
    result += number1 % 10;
    number1 /= 10;
}
if (number == result)
{
    Console.WriteLine($"Число {number} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом.");
}
