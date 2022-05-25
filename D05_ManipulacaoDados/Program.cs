using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_ManipulacaoDados
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Variáveis e objetos
            string area = "Informática";
            string categoria = "Linguagem de programação";
            string curso = "Microsoft C# Iniciação";
            string cursocompleto1 = string.Join("; ", area, categoria, curso);
            string cursocompleto2 = string.Concat(area, "/", categoria, "-", curso);

            StringBuilder sb01 = new StringBuilder();   //overload
            sb01.Append(area);
            sb01.Append(" -- ");
            sb01.Append(categoria);
            sb01.Append(" -- ");
            sb01.Append(curso);


            int valor01 = 10;
            int valor02 = 100;
            double valor03 = 2.3;
            double valor04 = -12.1;

            DateTime timestamp = DateTime.Now;

            #endregion

            #region Manipulação strings
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("STRING");
            Console.WriteLine("-------------------------------------------------------------");

            // Curso em maiúsculas
            Console.WriteLine($"Curso em maiúsculas: {curso.ToUpper()}");
            // 1º palavra do curso
            Console.WriteLine($"1º palavra do curso: {curso.Substring(0,9)}");
            // string.join
            
            Console.WriteLine($"String Join: {cursocompleto1}");
            // string.concat
           
            Console.WriteLine($"String concat: {cursocompleto2}");
            #endregion

            #region Manipulação strings - StringBuilder

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nSTRING BUILDER");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"StringBuilder: {sb01}");
            #endregion

            #region Manipulação numérica Math
            Console.WriteLine("\n\n-------------------------------------------------------------");
            Console.WriteLine("NUMBER - MATH()");
            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine($"Valor mínimo: {Math.Min(valor02, valor01)}");
            Console.WriteLine($"Valor máximo: {Math.Max(valor02, valor01)}");
            Console.WriteLine($"Valor absoluto: {Math.Abs(valor04)}");
            Console.WriteLine($"Valor arredondado: {Math.Round(valor03)}");
            Console.WriteLine($"Valor raiz quadrada de 64: {Math.Sqrt(64)}");
            #endregion

            #region Manipulação datetime
            Console.WriteLine("\n\n-------------------------------------------------------------");
            Console.WriteLine("DATETIME");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Hora atual + 10 minutos V1: {timestamp.AddMinutes(10).Minute}");
            Console.WriteLine($"Hora atual + 10 minutos V2: {timestamp.AddMinutes(10).ToString("mm")}");
            Console.WriteLine($"Hora atual + 10 minutos V1: {timestamp.AddHours(1).Hour}");
            Console.WriteLine($"Hora atual + 10 minutos V2: {timestamp.AddHours(1).ToString("HH")}");
            //Console.WriteLine($": {}");
            //Console.WriteLine($"{}");

            #endregion

            Console.ReadLine();
        }
    }
}
