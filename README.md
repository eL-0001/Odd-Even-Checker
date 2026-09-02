# Odd/Even Checker

A simple C# console application that checks whether a whole number is **odd or even**.

This is a beginner C# practice project created to help develop familiarity with basic programming concepts such as user input, number conversion, conditions, loops, methods, and input validation.

## What It Does

The program:

* Asks the user to enter a whole number.
* Checks whether the input is a valid whole number.
* Displays an error message if the input is invalid.
* Determines whether the number is **Odd** or **Even**.
* Asks the user whether they want to exit the program.
* Allows the user to continue checking numbers without restarting the program.

The program uses the **remainder operator (`%`)** to determine whether a number is odd or even.

If a number divided by 2 has a remainder other than `0`, it is odd. If the remainder is `0`, it is even.

## Example

```text
Odd/Even checker

Enter number to be checked: 17
The number is Odd

Exit program? (Y/N): N

Enter number to be checked: 42
The number is Even

Exit program? (Y/N): Y
```

If invalid input is entered:

```text
Enter number to be checked: hello

Invalid input. Please enter a whole number.
```

The program then allows the user to try again.

## C# Concepts Practiced

This project provides practice with:

* `Console.WriteLine()` and `Console.Write()`
* `Console.ReadLine()`
* Variables
* `int`
* `long`
* `int.TryParse()`
* The remainder operator (`%`)
* `if`, `else if`, and `else`
* `while` loops
* Local methods
* `return`
* `Environment.Exit()`
* Basic input validation

## Future Improvements

Possible improvements for a future version include:

* Make the `Y/N` input accept lowercase letters as well.
* Improve the exit validation so it does not rely on recursive method calls.
* Further improve the input handling and user instructions.
* Add automated tests.
* Improve the overall user interface of the console application.
* Experiment with additional number-checking features.

## Author

**eL-0001 (also Bokang Malgas)**

This project was created as part of my early C# learning and practice.
