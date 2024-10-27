public class Ulessane2
{
    public static void Solve()
    {
        // Массив
        int[] numbers = { 1, 2, 3, 4, 2, 1, 5, 3 };

        // Поиск числа 2
        int firstIndex = Array.IndexOf(numbers, 2);
        int lastIndex = Array.LastIndexOf(numbers, 2);

        // Первое вхождение числа 2
        // Последнее вхождение числа 2
        Console.WriteLine($"Number 2 esmakordne esinemine: {firstIndex}");
        Console.WriteLine($"Number 2 viimane esinemine: {lastIndex}");

        // Массив для Копирования
        int[] copiedArray = new int[numbers.Length];
        Array.Copy(numbers, copiedArray, numbers.Length);
        Console.WriteLine("Kopeeritud massiiv: " + string.Join(", ", copiedArray));

        // Отсортированный массив
        Array.Sort(numbers);
        Console.WriteLine("Sorteeritud massiiv: " + string.Join(", ", numbers));

        // Обратный массив
        Array.Reverse(numbers);
        Console.WriteLine("Vastupidine massiiv: " + string.Join(", ", numbers));
    }
}

// Для расчета зарплат
public class SalaryCalculator
{
    public void CalculateSalaries()
    {
        // Значения
        var salaries = new int[] { 1200, 2500, 750, 395, 1200 };
        var names = new string[] { "A", "B", "C", "D", "E" };

        // Создание словаря
        var salaryDict = CreateSalaryDictionary(salaries, names);

        // Вывод результатов
        foreach (var kvp in salaryDict)
        {
            Console.WriteLine($"Nimi: {kvp.Value}, Palk: {kvp.Key}");
        }
    }

    // Создание словаря, связывающего зарплату и имя
    private Dictionary<int, string> CreateSalaryDictionary(int[] salaries, string[] names)
    {
        return salaries.Zip(names, (salary, name) => new { Salary = salary, Name = name })
                        .ToDictionary(x => x.Salary, x => x.Name);
    }
}

// Поиска студентами
public class StudentManager
{
    public void FindFailedStudents()
    {
        // Массив
        var students = CreateStudents();

        // Студенты, которые должны быть исключены
        var failedStudents = FindFailedStudents(students);

        // Вывод результатов
        foreach (var student in failedStudents)
        {
            Console.WriteLine($"Uliopilane: {student.Name}, Grupp: {student.Group}");
        }
    }

    // Массив со студентами с данными
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

    // Фильтрация студентов
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