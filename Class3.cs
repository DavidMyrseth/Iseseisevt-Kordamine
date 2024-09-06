using System;
using System.Collections.Generic; // Для использования списков и других коллекций

class Program
{
    static void Main()
    {
        // Инициализируем список зарплат
        List<int> palgad = new List<int> { 1200, 2500, 750, 395, 1200 };

        // Инициализируем список имен
        List<string> inimesed = new List<string> { "A", "B", "C", "D", "E" };

        // 1. Удаление человека и его зарплаты
        Console.WriteLine("Введите индекс человека, которого нужно удалить (от 0 до {0}):", inimesed.Count - 1);
        int indexToRemove = int.Parse(Console.ReadLine()); // Читаем индекс, который вводит пользователь

        if (indexToRemove >= 0 && indexToRemove < inimesed.Count) // Проверка на допустимость индекса
        {
            Console.WriteLine("Удаляем: {0} с зарплатой {1}", inimesed[indexToRemove], palgad[indexToRemove]);
            inimesed.RemoveAt(indexToRemove); // Удаляем человека из списка
            palgad.RemoveAt(indexToRemove); // Удаляем его зарплату из списка
        }
        else
        {
            Console.WriteLine("Неверный индекс."); // Сообщение об ошибке, если индекс некорректный
        }

        // 2. Поиск самой большой зарплаты 
        int maxSalary = -1; // Переменная для хранения максимальной зарплаты
        string personWithMaxSalary = ""; // Переменная для хранения имени человека с максимальной зарплатой

        for (int i = 0; i < palgad.Count; i++) // Проходим по всем оставшимся зарплатам
        {
            if (palgad[i] > maxSalary) // Если текущая зарплата больше максимальной найденной
            {
                maxSalary = palgad[i]; // Обновляем максимальную зарплату
                personWithMaxSalary = inimesed[i]; // Обновляем имя человека с максимальной зарплатой
            }
        }

        // Вывод информации о самой большой зарплате
        Console.WriteLine("Самая большая зарплата: {0}, получает: {1}", maxSalary, personWithMaxSalary);

        // 3. Поиск людей с одинаковыми зарплатами
        Console.WriteLine("Люди с одинаковыми зарплатами:");
        Dictionary<int, List<string>> salaryToPeople = new Dictionary<int, List<string>>(); // Словарь для группировки людей по зарплатам

        for (int i = 0; i < palgad.Count; i++) // Проходим по оставшимся зарплатам
        {
            int salary = palgad[i]; // Текущая зарплата
            string person = inimesed[i]; // Текущий человек

            if (!salaryToPeople.ContainsKey(salary)) // Если такой зарплаты еще нет в словаре
            {
                salaryToPeople[salary] = new List<string>(); // Создаем новый список людей для этой зарплаты
            }
            salaryToPeople[salary].Add(person); // Добавляем человека в список для этой зарплаты
        }

        // Выводим людей с одинаковыми зарплатами
        foreach (var entry in salaryToPeople) // Проходим по словарю
        {
            if (entry.Value.Count > 1) // Если больше одного человека получает одну и ту же зарплату
            {
                Console.WriteLine("Зарплата {0} у людей: {1}", entry.Key, string.Join(", ", entry.Value)); // Выводим зарплату и людей
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаем список студентов
        List<Student> students = new List<Student>();

        // Добавляем студентов в список
        students.Add(new Student("Иванов", "Иван", "ГРУППА-101", new int[] { 5, 4, 2, 2, 2 })); // Пример студента с 3 двойками
        students.Add(new Student("Петров", "Петр", "ГРУППА-101", new int[] { 4, 5, 3, 4, 5 })); // Пример студента без двоек
        students.Add(new Student("Сидоров", "Сидор", "ГРУППА-102", new int[] { 2, 2, 2, 2, 2 })); // Пример студента с 5 двойками
        students.Add(new Student("Кузнецов", "Алексей", "ГРУППА-102", new int[] { 3, 3, 3, 4, 2 })); // Пример студента с одной двойкой

        // Создаем список для студентов, которые будут отчислены
        List<Student> expelledStudents = new List<Student>();

        // Проверяем каждого студента
        foreach (Student student in students) // Проходим по каждому студенту
        {
            if (student.ShouldBeExpelled()) // Если студент должен быть отчислен
            {
                expelledStudents.Add(student); // Добавляем студента в список для отчисления
            }
        }

        // Выводим студентов, которые будут отчислены
        Console.WriteLine("Студенты, включенные в приказ на отчисление:");
        foreach (Student student in expelledStudents) // Проходим по списку отчисленных студентов
        {
            Console.WriteLine($"{student.LastName} {student.FirstName} ({student.GroupCode})"); // Выводим фамилию, имя и шифр группы
        }

        // Если нет студентов для отчисления, выводим соответствующее сообщение
        if (expelledStudents.Count == 0)
        {
            Console.WriteLine("Нет студентов для отчисления."); // Сообщение, если никто не отчислен
        }
    }
}
