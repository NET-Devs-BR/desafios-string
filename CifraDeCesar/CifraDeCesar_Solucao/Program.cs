var s = Console.ReadLine();

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

        var letraCriptograda = char.IsUpper(c) ? ((c % 'Z') == 0 ? 'A' : c % 'Z' + chave) :
                                                 ((c % 'z') == 0 ? 'a' : c % 'z' + chave);
        mensagemCriptografada += ((char)letraCriptograda);
    }

    return mensagemCriptografada;
}

bool EhCaracterEspecial(char c)
{
    var caracteresEspeciais = "!@#$%&(*)-_+=§,/:;[]{}?. `''\"?°º/|";
    return caracteresEspeciais.Contains(c);
}


