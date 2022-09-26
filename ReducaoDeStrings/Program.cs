// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

var palavra = Convert.ToString(Console.ReadLine()).ToLower();

Console.WriteLine(redutorDeString(palavra));

string redutorDeString(string s){ 
    var pilhaDeCaracteres = new Stack<char>(); 

    for(int i = 0; i < s.Length; i++){ 
        if(pilhaDeCaracteres.Count == 0 || pilhaDeCaracteres.Peek() != s[i]){
            pilhaDeCaracteres.Push(s[i]);  
        } else {
            pilhaDeCaracteres.Pop(); 
        }
    }

    var pilhaVazia = pilhaDeCaracteres.Count == 0;
    var palavraReduzida = new string((pilhaVazia) ? "Empty String" : string.Join(null, pilhaDeCaracteres.Reverse()));

    return palavraReduzida;
}