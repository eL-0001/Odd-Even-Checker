## Odd/Even Checker

A simple C# console application that determines whether a whole number is odd or even.

This project was created as part of my early C# learning journey. It helped me practice user input, number conversion, conditions, loops, methods, and the remainder operator.

# Features

- Accepts a whole number from the user
- Identifies whether the number is odd or even
- Supports positive and negative whole numbers
- Allows the user to check multiple numbers
- Asks the user whether they want to exit the program
- Handles invalid exit choices by asking again

## How It Works

The program uses the remainder operator `%` to divide the number by `2` and check the remainder:
A remainder of `0` means the number is even.
A remainder other than `0` means the number is odd.

# For example:
```text
8 % 2 = 0, so 8 is even.
7 % 2 = 1, so 7 is odd.
```
Example
```text
Odd/Even checker
Enter number to be checked: 15
The number is Odd

Exit program? (Y/N): N
Enter number to be checked: 24
The number is Even

Exit program? (Y/N): Y
```

## C# Concepts Practiced

This project uses the following C# concepts:

- Inputs and outputs
`Console.WriteLine()` and `Console.Write()`
`Console.ReadLine()`
- Variables and the `long` data type
`long.Parse()`
- The remainder operator `%`
`if` and `else` statements
`while` loops
- Local methods
`return`
`Environment.Exit()`

# Possible Future Improvements

Use `long.TryParse()` to prevent crashes when non-numeric input is entered
Accept lowercase `y` and `n` for the exit choice
Add clearer input instructions
Replace recursive exit validation with a loop
Add automated tests

## Author
Created by eL-0001, also Bokang, as a beginner C# practice project.
