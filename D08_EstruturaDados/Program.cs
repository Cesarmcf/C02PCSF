using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08_EstruturaDados
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Variáveis
            string nome01, nome02, nome03;

            nome01 = "Ana";
            nome02 = "Milena";
            nome03 = "Amélia";

            Console.WriteLine(nome01);
            Console.WriteLine(nome02);
            Console.WriteLine(nome03);

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region VETOR 1 - com dimensão inicial, declaração e atribuição separados

            //Verot com 2 elementos
            // 1º dimensionar
            string[] curso = new string[2];

            // 2º atribuir
            curso[0] = "T-SQL";
            curso[1] = "C#";
            //curso[2] = "Será??????"; //Dá erro ao executar

            // 3º manipular

            Console.WriteLine(curso[0]);
            Console.WriteLine(curso[1]);
            //Console.WriteLine(curso[2]);
            Console.WriteLine("------ FOR -------");
           
            for (int i = 0; i < curso.Length; i++) 
            {
                Console.WriteLine(curso[i]);
            }

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Vetor 2 - com dimensão inicial, declaração e atribuição de uma só vez

            string[] pessoa = new string[4]
            {
                "a",    //pessoa 0
                "b",    //pessoa 1
                "c",    //pessoa 2
                "d"     //pessoa 3
            };
            Console.WriteLine("---------------");


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(pessoa[i]);
            };
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Vetor 3 - sem conhecer a dimensão - com dimensão inicial, declaração e atribuição de uma só vez

            string[] localidade = new string[]
            {
                "Porto",
                "Guimarães",
                "Braga",
                "Gaia",
                "Lisboa"
            };

            string[] localidade1 = new string[] { "Porto", "Guimarães", "Braga", "Gaia", "Lisboa" };

            int[] valor = new int[] { 1, 2, 11, 22 };

            DateTime[] dataFatura = new DateTime[]
            {
                new DateTime(2022, 10, 10 ),
                new DateTime(2022, 10, 11 ),
                new DateTime(2022, 10, 12),
            };
            
            Console.WriteLine("---------------");


            for (int i = 0; i < localidade.Length; i++)
            {
                Console.WriteLine(localidade[i]);
            }
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region FOREACH para listar
            Console.WriteLine("------ FOREACH --------------");

            foreach (string item in localidade)
            {
                Console.WriteLine(item);
            }

            foreach (DateTime item in dataFatura)
            {
                Console.WriteLine(item);
            }

            foreach (int item in valor)
            { 
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region MATRIZ 1: com dimensão inicial

            //Dimensionar e atribuir de uma só vez
            // 6 elementos: 2 linhas x 3 colunas (nome, localidade, pais)
            string[,] clientes = new string[2, 3]
            {
                {
                    "Cliente 1",        // [0,0] nome
                    "Localidade 1",     // [0,1] localidade
                    "Pais 1"            // [0,2] pais
                },
                {
                    "Cliente 2",
                    "Localidade 2",
                    "Pais 2"
                }

            };


            //Dimensionar e atribuir separadamente

            string[,] produtos = new string[3, 2];

            produtos[0, 0] = "Carro";
            produtos[0, 1] = "Preto";
            produtos[1, 0] = "Rato";
            produtos[1, 1] = "Branco";
            produtos[2, 0] = "Secretária";
            produtos[2, 1] = "Castanho";


            // Dimensionar dinamicamente e atribuir de uma só vez

            string[,] formacoes = new string[,]
            {
                { 
                    "curso1",
                    "DB"
                },
                {
                    "curso2",
                    "LP"
                }

            };

            #endregion

            #region MATRIZ listar

            Console.WriteLine("-------- MATRIZ listar ------------");

            foreach (string cliente in clientes)
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("\n-------- MATRIZ listar ------------");

            foreach (string produto in produtos)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine("\n------- MATRIZ listar -------------");

            foreach (string formacao in formacoes)
            {
                Console.WriteLine(formacao);
            }

            

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region MATRIZ FORs para simular uma tabela

            //ERRADO *-*-*-*-*
            /*
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{clientes[i,0]}  {clientes[i,1]}");
            }
            */
            Console.WriteLine("---------- MATRIZ FORs para simular uma tabela ----------");
            for (int l = 0; l < clientes.GetLength(0); l++)    // getlength retira o conjunto de elementos da coluna
            {
                for (int c = 0; c < clientes.GetLength(1); c++)
                {
                    Console.Write($"{clientes[l, c]} \t");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
            Console.Clear();



            #endregion


        }
    }
}
