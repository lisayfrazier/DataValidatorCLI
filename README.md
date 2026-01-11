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

##  Input Format

Each transaction must be entered in this format:

```txt
TransactionId,Date(yyyy-MM-dd),Amount,Description
