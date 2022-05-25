using System;

namespace E01_CalculadoraV02
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculadoraSimples.LerDados();

            CalculadoraSimples.Somar();
            CalculadoraSimples.ApresentarDados();

            CalculadoraSimples.Subtrair();
            CalculadoraSimples.ApresentarDados();

            CalculadoraSimples.Dividir();
            CalculadoraSimples.ApresentarDados();

            CalculadoraSimples.Multiplicar();
            CalculadoraSimples.ApresentarDados();

            Console.ReadLine();


        }
    }
}
