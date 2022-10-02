
Console.WriteLine("Digite o valor de x.");

// Não realizo verificação aqui, já que no enunciado está definido que o valor de entrada é um número inteiro entre 1 e 10000;
var entryValue = int.Parse(Console.ReadLine());
var quizFizzBuzz = new QuizFizzBuzz();
quizFizzBuzz.ResultQuiz(entryValue);

public class QuizFizzBuzz
{
    public string[] GetMatrixFizzBuzz(int value) {
    var numberGroup = new string[value];

        for (var i = 1; i <= value; i++) {
            var fizz = i % 3 == 0;
            var buzz = i % 5 == 0;
            var fizzBuzz = fizz && buzz;
            
            if (fizzBuzz)
                numberGroup[i - 1] = "FizzBuzz";
            else if (fizz)
                numberGroup[i - 1] = "Fizz";
            else if (buzz)
                numberGroup[i - 1] = "Buzz";
            else
                numberGroup[i  - 1] = i.ToString();
        }
        return numberGroup;
    }

    public void ResultQuiz(int entryValue) {
        var matrix = GetMatrixFizzBuzz(entryValue);
        Console.Write("[");

        for (var i = 0; i < entryValue; i++) {
            Console.Write($" {matrix[i]} ");
        }
        Console.Write("]\n");
    }
}