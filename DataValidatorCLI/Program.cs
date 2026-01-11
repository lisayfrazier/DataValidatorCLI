
using System;
using System.Collections.Generic;
using System.Globalization;

Console.Title = "DataValidatorCLI";

// ===== Helper functions =====
static bool IsValidDate(string input)
{
    // Accepts dates like 2025-12-01
    return DateTime.TryParseExact(
        input,
        "yyyy-MM-dd",
        CultureInfo.InvariantCulture,
        DateTimeStyles.None,
        out _);
}

static bool IsValidAmount(string input, out decimal amount)
{
    return decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out amount);
}

// ===== Program start =====
Console.WriteLine("===================================");
Console.WriteLine("   DataValidatorCLI (C# Project)   ");
Console.WriteLine("===================================\n");

Console.WriteLine("This tool validates simple transaction entries.");
Console.WriteLine("You will enter transactions and the program will check for errors.\n");

var transactions = new List<string>();

while (true)
{
    Console.WriteLine("\nEnter a transaction (or type DONE to finish):");
    Console.WriteLine("Format: TransactionId,Date(yyyy-mm-dd),Amount,Description");
    Console.Write("Example: 1,2025-12-01,25.00,Coffee\n> ");

    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("❌ Empty input. Please try again.");
        continue;
    }

    if (input.Trim().Equals("DONE", StringComparison.OrdinalIgnoreCase))
        break;

    transactions.Add(input);
}

Console.WriteLine("\n=============================");
Console.WriteLine(" Validation Results");
Console.WriteLine("=============================\n");

int validCount = 0;
int invalidCount = 0;

foreach (var t in transactions)
{
    var parts = t.Split(',');

    // Basic format check
    if (parts.Length < 4)
    {
        Console.WriteLine($"❌ INVALID: '{t}'");
        Console.WriteLine("   Reason: Not enough fields. Must include 4 fields.");
        invalidCount++;
        continue;
    }

    string idText = parts[0].Trim();
    string dateText = parts[1].Trim();
    string amountText = parts[2].Trim();
    string description = parts[3].Trim();

    var errors = new List<string>();

    // Transaction ID
    if (!int.TryParse(idText, out int id) || id <= 0)
        errors.Add("TransactionId must be a positive number.");

    // Date
    if (!IsValidDate(dateText))
        errors.Add("Date must be in yyyy-mm-dd format (example: 2025-12-01).");

    // Amount
    if (!IsValidAmount(amountText, out decimal amount))
        errors.Add("Amount must be a valid number.");
    else if (amount < 0)
        errors.Add("Amount cannot be negative.");

    // Description
    if (string.IsNullOrWhiteSpace(description))
        errors.Add("Description cannot be empty.");

    // Output
    if (errors.Count == 0)
    {
        Console.WriteLine($"✅ VALID: Transaction #{id} | {dateText} | {amount} | {description}");
        validCount++;
    }
    else
    {
        Console.WriteLine($"❌ INVALID: '{t}'");
        Console.WriteLine("   Reason(s):");
        foreach (var e in errors)
            Console.WriteLine($"   - {e}");
        invalidCount++;
    }
}

Console.WriteLine("\n=============================");
Console.WriteLine($"Summary: Valid={validCount} | Invalid={invalidCount}");
Console.WriteLine("=============================\n");

Console.WriteLine("Press any key to exit...");
Console.ReadKey(); 


