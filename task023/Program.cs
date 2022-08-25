Console.Write("Введите положительное число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int stepen = 3;
string res = string.Empty;  // Пустая строка
while (i <= N)
    {
        res += Math.Pow(i, stepen) + ", ";
        i++;
                 
    }
Console.WriteLine(res);
