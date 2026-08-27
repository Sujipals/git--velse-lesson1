using System;
using System.Collections.Generic;

class Program
{
    private const decimal DiscountThreshold = 500m;
    private const decimal DiscountRate = 0.15m;

    static void Main(string[] args)
    {
        Console.WriteLine("=== Vareberegner ===");

        decimal totalPrice = 0m;
        string continueInput = "j";

        while (continueInput == "j")
        {
            Console.Write("Indtast varenavn: ");
            string productName = Console.ReadLine();

            Console.Write("Indtast antal: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast pris pr. enhed: ");
            decimal unitPrice = decimal.Parse(Console.ReadLine().Replace(',', '.'));

            decimal lineTotal = quantity * unitPrice;
            totalPrice += lineTotal;

            Console.WriteLine($"{productName}: {quantity} stk. à {unitPrice:F2} kr. = {lineTotal:F2} kr.");

            Console.Write("Vil du registrere endnu en vare? (j/n): ");
            continueInput = Console.ReadLine().ToLower();
        }

        Console.WriteLine($"Samlet pris før rabat: {totalPrice:F2} kr.");

        decimal discount = CalculateDiscount(totalPrice);

        if (discount > 0)
        {
            Console.WriteLine($"Rabat: {discount:F2} kr.");
            Console.WriteLine($"Samlet pris: {totalPrice - discount:F2} kr.");
        }
        else
        {
            Console.WriteLine("Ingen rabat (under 500 kr.)");
            Console.WriteLine($"Samlet pris: {totalPrice:F2} kr.");
        }
    }

    static decimal CalculateDiscount(decimal totalPrice)
    {
        if (totalPrice > DiscountThreshold)
        {
            return totalPrice * DiscountRate;
        }

        return 0m;
    }
}