using System;

namespace E01_CalculadoraV01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Novo projeto
             * E01: Calculadora
             * Calculadora com 2 números e 4 operações aritméticas (editado) 
             *
             */

            //variáveis que irão conter os números digitados
            double numero1, numero2;
            double resultado;
                                             
            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            //efectua a soma e lista na consola
            resultado = numero1 + numero2;
            Console.WriteLine($"Valor da Soma = {resultado}");

            //efectua a subtração e lista na consola
            resultado = numero1 - numero2;
            Console.WriteLine($"Valor da Subtração = {resultado}");

            //efectua a multiplicação e lista na consola
            resultado = numero1 * numero2;
            Console.WriteLine($"Valor da Multiplicação = {resultado}");

            //efectua a divisão e lista na consola
            resultado = numero1 / numero2;
            Console.WriteLine($"Valor da Divisão = {resultado}");

            Console.ReadLine();

        }
    }
}
