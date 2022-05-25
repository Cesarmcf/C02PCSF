using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_CalculadoraV04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controlo = true;

            CalculadoraSimples calc = new CalculadoraSimples();

            try
            {

                do
                {

                    calc.MostrarMenu();
                    calc.LerOperacao();

                    controlo = calc.ValidarOperacao();  //retorna validado

                    if (calc.Operacao != "x" && controlo)
                    {
                        calc.LerDados();
                        calc.Decisoes();
                        calc.ApresentarDados();
                        controlo = false;
                    }
                } while (calc.Operacao != "x" && !controlo);


            }
            catch (Exception)
            {

                Console.WriteLine("ERRO!!!");
            }
            finally
            {
                Utility.TerminateConsole();
            }

        }

    }
}
