using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D06_EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Variáveis

            int numero = 0;

            int valor01 = 1;
            int valor02 = 2;
            bool resultado;

            #endregion

            #region IF simples

            Utility.WriteTitle("if simples");

            // usado apenas numa açõa
            if (numero == 0)
                Console.WriteLine("O número é 0");


            // usar normalmente 
            if (numero == 100)
            {
                Console.WriteLine("O número é 100");
            }

            Utility.TerminateConsole();
            /*
            Console.ReadLine();
            Console.Clear();
            */
            #endregion

            #region IF...ELSE

           
            Utility.WriteTitle("IF...ELSE");
           

            if (numero == 100)
            {
                Console.WriteLine("O número é 100");
            }
            else
            {
                Console.WriteLine("O número é diferente de 100");
            }


            Utility.TerminateConsole();

            #endregion

            #region Operador Ternário

            // verificar se os dois valores são iguais

            Utility.WriteTitle("Operador ternário");
            Utility.WriteTitle("Versão classica if...else");
            Utility.WriteTitle("if (valor01 == valor02) {resultado = true;} else {resultado = false;}");
            // versão clássica com IF...ELSE
            if (valor01 == valor02)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            Utility.WriteTitle("**************************");
            // versão com operador ternário
            resultado = valor01 == valor02 ? true : false;

            Utility.WriteTitle("Operador ternário");

            Utility.WriteTitle("resultado = valor01 == valor02 ? true : false");

            Console.WriteLine(resultado);

            Utility.TerminateConsole();




            #endregion



            #region IF's encadeados

            Utility.WriteTitle("if's encadeados");


            /*
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nIF's encadeados");
            Console.WriteLine("-------------------------------------------------------------");
            */

            if (numero == 0)
            {
                Console.WriteLine("O número é 0");
            }
            else
            {
                if (numero == 10)
                {
                    Console.WriteLine("O número é 10");
                }
                else
                {
                    if (numero == 15)
                    {
                        Console.WriteLine("O número é 15");
                    }
                    else
                    {
                        Console.WriteLine("O número não é 0, nem 10, nem 15");
                    }
                }
            }

            Utility.TerminateConsole();

            #endregion

            #region IF...ELSEIF

            Utility.WriteTitle("if...else if");

            /*
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nIF...ELSE IF");
            Console.WriteLine("-------------------------------------------------------------");
            */

            if (numero == 0)
            {
                Console.WriteLine("O número é 0");
            }
            else if (numero == 10)
            {
                Console.WriteLine("O número é 10");
            }
            else if (numero == 15)
            {
                Console.WriteLine("O número é 15");
            }
            else
            {
                Console.WriteLine("O número não é 0, nem 10, nem 15");
            }

            Utility.TerminateConsole();

            #endregion
                        
            #region SWITCH

            Utility.WriteTitle("Switch");

            /*
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nSWITCH");
            Console.WriteLine("-------------------------------------------------------------");
            */

            switch (numero)
            {
                case 0:
                    Console.WriteLine("O número é 0");
                    break;
                case 10:
                    Console.WriteLine("O número é 10");
                    break;
                case 15:
                    Console.WriteLine("O número é 15");
                    break;

                default:
                    Console.WriteLine("O número não é 0, nem 10, nem 15");
                    break;
            }

            Utility.TerminateConsole();

            #endregion

            

        }
    }
}
