namespace Tests;
using Xunit;

public class FizzBuzzSolverTests
{
    [Fact]
    public void FizzBuzz_ShouldReturnCorrectOutput()
    {
        // Arrange
        int input = 15;
        string expectedOutput = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz";

        // Act
        string actualOutput = FizzBuzzSolver.FizzBuzz(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void FizzBuzz_ShouldHandleSmallNumbers()
    {
        // Arrange
        int input = 5;
        string expectedOutput = "1, 2, Fizz, 4, Buzz";

        // Act
        string actualOutput = FizzBuzzSolver.FizzBuzz(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void FizzBuzz_ShouldHandleOnlyFizz()
    {
        // Arrange
        int input = 3;
        string expectedOutput = "1, 2, Fizz";

        // Act
        string actualOutput = FizzBuzzSolver.FizzBuzz(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void FizzBuzz_ShouldHandleOnlyBuzz()
    {
        // Arrange
        int input = 5;
        string expectedOutput = "1, 2, Fizz, 4, Buzz";

        // Act
        string actualOutput = FizzBuzzSolver.FizzBuzz(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void FizzBuzz_ShouldReturnEmptyStringForZero()
    {
        // Arrange
        int input = 0;
        string expectedOutput = "";

        // Act
        string actualOutput = FizzBuzzSolver.FizzBuzz(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}