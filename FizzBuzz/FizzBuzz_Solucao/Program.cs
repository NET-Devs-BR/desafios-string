
Console.WriteLine("Digite o valor de x.");
var x = int.Parse(Console.ReadLine()); // Não realizo verificação aqui, já que no enunciado está definido que o valor de entrada é um número inteiro entre 1 e 10000

var n = FizzBuzz(x);

Console.Write("[");

for (var i = 0; i < x; i++) {
    Console.Write($" {n[i]} ");
}

Console.Write("]\n");

string[] FizzBuzz(int x) {
    var n = new string[x];

    for (var i = 1; i <= x; i++) {
        var fizz = i % 3 == 0;
        var buzz = i % 5 == 0;
        var fizzBuzz = fizz && buzz;

        if (fizzBuzz)
            n[i - 1] = "FizzBuzz";
        else if (fizz)
            n[i - 1] = "Fizz";
        else if (buzz)
            n[i - 1] = "Buzz";
        else
            n[i  - 1] = i.ToString();
    }

    return n;
}






