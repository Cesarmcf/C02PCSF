using System;

namespace E03_CalculadoraV03
{
    public class CalculadoraSimples
    {
        #region Properties

        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }
        public string Operacao { get; set; }

        #endregion

        #region Variaveis publicas da class
        /*        
        public static double numero1, numero2, resultado;
        public static string operacao;
        */
        #endregion

        #region Methods


        public void LerDados()
        {

            //variáveis que irão conter os números digitados

            Console.WriteLine("Digite o primeiro número: ");
            Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Numero2 = Convert.ToDouble(Console.ReadLine());

        }



        public void Somar()
        {


            //efectua a soma e lista na consola
            Resultado = Numero1 + Numero2;
            Operacao = "+";
            
            //Console.WriteLine($"Valor da Soma = {resultado}");
            
        }




        public void Subtrair()
        {

            
            //efectua a subtração e lista na consola
            Resultado = Numero1 - Numero2;
            Operacao = "-";

            //Console.WriteLine($"Valor da Subtração = {resultado}");

        }




        public void Multiplicar()
        {
            //efectua a multiplicação e lista na consola
            Resultado = Numero1 * Numero2;
            Operacao = "*";

            //Console.WriteLine($"Valor da Multiplicação = {resultado}");

        }




        public void Dividir()
        {
            //efectua a divisão e lista na consola
            Resultado = Numero1 / Numero2;
            Operacao = "/";

            //Console.WriteLine($"Valor da Divisão = {resultado}");

        }



        public void ApresentarDados()
        {
            Console.WriteLine($"\n{Numero1} {Operacao} {Numero2} = {Resultado}");

        }
        #endregion
    }
}
