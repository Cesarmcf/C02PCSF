using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_RegistoCursos_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usar o Main para testar a classe
            Curso curso01 = new Curso();
            Curso curso02 = new Curso();

            curso01.InserirCurso();
            Console.WriteLine();
            curso02.InserirCurso();

            Curso.ListarCurso(Curso.listaCursos);
            Curso.CalcularTotalHorasCursos();
            Console.ReadLine();
        }
    }
}
