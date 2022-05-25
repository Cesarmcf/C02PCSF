using System;

namespace E01_CalculadoraV02
{
    public class CalculadoraSimples
    {
        public static double numero1, numero2, resultado;
        public static string operacao;

        public static void LerDados()
        {
            //variáveis que irão conter os números digitados

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

        }



        public static void Somar()
        {
            //efectua a soma e lista na consola
            resultado = numero1 + numero2;
            operacao = "+";
            
            //Console.WriteLine($"Valor da Soma = {resultado}");
            
        }




        public static void Subtrair()
        {
            //efectua a subtração e lista na consola
            resultado = numero1 - numero2;
            operacao = "-";

            //Console.WriteLine($"Valor da Subtração = {resultado}");

        }




        public static void Multiplicar()
        {
            //efectua a multiplicação e lista na consola
            resultado = numero1 * numero2;
            operacao = "*";

            //Console.WriteLine($"Valor da Multiplicação = {resultado}");

        }




        public static void Dividir()
        {
            //efectua a divisão e lista na consola
            resultado = numero1 / numero2;
            operacao = "/";

            //Console.WriteLine($"Valor da Divisão = {resultado}");

        }



        public static void ApresentarDados()
        {
            Console.WriteLine($"\n{numero1} {operacao} {numero2} = {resultado}");

        }
    }
}
