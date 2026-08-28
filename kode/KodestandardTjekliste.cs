// KodestandardTjekliste.cs
//
// Fejlkategorier fundet i den oprindelige kode:
// 1. Ungarsk notation
// 2. Forkert navngivning og case
// 3. Misvisende variabelnavne
// 4. Magiske tal
// 5. Inkonsekvent indrykning
// 6. Forkert datatype til penge
// 7. Kommentar der forklarer hvad i stedet for hvorfor
// 8. Ubrugt using
//
// Den følgende version er rettet, så den følger kodestandarden.

using System;

class ProductCalculator
{
    // Konstanter bruges til værdier, der ikke skal ændres.
    // Det undgår magiske tal direkte i beregningerne.
    private const int MaxQuantity = 100;
    private const decimal DiscountThreshold = 500m;
    private const decimal DiscountRate = 0.15m;

    static void Main(string[] args)
    {
        Console.WriteLine("Indtast antal varer:");

        // Meningsfuldt variabelnavn i camelCase.
        string quantityInput = Console.ReadLine();
        int quantity = Convert.ToInt32(quantityInput);

        Console.WriteLine("Indtast pris pr. vare:");

        // Decimal bruges til penge for at undgå problemer med
        // binær floating-point afrunding fra double.
        string priceInput = Console.ReadLine();
        decimal unitPrice = Convert.ToDecimal(priceInput);

        decimal totalPrice = quantity * unitPrice;

        if (totalPrice > DiscountThreshold)
        {
            decimal discount = totalPrice * DiscountRate;
            decimal finalPrice = totalPrice - discount;

            Console.WriteLine($"Rabat: {discount:F2} kr.");
            Console.WriteLine($"Total: {finalPrice:F2} kr.");
        }
        else
        {
            Console.WriteLine($"Total: {totalPrice:F2} kr.");
        }

        string message = CalculateStatus(quantity);
        Console.WriteLine(message);
    }

    // Metoden har et tydeligt navn i PascalCase og gør koden
    // lettere at læse og genbruge.
    static string CalculateStatus(int quantity)
    {
        if (quantity > 50)
        {
            return "Stor ordre";
        }

        return "Almindelig ordre";
    }
}