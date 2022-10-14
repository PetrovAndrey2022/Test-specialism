// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

using System;

internal class Program
{
    private static void Main(string[] args)
    {
         void FullArray(string[] array)// метод наполняет массив случайными числами
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива -");
                string? nnn = Convert.ToString(Console.ReadLine());
                array[i] = nnn;
            }
        }
        void PrintArray(string[] Col) // метод выводяций массив на печать
        {
            Console.Write($"Вами был введен массив строк из {Col.Length} элементов - ");
            for (int i = 0; i < Col.Length; i++)
            {
                if (i < Col.Length-1) Console.Write($" {Col[i]},");
                else Console.Write($" {Col[i]}.");
            }
            Console.WriteLine();
        }

        void SortArray(string[] array)// метод вычисляющий разницу между макс и мин элем массива
        { 
            string [] sortarray = new string [array.Length];
           int count =0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i].Length<=3) 
                {
                sortarray[i]=array[i];
                count = count+1;
                }
            }
            if (count!=0)
            {
                Console.WriteLine();
                Console.Write($"В веденном массиве {count} элемента удовлетворяют заданным требованиям:- ");
                for (int j=0; j<sortarray.Length; j++)
                {
                Console.Write($" {sortarray[j]}");
                }
            }
             else 
            {
                Console.WriteLine("В введенном массиве нет элементов удовлетворяющих заданным требованиям.");   
            }
        Console.WriteLine();
        }
        try
        {
            Console.Clear();
            Console.WriteLine("Данная программа из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа");
            Console.Write("Введите количество элементов в массиве и нажмите Enter.- ");
            int n = Convert.ToInt32(Console.ReadLine());
            string [] array = new string[n];
            FullArray(array);
            Console.WriteLine();
            PrintArray(array);
            SortArray(array);
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}