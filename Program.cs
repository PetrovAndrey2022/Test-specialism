// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

using System;

internal class Program
{
    private static void Main(string[] args)
    {
         void FullArray(string[] array)// метод наполняет массив данными введенными пользователем
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i+1} элемент массива -");
                string? value = Convert.ToString(Console.ReadLine());
                array[i] = value;
            }
        }
        void PrintArray(string[] Col) // метод выводяций введенный массив на печать
        {
            Console.Write($"Вами был введен массив строк из {Col.Length} элементов - ");
            for (int i = 0; i < Col.Length; i++)
            {
                if (i < Col.Length-1) Console.Write($" {Col[i]},");
                else Console.Write($" {Col[i]}.");
            }
            Console.WriteLine();
        }

        void SortArray(string[] array)// метод вычисляющий элементы массива с кол-вом символом <=3 и выводит их на печать
        { 
            string [] sortarray = new string [array.Length];
           int count =0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i].Length>=1 && array[i].Length<=3) 
                {
                    sortarray[count]=array[i];
                    count++;
                }
            }
            if (count!=0)
            {
                Console.WriteLine();
                Console.Write($"В веденном массиве {count} элемента удовлетворяют заданным требованиям:- ");
                for (int j=0; j<sortarray.Length; j++)
                {
                    if (sortarray[j].Length!=0)
                    {
                        if (j<count-1)  Console.Write($" {sortarray[j]}, ");
                         else Console.WriteLine($" {sortarray[j]}.");
                    }
                }
                 Console.WriteLine();
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
            Console.WriteLine("Данная программа из введенного массива строк формирует массив из строк, длина которых меньше либо равна 3 символа");
            Console.Write("Введите количество элементов в массиве и нажмите Enter.- ");
            int n = Convert.ToInt32(Console.ReadLine());
            string [] array = new string[n];
            FullArray(array);
            Console.WriteLine();
            PrintArray(array);
            SortArray(array);
            Console.WriteLine();
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