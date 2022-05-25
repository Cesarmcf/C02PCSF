using System;

namespace E03_CalculadoraV03
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instanciar a calculadora
            CalculadoraSimples calc3 = new CalculadoraSimples();

            // Invocar os metodos da instancia
            calc3.LerDados();

            calc3.Somar();
            calc3.ApresentarDados();

            calc3.Subtrair();
            calc3.ApresentarDados();

            calc3.Dividir();
            calc3.ApresentarDados();

            calc3.Multiplicar();
            calc3.ApresentarDados();
            
            Console.ReadLine();

        }
    }
}
