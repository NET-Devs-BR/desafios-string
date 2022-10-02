using FluentAssertions;

namespace FizzBuzzTests;

public class QuizFizzBuzzTests
{
    [Fact]
    public void WhenNumberIsMultipleOfTreeReturnOneFizz()
    {
        // Given
        var entryNumber = 3;
        var quizFizzBuzz = new QuizFizzBuzz();
    
        // When
        var result = quizFizzBuzz.GetMatrixFizzBuzz(entryNumber);
        var getCountFizz = result.Where(_ => _ == "Fizz").Count();
    
        // Then
        getCountFizz.Should().Be(1);
    }

    [Fact]
    public void WhenNumberIsMultipleOfFiveReturnOneBuzz()
    {
        // Given
        var entryNumber = 5;
        var quizFizzBuzz = new QuizFizzBuzz();
    
        // When
        var result = quizFizzBuzz.GetMatrixFizzBuzz(entryNumber);
        var getCountFizz = result.Where(_ => _ == "Buzz").Count();
    
        // Then
        getCountFizz.Should().Be(1);
    }

    [Fact]
    public void WhenNumberIsMultipleOfTreeAndFiveReturnOneFizzBuzz()
    {
        // Given
        var entryNumber = 15;
        var quizFizzBuzz = new QuizFizzBuzz();
    
        // When
        var result = quizFizzBuzz.GetMatrixFizzBuzz(entryNumber);
        var getCountFizz = result.Where(_ => _ == "FizzBuzz").Count();
    
        // Then
        getCountFizz.Should().Be(1);
    }
}