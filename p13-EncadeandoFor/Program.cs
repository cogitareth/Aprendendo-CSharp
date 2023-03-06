using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        for (int contadorLinhas = 0; contadorLinhas <=9; contadorLinhas++)
        {
            Console.WriteLine();
            for(int contadorColunas = 0; contadorColunas <= 9; contadorColunas++)
            {
             Console.Write("*");
            if (contadorColunas >= contadorLinhas)
                {
                    break;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
