using System;

namespace D02_Algoritmia
{
    public static class E05_InscricaoCurso
    {
        public static void InscreverCursoV01()
        {
            //Declarar variavel
            bool programador;
            string curso;

            // Manipular dados
            Console.WriteLine("Sabes programar (true/false)?");
            programador = Convert.ToBoolean(Console.ReadLine());

            // Avaliar curso

            if (programador)  // a mesma forma de colocar (programador = true), se for not true coloca-se (!programador)
            {
                curso = "C# Foundation";
            }
            else
            {
                curso = "Programming Fundamentals";
            }

            //Informar a inscrição no curso
            Console.WriteLine("\nAluno inscrito no curso " + curso);

            //Pausar a consola
            Console.ReadLine();
        }


        public static void InscreverCursoV02()
        {
            //Declarar variavel
            string programador2;
            string curso2;

            // Manipular dados
            Console.WriteLine("Sabes programar(S/N)? ");
            programador2 = Console.ReadLine();

            // Avaliar curso

            if (programador2 == "S")
            {
                curso2 = "C# Foundation";
            }
            else
            {
                curso2 = "Programming Fundamentals";
            }

            //Informar a inscrição no curso

            //Console.WriteLine("\nAluno inscrito no curso " + curso2);

            Console.WriteLine($"\nAluno inscrito no curso {curso2}"); //o uso da String interpolation 

            //Pausar a consola
            Console.ReadLine();
        }

    }
}
