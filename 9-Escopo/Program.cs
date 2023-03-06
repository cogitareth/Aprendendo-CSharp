using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Condicionais parte 2");

        int idadeJoao = 16;
        int quantidadePessoas = 0;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;
        if(acompanhado == true)
        {
            textoAdicional = "Você está acompanhado!";
        }
        else
        {
            textoAdicional = "Você não está acompanhado!";
        }

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}