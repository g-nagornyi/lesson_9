// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите любое натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое натуральное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 < num2) return num1 + SumNaturalNumbers(num1 + 1, num2);
    else if (num1 > num2) return num1 + SumNaturalNumbers(num1 - 1, num2);
    else return num1;
}
int res = SumNaturalNumbers(number1, number2);
Console.WriteLine($"Сумма натуральных элементов от {number1} до {number2} равна: {res}");
