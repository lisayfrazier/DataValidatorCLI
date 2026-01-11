# DataValidatorCLI 

A C# console application that validates transaction entries entered by a user in the terminal.  
Built as a practice project to strengthen **C# fundamentals**, **input validation**, and a professional **GitHub workflow**.

---

##  What This App Does
This CLI tool helps validate transaction records to prevent formatting errors and bad data.  
It checks each transaction for:

-  Valid Transaction ID (positive integer)
-  Valid Date format (`yyyy-MM-dd`)
-  Valid Amount (numeric and non-negative)
-  Valid Description (required)

At the end, it prints a summary of how many entries were valid vs invalid.

---

##  Tech Stack
- C# (.NET Console Application)
- Visual Studio
- Git + GitHub

---
---

## How to Run

### Option 1 — Run in Visual Studio
1. Open the solution file: `DataValidatorCLI.sln` in Visual Studio
2. Set the startup project to **DataValidatorCLI**
3. Press **Ctrl + F5** to run (Start Without Debugging)
4. Enter transactions one per line using this format:

Example:
```txt
1,2025-12-01,25.00,Coffee
2,2025-13-01,30.00,Groceries
3,2025-12-01,-10.00,Refund
DONE

---

### Option 2 — Run in Terminal (Windows)
If you have .NET installed:

1. Open Command Prompt or PowerShell
2. Navigate to the project folder
3. Run:

```bash
dotnet run


##  Input Format

Each transaction must be entered in this format:

```txt
TransactionId,Date(yyyy-MM-dd),Amount,Description
