﻿using System;

class Program
{
    static void Main()
    {
        int rows = 5; // Кол строк 
        int cols = 5; // Кол столбцов 
        int[,] array = new int[rows, cols]; // Двумерный массив размером 5строкX5столбцов
        Random rand = new Random(); // Генератор случайных чисел

        // Генерация случайного двумерного массива
        for (int i = 0; i < rows; i++) // Цикл по строкам 
        {
            for (int j = 0; j < cols; j++) // Цикл по столбцам 
            {
                array[i, j] = rand.Next(1, 100); // Заполняем массив случайными числами от 1 до 99
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array); // Выводим исходный двумерный массив на экран

        // Сортировка строк: нечетные по возрастанию, четные по убыванию
        for (int i = 0; i < rows; i++) // Цикл по каждой строке массива
        {
            int[] tempArray = new int[cols]; // Создаем временный одномерный массив для текущей строки

            // Копируем строку из двумерного массива в одномерный массив
            for (int j = 0; j < cols; j++)
            {
                tempArray[j] = array[i, j]; // Копируем элементы текущей строки в одномерный массив
            }

            // Если строка четная (индекс строки четный), сортируем по убыванию
            if (i % 2 == 0) // Проверка: индекс строки четный?
            {
                Array.Sort(tempArray); // Сортируем строку по возрастанию
                Array.Reverse(tempArray); // Переворачиваем массив для сортировки по убыванию
            }
            // Если строка нечетная (индекс строки нечетный), сортируем по возрастанию
            else
            {
                Array.Sort(tempArray); // Сортировка по возрастанию для нечетных строк
            }

            // Копируем отсортированную строку обратно в двумерный массив
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = tempArray[j]; // Копируем отсортированные элементы обратно в двумерный массив
            }
        }

        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(array); // Выводим отсортированный массив на экран

        // Ввод значения k-го столбца
        Console.Write("\nВведите номер столбца (k): "); // Запрашиваем у пользователя номер столбца
        int k = int.Parse(Console.ReadLine()); // Читаем введенное значение и преобразуем его в целое число

        // Проверка, что k находится в пределах массива
        if (k >= 0 && k < cols) // Убедимся, что номер столбца находится в допустимых пределах
        {
            Console.WriteLine($"\nЗначения {k}-го столбца:"); // Выводим сообщение, какой столбец будет показан
            for (int i = 0; i < rows; i++) // Цикл по строкам массива
            {
                Console.WriteLine(array[i, k]); // Выводим значение текущей строки k-го столбца
            }
        }
        else // Если введенное значение k вне диапазона массива
        {
            Console.WriteLine("Ошибка: Номер столбца выходит за пределы массива."); // Выводим сообщение об ошибке
        }
    }

    // Метод для вывода двумерного массива на экран
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0); // Получаем количество строк в массиве
        int cols = array.GetLength(1); // Получаем количество столбцов в массиве

        // Цикл для вывода элементов массива
        for (int i = 0; i < rows; i++) // Цикл по строкам
        {
            for (int j = 0; j < cols; j++) // Цикл по столбцам
            {
                Console.Write(array[i, j] + "\t"); // Выводим каждый элемент массива с табуляцией
            }
            Console.WriteLine(); // Переход на новую строку после каждой строки массива
        }
    }
}