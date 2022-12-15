Console.WriteLine("Введите любое натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int QuaterNumber(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * QuaterNumber(numA, numB - 1);
}
int res = QuaterNumber(numberA, numberB);
Console.WriteLine(res);
