// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Recursion(int M, int N, int result)
{
    if (M == N) return M;
    result = M + Recursion(M + 1, N, result);
    Console.WriteLine(result);
    return result;
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int numberM = GetNum("Введите значение числа M: ");
int numberN = GetNum("Введите значение числа N: ");
int result = 0;
Recursion(numberM, numberN, result);
