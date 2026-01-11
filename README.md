# DataValidatorCLI

A C# console app I built to validate transaction entries.  
Created as a practice project to strengthen my C# fundamentals and GitHub workflow.

This tool checks each transaction for:
- Valid Transaction ID (positive integer)
- Valid Date format (yyyy-mm-dd)
- Valid Amount (number and not negative)
- Non-empty Description

## Input Format

Each transaction should be entered like this:

```txt
1,2025-12-01,25.00,Coffee




