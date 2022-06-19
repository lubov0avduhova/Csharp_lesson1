// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse (Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNum = int.Parse (Console.ReadLine());

int resultMax = 0;

if (firstNum > resultMax) resultMax = firstNum;
if (secondNum > resultMax) resultMax = secondNum;
if (thirdNum > resultMax) resultMax = thirdNum;

Console.WriteLine($"Наибольшее число: {resultMax}");