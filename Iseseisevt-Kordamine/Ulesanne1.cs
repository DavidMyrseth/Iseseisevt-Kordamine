class Ulesanne1
{
    public static void Solve()
    {
        // Двумерный массив, который будет заполнен случайными числами.
        int[,] arr2d = new int[4, 4];
        Random rnd = new Random(); // Генератор случайных чисел

        // Массив случайными числами
        for (int i = 0; i < arr2d.GetLength(0); i++) // Просмотр массива
        {
            for (int j = 0; j < arr2d.GetLength(1); j++) // Столбцы
            {
                arr2d[i, j] = rnd.Next(1, 100); // Генерируем случайное число
            }
        }

        Console.WriteLine("Algeni massiiv:"); 
        Print2DArray(arr2d); // Вызывает метод 

        // Сортирует четные строки по возрастанию, нечетные по убыванию
        for (int i = 0; i < arr2d.GetLength(0); i++) // Просмотр массива
        {
            int[] row = new int[arr2d.GetLength(1)]; // Массив
            for (int j = 0; j < arr2d.GetLength(1); j++) // Просмотр столбцов для копирования строки
            {
                row[j] = arr2d[i, j]; // Копирует значения из двумерного массива в одномерный
            }

            if (i % 2 == 0) // Индекс строки четный 
            {
                Array.Sort(row); // По возрастанию
            }
            else // Индекс строки нечетный 
            {
                Array.Sort(row); // Сортирует по возрастанию
                Array.Reverse(row); // Затем разворачиваем строку для сортировки по убыванию
            }

            for (int j = 0; j < arr2d.GetLength(1); j++) // Столбцы
            {
                arr2d[i, j] = row[j]; // Возвращаем отсортированные значения обратно в двумерный массив
            }
        }

        Console.WriteLine("\nParast sorteerimistg:"); 
        Print2DArray(arr2d); // Вывод отсортированного двумерного массива
    }

    // ВСП вывода двумерного массива
    private static void Print2DArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++) // Просмотр массива
        {
            for (int j = 0; j < arr.GetLength(1); j++) // Столбцы
            {
                Console.Write(arr[i, j] + "\t"); // Элемент массива с табуляцией
            }
            Console.WriteLine(); // Переход на новую строку после вывода всех элементов текущей строки
        }
    }
}