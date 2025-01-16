using System;

public class FizzBuzzSolver
{
    
// FizzBuzz Challenge Instructions

// Objective:
// Implement a method that generates a sequence of numbers from 1 to `n`, 
// replacing certain numbers with the words "Fizz" and "Buzz" based on specific conditions.

// Method Signature:
// public static string FizzBuzz(int n)

// Steps to Implement:

// 1. Initialize the Result String:
// Create an empty string variable named `result` to store the final output.

// 2. Loop Through Numbers:
// Use a `for` loop to iterate through numbers from 1 to `n`.

// 3. Determine the Output for Each Number:
// For each number `i` in the loop:
// - Initialize an empty string variable named `current`.
// - If `i` is divisible by 3, append "Fizz" to `current`.
// - If `i` is divisible by 5, append "Buzz" to `current`.
// - If `current` is still empty (i.e., `i` is not divisible by 3 or 5), set `current` to the string representation of `i`.

// 4. Build the Result String:
// Append `current` to the `result` string.
// If `i` is not the last number, append a comma and a space (", ") to `result`.

// 5. Return the Result:
// After the loop, return the `result` string.

// Example:
// For `n = 15`, the output should be:
// "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz"

// Main Method:
// You can use the `Main` method to test your implementation:
public static void Main()
{
    Console.WriteLine(FizzBuzz(15));
}

}