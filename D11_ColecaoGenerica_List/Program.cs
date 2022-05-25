using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_ColecaoGenerica_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criar 1 pessoa com o 2º cunstructor e listar

            Pessoa p1 = new Pessoa(1, "MRS");
            Pessoa p2 = new Pessoa(2, "CMF");
            
            Utility.WriteTitle("Criar 1 pessoa com o 2º cunstructor e listar");

            p1.ListarPessoa();
            Console.ReadLine();
            p2.ListarPessoa();
            Console.ReadLine();

            #endregion

            #region Criar e usar uma List<> de Pessoa

            List<Pessoa> listaPessoas = new List<Pessoa>();

            listaPessoas.Add(p1);
            listaPessoas.Add(p2);

            Utility.TerminateConsole();

            // listar a lista

            Utility.WriteTitle("Criar e usar uma List<> de Pessoa");

            foreach (Pessoa item in listaPessoas)
            {
                item.ListarPessoa();
            }
            Utility.TerminateConsole();
            #endregion

            #region List<int>

            List<int> listaInteiros = new List<int>();

            listaInteiros.Add(1);
            listaInteiros.Add(2);
            // listaInteiros.Add("a");  ERRO não pode diferenciar o tipo de dados
            // listaInteiros.Add(1.5);  ERRO " " " " " " "

            #endregion
        }
    }
}
