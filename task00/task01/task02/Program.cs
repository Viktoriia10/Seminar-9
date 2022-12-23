/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите число M:");
int NumberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N:");
int NumberN = Convert.ToInt32(Console.ReadLine());

void NumberSum (int NumberM, int NumberN, int sum)
{
    if (NumberM > NumberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N:{sum}"); 
        return;
    }
    sum = sum + (NumberM++);
    NumberSum(NumberM, NumberN, sum);
}

NumberSum(NumberM, NumberN, 0);