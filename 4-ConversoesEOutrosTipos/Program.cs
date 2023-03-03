using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos");

        double salario = 3000.15;

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);  

        //tipo de variável de 64 bits
        long x = 200000000000;
        Console.WriteLine(x);

        //tipo de variável com 16 bits
        short y = 1500;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);
        
        
        Console.WriteLine("Tecle enter para fechar!");
        Console.ReadLine();
    }
}
