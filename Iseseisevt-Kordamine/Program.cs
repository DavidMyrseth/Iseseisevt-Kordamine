using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Ulesanne: Kahemootmeline massiiv
        Console.WriteLine("Ulesanne 1: Too kahemootmelise massiiviga");
        Ulesanne1.Solve();

        // 2. Ulesanne: Massiivide kordused ja operatsioonid
        Console.WriteLine("\nUlesanne 2: Massiivide tootlemine");
        Ulessane2.Solve();

        // 3. Ulesanne: Palgad ja inimesed
        Console.WriteLine("\nUlesanne 3: Palgade haldamine");
        Ulessane3.Solve();
    }
}