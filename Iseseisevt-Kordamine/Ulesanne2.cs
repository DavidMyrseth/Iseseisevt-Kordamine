public class Ulessane2
{
    public static void Solve()
    {
        // Создание массива и заполнение его данными
        int[] numbers = { 1, 2, 3, 4, 2, 1, 5, 3 };

        // Поиск первого и последнего вхождения числа 2
        int firstIndex = Array.IndexOf(numbers, 2);
        int lastIndex = Array.LastIndexOf(numbers, 2);

        // Вывод результатов Первое вхождение числа 2/Последнее вхождение числа 2
        Console.WriteLine($"First occurrence of number 2: {firstIndex}");
        Console.WriteLine($"Last occurrence of number 2: {lastIndex}");

        // Копирование массива Скопированный массив
        int[] copiedArray = new int[numbers.Length];
        Array.Copy(numbers, copiedArray, numbers.Length);
        Console.WriteLine("Copied array: " + string.Join(", ", copiedArray));

        // Сортировка массива Отсортированный массив
        Array.Sort(numbers);
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

        // Реверс массива Обратный массив
        Array.Reverse(numbers);
        Console.WriteLine("Reverse array: " + string.Join(", ", numbers));
    }
}

// Класс для расчета зарплат
public class SalaryCalculator
{
    // Метод для расчета зарплат сотрудников
    public void CalculateSalaries()
    {
        // Значения зарплат и имен сотрудников
        var salaries = new int[] { 1200, 2500, 750, 395, 1200 };
        var names = new string[] { "A", "B", "C", "D", "E" };

        // Создание словаря, связывающего зарплату и имя
        var salaryDict = CreateSalaryDictionary(salaries, names);

        // Вывод результатов
        foreach (var kvp in salaryDict)
        {
            Console.WriteLine($"Name: {kvp.Value}, Salary: {kvp.Key}");
        }
    }

    // Создание словаря, связывающего зарплату и имя
    private Dictionary<int, string> CreateSalaryDictionary(int[] salaries, string[] names)
    {
        return salaries.Zip(names, (salary, name) => new { Salary = salary, Name = name })
                        .ToDictionary(x => x.Salary, x => x.Name);
    }
}

// Класс для управления студентами
public class StudentManager
{
    // Метод для поиска студентов, которые должны быть исключены
    public void FindFailedStudents()
    {
        // Создание массива студентов
        var students = CreateStudents();

        // Фильтрация студентов, которые должны быть исключены
        var failedStudents = FindFailedStudents(students);

        // Вывод результатов
        foreach (var student in failedStudents)
        {
            Console.WriteLine($"Student: {student.Name}, Group: {student.Group}");
        }
    }

    // Создание массива студентов с тестовыми данными
    private Student[] CreateStudents()
    {
        return new[]
        {
            new Student { Name = "Irakli Zirunov", Group = "group-01", Grades = new int[] { 3, 4, 5, 3, 4 } },
            new Student { Name = "Sasha Surkuv", Group = "group-02", Grades = new int[] { 2, 2, 2, 2, 2 } },
            new Student { Name = "David Myrseth", Group = "group-01", Grades = new int[] { 3, 4, 5, 3, 4 } },
            new Student { Name = "Danik Romanov", Group = "group-02", Grades = new int[] { 2, 2, 2, 2, 2 } },
            new Student { Name = "David Lennuk", Group = "group-03", Grades = new int[] { 3, 4, 5, 3, 4 } }
        };
    }

    // Фильтрация студентов, которые должны быть исключены
    private IEnumerable<Student> FindFailedStudents(Student[] students)
    {
        return students.Where(s => s.Grades.Count(g => g == 2) >= 3);
    }
}

// Класс для описания студента
public class Student
{
    public string Name { get; set; }
    public string Group { get; set; }
    public int[] Grades { get; set; }
}