using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Caracteres e Textos");
        
        char letra = 'a';
        Console.WriteLine(letra);

        //Cada char tem um código equivalente a sua função, algo que também nos possibilita fazer diversas operações.
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        //string para frases ou textos.
        string primeiraFrase = "Aprendendo C#! " + 2023;
        Console.WriteLine(primeiraFrase);

        //strings podem ser vazias, diferentemente dos chars.
        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);   


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}