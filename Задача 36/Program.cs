﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами.  
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int [5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random(). Next(1, 10);
    Console.Write(array[i] + " , ");
}

double count = 0;
for (int i = 0; i < array.Length; i++)
{
if ( array[i] % 2 != 0)
{
    count += array[i];
}
}
Console.WriteLine($"Сумма нечетных чисел чисел = {count}");