using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Ulesanne: Kahemootmeline massiiv
        Console.WriteLine("Ülesanne 1: Töö kahemõõtmelise massiiviga");
        Ulesanne1.Solve();

        // 2. Ulesanne: Massiivide kordused ja operatsioonid
        Console.WriteLine("\nÜlesanne 2: Massiivide töötlemine");
        Ulessane2.Solve();

        // 3. Ulesanne: Palgad ja inimesed
        Console.WriteLine("\nÜlesanne 3: Palgade haldamine");
        Ulessane3.Solve();
    }
}