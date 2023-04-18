// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite uma mensagem: ");
var s = Console.ReadLine();

Console.WriteLine("Digite a chave: ");
Int32.TryParse(Console.ReadLine(), out int chave);

Console.WriteLine(Criptografar(s, chave));

string Criptografar(string s, int chave){
    var mensagemCriptografada = string.Empty;

    foreach (var c in s)
    {
        if(EhCaracterEspecial(c)){
            mensagemCriptografada += c;
            continue;
        }

        var letraCriptograda = c + chave - 1;
        mensagemCriptografada += ((char)letraCriptograda);
    }

    return mensagemCriptografada;
}

bool EhCaracterEspecial(char c)
{
    var caracteresEspeciais = "!@#$%&(*)-_+=§,/:;[]{}?. `''\"?°º/|";
    return caracteresEspeciais.Contains(c);
}


