// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse (Console.ReadLine());

int resultMax = 0;
int resultMin = 0;

if (firstNum > secondNum)
{
    resultMax = firstNum;
    resultMin = secondNum;
    Console.WriteLine($"Большее число: {resultMax}");
    Console.WriteLine($"Меньшее число: {resultMin}");
} else if (firstNum < secondNum)
{
    resultMax = secondNum;
    resultMin = firstNum;
    Console.WriteLine($"Большее число: {resultMax}");
    Console.WriteLine($"Меньшее число: {resultMin}");
} else
{
    Console.WriteLine("Числа одинаковые");
}