using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_NomeCompletoV01
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            func.ReadNames();
            func.JoinNames();
            func.ShowFullName();

            Console.ReadLine();
        }
    }
}
