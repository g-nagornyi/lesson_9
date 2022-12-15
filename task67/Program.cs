Console.WriteLine("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumNumbers(num/10);
}
int res = SumNumbers(number);
Console.WriteLine(res);

