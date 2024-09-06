using System;

class Program
{
    static void Main()
    {
        Random rand = new Random(); // Генератор случайных чисел // Juhuslike numbrite generaator

        int rows = 5; // Количество строк // Ridade arv
        int cols = 5; // Количество столбцов // Veergude arv
        int[,] array = new int[rows, cols]; // Создаём двумерный массив // Loome kahe mõõtmelise massiivi

        Console.WriteLine("Исходный массив:"); // Заполняем массив случайными числами от 1 до 100 // Algne massiiv:
        for (int i = 0; i < rows; i++) // Проходим по строкам // Läbime read
        {
            for (int j = 0; j < cols; j++) // Проходим по столбцам // Läbime veerud
            {
                array[i, j] = rand.Next(1, 101); // Заполняем элемент массива случайным числом от 1 до 100 // Täidame massiivi elemendi juhusliku arvuga vahemikus 1 kuni 100
                Console.Write(array[i, j] + "\t"); // Выводим элемент массива с табуляцией // Kuvame massiivi elemendi tabulaatoriga
            }
            Console.WriteLine(); // Переход на новую строку после вывода всех элементов строки // Uuele reale minemine pärast kõikide rea elementide kuvamist
        }

        // Сортировка строк  // Ridade sorteerimine
        for (int i = 0; i < rows; i++) // Проходим по каждой строке массива // Läbime iga massiivi rea
        {
            // Извлекаем строку в одномерный массив // Kopeeri rida ühemõõtmelisse massiivi
            int[] rowArray = new int[cols]; // Создаём временный одномерный массив для строки // Loome ajutise ühemõõtmelise massiivi reale
            for (int j = 0; j < cols; j++) // Копируем элементы строки в одномерный массив // Kopeerime rea elemendid ühemõõtmelisse massiivi
            {
                rowArray[j] = array[i, j]; // Копирование значений строки // Rea väärtuste kopeerimine
            }

            // Если строка нечетная, сортируем по возрастанию, если четная – по убыванию // Kui rida on paaritu, sorteerime kasvavalt, kui paaris – kahanevalt
            if (i % 2 == 0) // Проверка, если строка с чётным индексом (первая, третья и т.д.) // Kontrollime, kas rida on paaris (esimene, kolmas jne)
                Array.Sort(rowArray); // Сортировка одномерного массива по возрастанию // Ühemõõtmelise massiivi sorteerimine kasvavalt
            else
            {
                Array.Sort(rowArray); // Сначала сортировка по возрастанию // Esiteks sorteerimine kasvavalt
                Array.Reverse(rowArray); // Затем переворот массива для сортировки по убыванию // Seejärel massiivi pööramine kahaneva sorteerimise jaoks
            }

            // Записываем отсортированную строку обратно в двумерный массив // Kirjutame sorteeritud rea tagasi kahe mõõtmelisse massiivi
            for (int j = 0; j < cols; j++) // Проходим по элементам строки // Läbime rea elemendid
            {
                array[i, j] = rowArray[j]; // Записываем отсортированные элементы обратно в исходный массив // Kirjutame sorteeritud elemendid tagasi algsesse massiivi
            }
        }

        // Вывод отсортированного массива // Sorteeritud massiivi kuvamine
        Console.WriteLine("\nОтсортированный массив:");
        // Sorteeritud massiiv:
        for (int i = 0; i < rows; i++) // Проходим по строкам отсортированного массива // Läbime sorteeritud massiivi read
        {
            for (int j = 0; j < cols; j++) // Проходим по столбцам // Läbime veerud
            {
                Console.Write(array[i, j] + "\t"); // Выводим каждый элемент массива с табуляцией // Kuvame iga massiivi elemendi tabulaatoriga
            }
            Console.WriteLine(); // Переход на новую строку после каждой строки // Uuele reale minemine pärast iga rida
        }

        // Запрашиваем у пользователя номер столбца для вывода // Küsime kasutajalt veeru numbri sisestamist
        Console.Write("\nВведите номер столбца (от 0 до {0}): ", cols - 1); // Приглашение ввести номер столбца // Sisestage veeru number (0 kuni {0}):
        int k = int.Parse(Console.ReadLine()); // Читаем ввод пользователя и преобразуем его в число // Loeme kasutaja sisendi ja teisendame selle numbriks

        // Выводим k-й столбец // Kuvame k-ndat veergu
        Console.WriteLine("\nЗначения в {0}-м столбце:", k); // Сообщение о выводе столбца
        // Väärtused {0}. veerus:
        for (int i = 0; i < rows; i++) // Проходим по строкам, чтобы вывести значения в k-ом столбце // Läbime read, et kuvada väärtused k-ndas veerus
        {
            Console.WriteLine(array[i, k]); // Выводим элемент k-го столбца для каждой строки // Kuvame iga rea k-nda veeru elemendi
        }
    }
}