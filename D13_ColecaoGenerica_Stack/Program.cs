using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_ColecaoGenerica_Stack
{
    class Program
    {
        static void Main(string[] args)
        {


            // Queue --> Pilha --> LIFO ( Last-in, first-out)
            #region Stack<int>
            Stack<int> pilhaInteiros = new Stack<int>();

            // adicionar 1 a 1
            pilhaInteiros.Push(1);
            pilhaInteiros.Push(2);
            pilhaInteiros.Push(3);
            // adicionar 3 valores de uma só vez

            for (int i = 4; i < 7; i++)
            {
                pilhaInteiros.Push(i);
            }


            // eliminar e mostrar
            Console.WriteLine($"Poping {pilhaInteiros.Pop()}"); //1
            Console.WriteLine($"Poping {pilhaInteiros.Pop()}"); //2
            Console.WriteLine($"Poping {pilhaInteiros.Pop()}"); //3

            foreach (int item in pilhaInteiros)

            {

                Console.WriteLine(item);
            }
            #endregion
        }

    }
 }

