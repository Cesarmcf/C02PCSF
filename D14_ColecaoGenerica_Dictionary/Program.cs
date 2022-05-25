using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;


namespace D14_ColecaoGenerica_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary --> par chave / valor
            #region Dictionary<t>
            // instanciar e atribuit
            Dictionary<string, string> dicionarioString = new Dictionary<string, string>()
            {
                {"PT", "Portugal" },    // par chave (key) / valor (value)
                {"BR", "Brazil" },
                {"ES", "Espanha" }
            };

            // adicionar um
            dicionarioString.Add("IT", "Itália");

            // listar a colecção
            ListarDicionario(dicionarioString);


            //pesquisar uma chave e se não existir, inserir uma linha
            // o ideal era usar LINQ

            if (!dicionarioString.ContainsKey("FR"))
            {
                dicionarioString.Add("FR", "França");
                dicionarioString.Add("FR2", "Franca");
                dicionarioString.Add("FR3", "Franssa");
            }


            // listar a colecção
            ListarDicionario(dicionarioString);

            // inserir um pais lido na consola ( no minimo tem de ter 2 carateres ) e não pode existir

            string novoValor, novaChave;
            int contagemchave;

            Console.WriteLine("Novo Pais ( no minimo 2 carateres).");
            novoValor = Console.ReadLine();


            if (novoValor.Length < 2 )
            {
                Console.WriteLine("No minimo tem de ter 2 carateres.");
            }
            else if (!dicionarioString.ContainsValue(novoValor))
            {
                Console.WriteLine("Valor duplicado.");
            }
            else
            {
                // Adicionar o novo pais
                
                // 1º gerar a nova chave: os dois primeiros carateres do novo valor em maiusculas
                novaChave = novoValor.Substring(0, 2).ToUpper();

                // 2º procurar a nova chave com LINQ ( usa lambda operatoe =>)
                contagemchave = dicionarioString.Count(p => p.Key.Contains(novaChave));

                if (contagemchave == 0)
                {
                    dicionarioString.Add(novaChave, novoValor);
                }
                else
                {
                    dicionarioString.Add($"{novaChave}{contagemchave + 1}", novoValor);
                }

                // listar a colecção
                ListarDicionario(dicionarioString);
            }

            

            //pesquisar um valor 


            #endregion
        }

        static void ListarDicionario(Dictionary<string, string> listaPaises)
        {
            Utility.WriteTitle("Dicionario --> par / valor");
            
            // Para ler o conteúdo do dictionary, aceder a KeyValeuPair<string, string>
            foreach (KeyValuePair<string, string> item in listaPaises)
            {
                            
                Console.WriteLine($"Key: {item.Key} \t Valor: {item.Value}");
            
            }

            Utility.TerminateConsole();

        }
    }
}
