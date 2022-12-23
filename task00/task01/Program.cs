/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите натуральное число больше 1:");
int N = Convert.ToInt32(Console.ReadLine());

void NumberCounter (int N)
{
    if (N == 0) return;
    Console.WriteLine($"{N} ");
    NumberCounter (N - 1);
}

NumberCounter(N);