// Урок 7. Двумерные массивы

// Задача 47. Задайте двумерный массив размером m?n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] FillArray(int m, int n)
// {
//     double[,] array = new double [m,n];
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0; j<array.GetLength(1);j++)
//             array [i,j]=new Random().Next(-9,10)+Math.Round(new Random().NextDouble(), 1);
//     }
//     return array;
// }

// void PrintArray(double[,] arr)
// {
//     for(int i=0; i < arr.GetLength(0); i++)
//     {
//         for(int j=0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write($"{arr[i,j]} \t");
//             }
//             Console.WriteLine();
//     }
// }
// double[,] mas=FillArray(m,n);
// PrintArray(mas);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] mas = { { 1, 4, 7, 2}, { 5, 9, 2, 3}, {8, 4, 2, 4} }; // задан массив

// void PrintArray(int[,] arr)
// {
//     for(int i=0; i < arr.GetLength(0); i++)
//     {
//         for(int j=0; j < arr.GetLength(1); j++)
//             {
//                 Console.Write($"{arr[i,j]} \t");
//             }
//             Console.WriteLine();
//     }
// }

// PrintArray(mas);
// Console.WriteLine("Введите значение элемента");
// int m = Convert.ToInt32(Console.ReadLine());

// void PosSearch(int[,] mas)
// {
//     int x = -1, y=-1;
//     for(int i=0; i < mas.GetLength(0);i++)
//     {
//         for(int j=0; j < mas.GetLength(1);j++)
//             {
//                 if (mas[i, j]==m) 
//                 {
//                     x=i;
//                     y=j;
//                     Console.WriteLine ($"Позиция в массиве элемента {mas[i, j]}  [{x}, {y}]");
//                 }    
//             } 
//     }
//     if (x == -1) Console.WriteLine("такого элемента нет"); 
// }
// PosSearch(mas);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] mas = { { 1, 4, 7, 2}, { 5, 9, 2, 3}, {8, 4, 2, 4} }; // задан массив

void PrintArray(int[,] arr)
{
    for(int i=0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i,j]} \t");
            }
            Console.WriteLine();
    }
}

PrintArray(mas);
Console.WriteLine("Среднее арифметическое каждого столбца:");

void MeanColumn(int[,] mas)
{
    for(int j=0; j < mas.GetLength(1);j++)
    {
        float x = 0, y=0;
        for(int i=0; i < mas.GetLength(0);i++)
            {
            x+=mas[i, j];
            y=x/mas.GetLength(0);
            if (i==2) Console.Write($"{y:#.##} \t");
            } 
    }
}
MeanColumn(mas);
