using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07_EstruturasCiclicas
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Variáveis

            string valor01 = "";     // string vazia ( não é igual a null )
            string valor02 = "x";
            string nome = string.Empty;     // string vazia ( não é igual a null ), estu sempre a construir um objecto, nos if's e case's não se pode usar
            int resultado;
            #endregion

            #region WHILE: pode nunca fazer se a variavel for declaraca igual á condição

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("WHILE");
            Console.WriteLine("-------------------------------------------------------------");

            // enquanto valor01 for diferente de x
            while (valor01 != "x")
            {
                Console.Write("Para saires escreve x: ");
                valor01 = Console.ReadLine();
            }

            // se o valor01 fosse declarado nas variáveis como "x", nunca entraca no ciclo.
            #endregion

            #region DO...WHILE: faz pelo menos 1x

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nDO...WHILE");
            Console.WriteLine("-------------------------------------------------------------");

            // repetir até valor01 ser diferente de x
            do
            {
                Console.Write("Para saires escreve x: ");
                valor02 = Console.ReadLine();
            } while (valor02 != "x");


            #endregion

            #region FOR V1: repetir x número de vezes, incremento

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nFOR V1");
            Console.WriteLine("-------------------------------------------------------------");

            // repetir o cliclo 5 vezes ( o cliclo inicia a 0 )

            for (int i = 0; i < 5; i++) // (int i = 0 declaração da variavel; i < length condição; i++ incrementa em 1) 
            {
                Console.WriteLine($"Numero {i}");

            }

            #endregion

            #region FOR V2: repetir x número de vezes, decremento

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nFOR V2: repetir x número de vezes, decremento");
            Console.WriteLine("-------------------------------------------------------------");

            for (int i = 4; i >= 0; i--) // (int i = 4 declaração da variavel; i < length condição; i-- decrementa em 1) 
            {
                Console.WriteLine($"Numero {i}");

            }

            #endregion

            #region FOR V3V1 tabuada dos 7

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nFOR V3.V1: tabuada dos 7");
            Console.WriteLine("-------------------------------------------------------------");

            
            for (int i = 1; i < 11; i++) // (int i = 0 declaração da variavel; i < length condição; i++ incrementa em 1) 
            {
                resultado = i * 7;
                Console.WriteLine($"7 X {i} = {resultado}");
                                
            }


            #endregion

            #region FOR V3V2 tabuada dos 7

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nFOR V3.V2: tabuada dos 7");
            Console.WriteLine("-------------------------------------------------------------");


            for (int i = 1; i < 11; i++) // (int i = 0 declaração da variavel; i < length condição; i++ incrementa em 1) 
            {
                
                Console.WriteLine($"7 X {i} = {7 * i}"); // não necessita da variavel resultado

            }


            #endregion

            #region FOREACH

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("\n\nFOREACH");
            Console.WriteLine("-------------------------------------------------------------");




            #endregion

            Console.ReadLine();


        }
    }
}
