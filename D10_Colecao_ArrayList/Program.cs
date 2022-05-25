using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using D00_Utility;

namespace D10_Colecao_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ArrayList: inteiros

            Utility.WriteTitle("ArrayList");

            // Instanciar o ArrayList
            ArrayList listaInteiros = new ArrayList();

            // Adicionar valores 1 a 1
            listaInteiros.Add(1);
            listaInteiros.Add(2);
            listaInteiros.Add(3);
            listaInteiros.Add(4);


            // Adicionando valores usando um FOR de 5 até 8
            for (int i = 5; i < 9 ; i++)
            {
                listaInteiros.Add(i);
            }



            // ArrayList não é fortemente tipada ( não está defenido um tipo de dados )
            listaInteiros.Add("texto");


            // Listar
            // Se o ArrayList tiver vários tipos de dados, usar var
            foreach (var inteiros in listaInteiros)
            {
                Console.WriteLine(inteiros.ToString());
            }


            Utility.TerminateConsole();
            #endregion

            #region ArrayList: strings

            Utility.WriteTitle("ArrayList: Strings");

            ArrayList listaStrings = new ArrayList()
            {
                "A",
                "B",
                "C"
            };

            foreach (var item in listaStrings)
            {
                Console.WriteLine(item.ToString());
            }

            Utility.TerminateConsole();


            #endregion

            Utility.WriteTitle("ArrayList: pessoas");

            #region ArrayList: pessoas 

            ArrayList listaPessoas = new ArrayList();

            Pessoa pessoa01 = new Pessoa(1, "a");

            Pessoa pessoa02 = new Pessoa();
            pessoa02.Id = 2;
            pessoa02.Nome = "b";

            listaPessoas.Add(pessoa01);
            listaPessoas.Add(pessoa02);

            foreach (Pessoa p in listaPessoas)
            {
                Console.WriteLine($"Id: {p.Id} - Nome: {p.Nome}");
            }

            Utility.TerminateConsole();

            #endregion

            Utility.WriteTitle("ArrayList: Funcionários");

            #region ArrayList: funcionários 

            ArrayList listaFuncionarios = new ArrayList();

            Funcionario funcionario01 = new Funcionario(1, "F1", "D1");
            
            Funcionario funcionario02 = new Funcionario();
            funcionario02.Id = 2;
            funcionario02.Nome = "F2";
            funcionario02.Departamento = "D2";

            listaFuncionarios.Add(funcionario01);
            listaFuncionarios.Add(funcionario02);

            foreach (Funcionario f in listaFuncionarios)
            {
                Console.WriteLine($"Id: {f.Id} - Nome: {f.Nome} - Departamento: {f.Departamento}");
            }

            Utility.TerminateConsole();


            #endregion
        }
    }
}
