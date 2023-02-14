// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Recursion(int numberN)
{
    if(numberN == 0)return 1;
    Console.Write(numberN);
    if(numberN > 1)Console.Write(",");
    else Console.Write("''");
    Recursion(numberN - 1);
    return numberN-1;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int numberN = GetNum("Введите значение числа N: ");
Console.Write($"N = {numberN} -> ''");
Recursion(numberN);