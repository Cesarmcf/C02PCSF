using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_ColecaoGenerica_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            // Queue --> Fila --> FIFO ( first-in, first-out)
            #region Queue<int>

            Queue<int> filaInteiros = new Queue<int>();

            // adicionar 1 a 1
            filaInteiros.Enqueue(1);
            filaInteiros.Enqueue(2);
            filaInteiros.Enqueue(3);


            // adicionar 3 valores de uma só vez

            for (int i = 4; i < 7; i++)
            {
                filaInteiros.Enqueue(i);
            }

            
            // eliminar e mostrar
            Console.WriteLine($"Dequeuing {filaInteiros.Dequeue()}"); //1
            Console.WriteLine($"Dequeuing {filaInteiros.Dequeue()}"); //2
            Console.WriteLine($"Dequeuing {filaInteiros.Dequeue()}");

            foreach (int item in filaInteiros)

            {

                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
