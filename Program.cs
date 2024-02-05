// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// string NaturalNumbers(int start, int stop)
// {
//     if (start == stop) return Convert.ToString(start);
//     return start + " " + NaturalNumbers(start + 1, stop);
// }

// Console.Write("Введите число: ");
// int M = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine()!);
// if (N == M) Console.Write("Не отходите от условия задачи.");
// else Console.Write(NaturalNumbers(M, N));



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int AkkermanFuction(int m, int n)
// {
//   if (m == 0)
//     return n + 1;
//   else
//     if ((m != 0) && (n == 0))
//       return AkkermanFuction(m - 1, 1);
//     else
//       return AkkermanFuction(m - 1, AkkermanFuction(m, n - 1));
// }

// Console.Write("Введите число M = ");
// int M = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Введите число N = ");
// int N = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(AkkermanFuction(M, N));



// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System.ComponentModel;

int[] Random_mas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1,11);
    }
    return col;
}

void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item}  ");
    }
    Console.WriteLine();
}

void Reverse(int[] array, int first = 0)
{
    if(first != array.Length) {
        Reverse(array, first + 1);
        Console.Write($"{array[first]}  ");
    }
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];
int[] new_mas = Random_mas(mas);
Print_mas(new_mas);
Reverse(new_mas);