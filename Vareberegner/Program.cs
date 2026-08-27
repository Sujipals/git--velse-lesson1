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

        Console.WriteLine($"Vare: {productName}");
        Console.WriteLine($"Antal: {quantity}");
        Console.WriteLine($"Pris pr. enhed: {unitPrice:F2} kr.");
    }
}