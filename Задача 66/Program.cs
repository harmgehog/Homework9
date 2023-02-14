// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Recursion(int M, int N)
{
    if (M != N) return (M + Recursion(M + 1, N));
    else return 0;
    // Console.WriteLine(result);
    // return result;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int numberM = GetNum("Введите значение числа M: ");
int numberN = GetNum("Введите значение числа N: ");
int result = Recursion(numberM, numberN) + numberN;
Console.WriteLine(result);
