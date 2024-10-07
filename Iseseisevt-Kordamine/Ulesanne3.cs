using System; 
using System.Collections.Generic; 

class Ulessane3 // Объявляем класс Ulessane3
{
    public static void Solve() // Статический метод Solve для решения задачи. После удаления человека 'C'
    {
        // Данные о зарплатах и людях
        int[] palgad = { 1200, 2500, 750, 395, 1200 }; // Массив зарплат
        string[] inimesed = { "A", "B", "C", "D", "E" }; // Массив имен людей

        // 1. Удаляем человека и его зарплату
        RemovePerson(ref palgad, ref inimesed, "C"); // Удаляем человека с именем "C"

        Console.WriteLine("After removing person 'C':"); // Выводим сообщение о том, что человек был удален
        PrintSalaries(palgad, inimesed); // Вызываем метод для вывода зарплат после удаления

        // 2. Находим наибольшую зарплату и кто ее получает
        FindHighestSalary(palgad, inimesed); // Вызываем метод для поиска наибольшей зарплаты

        // 3. Узнаем, кто получает одинаковую зарплату
        FindSameSalaries(palgad, inimesed); // Вызываем метод для поиска людей с одинаковой зарплатой
    }

    // Метод для удаления человека и его зарплаты
    private static void RemovePerson(ref int[] palgad, ref string[] inimesed, string name) // Метод принимает массивы зарплат и имен по ссылке и имя для удаления
    {
        int index = Array.IndexOf(inimesed, name); // Находим индекс человека с заданным именем
        if (index != -1) // Если человек найден
        {
            // Создаем новые массивы, в которые будем копировать данные
            int[] newPalgad = new int[palgad.Length - 1]; // Новый массив зарплат, на 1 элемент меньше
            string[] newInimesed = new string[inimesed.Length - 1]; // Новый массив имен, на 1 элемент меньше

            for (int i = 0, j = 0; i < palgad.Length; i++) // Проходим по массиву зарплат
            {
                if (i != index) // Если текущий индекс не равен индексу удаляемого человека
                {
                    newPalgad[j] = palgad[i]; // Копируем зарплату в новый массив
                    newInimesed[j] = inimesed[i]; // Копируем имя в новый массив
                    j++; // Увеличиваем индекс для нового массива
                }
            }

            palgad = newPalgad; // Перезаписываем оригинальный массив зарплат новым массивом
            inimesed = newInimesed; // Перезаписываем оригинальный массив имен новым массивом
        }
    }

    // Метод для нахождения наибольшей зарплаты. Наибольшая зарплата/получает
    private static void FindHighestSalary(int[] palgad, string[] inimesed) // Метод принимает массивы зарплат и имен
    {
        int maxSalary = palgad[0]; // Инициализируем переменную для максимальной зарплаты
        string person = inimesed[0]; // Инициализируем переменную для имени человека с максимальной зарплатой

        for (int i = 1; i < palgad.Length; i++) // Начинаем проходить массив зарплат с первого элемента
        {
            if (palgad[i] > maxSalary) // Если текущая зарплата больше максимальной
            {
                maxSalary = palgad[i]; // Обновляем максимальную зарплату
                person = inimesed[i]; // Обновляем имя человека с максимальной зарплатой
            }
        }

        Console.WriteLine($"Highest salary: {maxSalary}, receives: {person}"); // Выводим информацию о максимальной зарплате и человеке, который ее получает
    }

    // Метод для нахождения людей с одинаковой зарплатой
    private static void FindSameSalaries(int[] palgad, string[] inimesed) // Метод принимает массивы зарплат и имен
    {
        Dictionary<int, List<string>> salaryGroups = new Dictionary<int, List<string>>(); // Создаем словарь для группировки людей по зарплате

        // Группируем людей по зарплатам
        for (int i = 0; i < palgad.Length; i++) // Проходим по массиву зарплат
        {
            if (!salaryGroups.ContainsKey(palgad[i])) // Если зарплата еще не добавлена в словарь
            {
                salaryGroups[palgad[i]] = new List<string>(); // Создаем новый список для людей с данной зарплатой
            }
            salaryGroups[palgad[i]].Add(inimesed[i]); // Добавляем имя человека к соответствующей зарплате
        }

        // Выводим людей с одинаковой зарплатой. People with the same salary Люди с одинаковой зарплатой Зарплата 
        Console.WriteLine("People with the same salary:"); // Сообщение о начале вывода
        foreach (var group in salaryGroups) // Проходим по группам зарплат
        {
            if (group.Value.Count > 1) // Если в группе больше одного человека
            {
                Console.WriteLine($"Salary {group.Key}: {string.Join(", ", group.Value)}"); // Выводим зарплату и имена людей
            }
        }
    }

    // Метод для вывода зарплат и имен людей
    private static void PrintSalaries(int[] palgad, string[] inimesed) // Метод принимает массивы зарплат и имен
    {
        for (int i = 0; i < palgad.Length; i++) // Проходим по массиву зарплат
        {
            Console.WriteLine($"{inimesed[i]}: {palgad[i]}"); // Выводим имя и соответствующую зарплату
        }
    }
}
