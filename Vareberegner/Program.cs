using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Vareberegner ===");

        Console.Write("Indtast varenavn: ");
        string productName = Console.ReadLine();

        Console.Write("Indtast antal: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Indtast pris pr. enhed: ");
        decimal unitPrice = Convert.ToDecimal(Console.ReadLine());

        decimal lineTotal = quantity * unitPrice;

        Console.WriteLine($"{productName}: {quantity} stk. à {unitPrice:F2} kr. = {lineTotal:F2} kr.");
    }
}