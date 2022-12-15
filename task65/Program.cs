Console.WriteLine("Введите любое натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);
void NaturalNumbers(int mc, int nc)
{
    if (mc == nc) Console.Write($"{nc} "); 
    if (mc > nc)
    {
        Console.Write($"{mc} ");
        NaturalNumbers(mc - 1, nc);

    }
    else if (mc < nc)
    {
        Console.Write($"{mc} ");
        NaturalNumbers(mc + 1, nc);
    }
}
