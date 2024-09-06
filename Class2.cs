using System;
using System.Collections.Generic; 

class Program
{
    class Student // Класс для хранения информации о студенте// Klass üliõpilase teabe salvestamiseks
    {
        public string LastName { get; set; } // Фамилия // Perekonnanimi
        public string FirstName { get; set; } // Имя  // Eesnimi
        public string GroupCode { get; set; } // Шифр группы // Rühma kood
        public int[] Grades { get; set; } // Оценки  // Hinnangud

        // Конструктор для инициализации студента  // Üliõpilase initsialiseerimise konstruktor
        public Student(string lastName, string firstName, string groupCode, int[] grades)
        {
            LastName = lastName;
            FirstName = firstName;
            GroupCode = groupCode;
            Grades = grades;
        }

        // Метод для проверки, есть ли у студента 3 и более двойки // Meetod kontrollimiseks, kas üliõpilasel on 3 või enam kahte
        public bool ShouldBeExpelled()
        {
            int countTwos = 0;
            foreach (int grade in Grades)
            {
                if (grade == 2)
                    countTwos++;
            }
            return countTwos >= 3; // Возвращаем true, если есть 3 или больше двоек // Tagastame true, kui on 3 või enam kahte
        }
    }

}

class Student // Класс для хранения информации о студенте// Klass üliõpilase teabe salvestamiseks
{
    public string LastName { get; set; } // Фамилия // Perekonnanimi
    public string FirstName { get; set; } // Имя  // Eesnimi
    public string GroupCode { get; set; } // Шифр группы // Rühma kood
    public int[] Grades { get; set; } // Оценки  // Hinnangud

    // Конструктор для инициализации студента  // Üliõpilase initsialiseerimise konstruktor
    public Student(string lastName, string firstName, string groupCode, int[] grades)
    {
        LastName = lastName;
        FirstName = firstName;
        GroupCode = groupCode;
        Grades = grades;
    }

    // Метод для проверки, есть ли у студента 3 и более двойки // Meetod kontrollimiseks, kas üliõpilasel on 3 või enam kahte
    public bool ShouldBeExpelled()
    {
        int countTwos = 0;
        foreach (int grade in Grades)
        {
            if (grade == 2)
                countTwos++;
        }
        return countTwos >= 3; // Возвращаем true, если есть 3 или больше двоек // Tagastame true, kui on 3 või enam kahte
    }
}