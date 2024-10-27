class Ulessane3 
{
    public static void Solve() 
    {
        // Массивы
        int[] palgad = { 1200, 2500, 750, 395, 1200 };
        string[] inimesed = { "A", "B", "C", "D", "E" }; 

        // 1. Удаляем человека и его зарплату
        RemovePerson(ref palgad, ref inimesed, "C");

        Console.WriteLine("Parast isiku eemaldamist 'C':"); 
        PrintSalaries(palgad, inimesed); 

        // 2. Находим наибольшую зарплату и кто ее получает
        FindHighestSalary(palgad, inimesed);

        // 3. Узнаем, кто получает одинаковую зарплату
        FindSameSalaries(palgad, inimesed); 
    }

    // Метод для удаления человека и его зарплаты
    private static void RemovePerson(ref int[] palgad, ref string[] inimesed, string name) // Метод принимает массивы зарплат и имя для удаления
    {
        int index = Array.IndexOf(inimesed, name); // Находим индекс человека именем
        if (index != -1) // Если человек найден
        {
            // Создает новые массивы, в которые будем копировать данные
            int[] newPalgad = new int[palgad.Length - 1]; // Новый массив зарплат, на 1 элемент меньше
            string[] newInimesed = new string[inimesed.Length - 1]; // Новый массив имен, на 1 элемент меньше

            for (int i = 0, j = 0; i < palgad.Length; i++) 
            {
                if (i != index) // Если текущий индекс не равен индексу удаляемого человека
                {
                    newPalgad[j] = palgad[i]; // Копируем зарплату в новый массив
                    newInimesed[j] = inimesed[i]; // Копируем имя в новый массив
                    j++; // Увеличиваем индекс для нового массива
                }
            }

            palgad = newPalgad; 
            inimesed = newInimesed; 
        }
    }

    // Наибольшая зарплата/получает
    private static void FindHighestSalary(int[] palgad, string[] inimesed) 
    {
        int maxSalary = palgad[0]; // Инициализируем макс зарплаты
        string person = inimesed[0]; // Инициализируем человека с максимальной зарплатой

        for (int i = 1; i < palgad.Length; i++) // Начинаем проходить массив зарплат с первого элемента
        {
            if (palgad[i] > maxSalary) // Если текущая зарплата больше максимальной
            {
                maxSalary = palgad[i]; 
                person = inimesed[i];
            }
        }

        Console.WriteLine($"Korgeim palk: {maxSalary}, saab: {person}");
    }

    // Людис одинаковой зарплатой
    private static void FindSameSalaries(int[] palgad, string[] inimesed) 
    {
        Dictionary<int, List<string>> salaryGroups = new Dictionary<int, List<string>>(); // Создаем словарь для группировки людей по зарплате

        // Группируем людей по зарплатам
        for (int i = 0; i < palgad.Length; i++) // Просматриваем зарплаты
        {
            if (!salaryGroups.ContainsKey(palgad[i])) // Если зарплата еще не добавлена в словарь
            {
                salaryGroups[palgad[i]] = new List<string>(); // Создаем новый список для людей с данной зарплатой
            }
            salaryGroups[palgad[i]].Add(inimesed[i]); // Добавляем имя человека к соответствующей зарплате
        }

        // Выводим людей с одинаковой зарплатой.
        Console.WriteLine("Inimesed, kellel on sama palk:"); 
        foreach (var group in salaryGroups) // Просматриваем зарплаты
        {
            if (group.Value.Count > 1) // Если в группе больше одного человека
            {
                Console.WriteLine($"Palk {group.Key}: {string.Join(", ", group.Value)}");
            }
        }
    }


    private static void PrintSalaries(int[] palgad, string[] inimesed) 
    {
        for (int i = 0; i < palgad.Length; i++) // Просматриваем зарплаты
        {
            Console.WriteLine($"{inimesed[i]}: {palgad[i]}");
        }
    }
}
