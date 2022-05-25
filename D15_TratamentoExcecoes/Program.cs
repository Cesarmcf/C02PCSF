using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D15_TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Try...Catch...Finally

            try
            {

                Utility.WriteTitle("Try...Catch...Finally");

                int valor01, valor02;

                string texto;

                valor01 = 10;

                valor02 = 0;

                texto = "ERRO";

                Console.WriteLine(10 / 2);

                // Console.WriteLine(10 / 2);       // dá erro de sintaxe, mas com as variáveis ultrapassamos

                Console.WriteLine(valor01 / int.Parse(texto));  //System.FormatExceptionuy

                //Console.WriteLine(valor01 / Convert.ToInt16(texto));    //System.FormatException

                Console.WriteLine(valor01 / valor02); // dá exception   System.DivideByZeroException

                Console.WriteLine(valor01 * valor02); // dá 0


            }
            catch (FormatException)
            {

                Console.WriteLine("Atenção ao formato.");

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Erro, divisão por 0.");

            }
            catch (Exception)
            {

                Console.WriteLine("Erro!");

                //throw;   // isto lança o erro para ver-mos qual é
            }
            finally
            {

                Utility.TerminateConsole();

            }
            #endregion
        }
    }
}
