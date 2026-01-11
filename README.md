# DataValidatorCLI

A C# console app I built to validate transaction entries from user input (TransactionId, Date, Amount, Description).  
Created as a practice project to strengthen my C# fundamentals and GitHub workflow.

## Features
- Accepts transaction input line-by-line in the console
- Validates transaction ID, date format, amount, and description
- Displays clear validation errors for invalid records
- Outputs a final summary showing valid vs invalid transactions

## Validation Rules
Each transaction must meet the following rules:
- Transaction ID must be a **positive integer**
- Date must be in the format **yyyy-mm-dd** (example: 2025-12-01)
- Amount must be a **valid number** and **not negative**
- Description must **not be empty**

## Input Format

Enter transactions using this format:

```txt
TransactionId,Date(yyyy-mm-dd),Amount,Description

## How to Run

1. Open the solution in Visual Studio
2. Press **Ctrl + F5** to run (Start Without Debugging)
3. Enter transactions one per line
4. Type **DONE** to finish and view results


## Sample Output

```txt
VALID: Transaction #1 | 2025-12-01 | 25.00 | Coffee
INVALID: '2,2025-13-01,30.00,Groceries'
Reason(s):
- Date must be in yyyy-mm-dd format (example: 2025-12-01).








