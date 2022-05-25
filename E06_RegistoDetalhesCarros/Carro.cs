using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E06_RegistoDetalhesCarros
{
    internal class Carro
    {
        #region Variáveis
        
        int escolha1;
        

        #endregion


        #region Enums

        internal enum Marcas
        {
            Fiat,
            Audi,
            BMW,
            Bólide
        }
        internal enum Modelos
        {
            Tipo,
            Bravo,
            Brava,
            A5,
            A4,
            A3,
            X1,
            Z4,
            X7,
            NovoBólide
        }
        internal enum Cores
        {
            Branco,
            Preto,
            Azul,
            Cinza,
            Laranja
        }

        #endregion

        #region Properties

        internal Marcas? Marca { get; set; }
        internal Modelos? Modelo { get; set; }
        internal Cores? Cor { get; set; }

        internal string Matricula { get; set; }
        internal string Cilindrada { get; set; }
        internal int Velocidade { get; set; }
        internal DateTime DataRegisto { get; set; }

        #endregion

        #region Construtores


        internal Carro()
        {
            Marca = null;
            Modelo = null;
            Cor = null;
            Matricula = string.Empty;
            Cilindrada = string.Empty;
            Velocidade = 0;
            DataRegisto = DateTime.MinValue;
        }

        internal Carro(Cores cor, string matricula, int velocidade, DateTime dataregisto)
        {
            Marca = Marcas.Bólide;
            Modelo = Modelos.NovoBólide;
            Cor = cor;
            Matricula = matricula;
            Cilindrada = "1000";
            Velocidade = velocidade;
            DataRegisto = dataregisto;
        }

        internal Carro(Marcas marca, Modelos modelo, Cores cor, string matricula, string cilindrada, int velocidade, DateTime dataregisto)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Matricula = matricula;
            Cilindrada = cilindrada;
            Velocidade = velocidade;
            DataRegisto = dataregisto;
        }

        #endregion

        #region Destrutor
        // para ver a menssagem do destrutor, correr com Ctrl+F5
        ~Carro()
        {
            Console.WriteLine($"O carro com a matrícula {Matricula} vai para a sucata!!!");
        }

        #endregion


        #region Métodos
        internal void PedirDadosCarros()
        {


            Console.WriteLine("Insira a marca do carro segundo a seguinte lista:");
            foreach (Marcas marcas in Enum.GetValues(typeof(Marcas)))
            {
                Console.WriteLine($"{ (int)marcas} - { marcas}");

            }
            try
            {


                Marca = (Marcas?)Convert.ToInt16(Console.ReadLine());
                Console.Clear();

            }
            catch (System.FormatException)
            {

                Console.WriteLine("Insira apenas as opções do menu!");
            }

            Console.WriteLine("Insira o modelo do carro segundo a seguinte lista:");
            foreach (Modelos modelos in Enum.GetValues(typeof(Modelos)))
            {
                Console.WriteLine($"{ (int)modelos} - { modelos}");

            }
            try
            {
                Modelo = (Modelos?)Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Insira apenas as opções do menu!");
            }

            Console.WriteLine("Insira a cor do carro segundo a seguinte lista:");
            foreach (Cores cores in Enum.GetValues(typeof(Cores)))
            {
                Console.WriteLine($"{ (int)cores} - { cores}");

            }

            try
            {

                Cor = (Cores?)Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Insira apenas as opções do menu!");
            }

            Console.WriteLine("Insira a matricula do carro:");
            Matricula = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Insira a cilindrada do carro:");
            Cilindrada = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Insira a velocidade do carro:");
            try
            {
                Velocidade = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Formato errado, insira a velocidade!");
            }

            Console.WriteLine("Insira a data de registo do carro:");
            try
            {
                DataRegisto = Convert.ToDateTime(Console.ReadLine());
                Console.Clear();
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Insira uma data!");
            }
        }

        internal void MostrarCarros()
        {

            Console.WriteLine($"Carro com a Marca: {Marca}");
            Console.WriteLine($"Carro com a Modelo: {Modelo}");
            Console.WriteLine($"Carro com a Cor: {Cor}");
            Console.WriteLine($"Carro com a Matrícula: {Matricula}");
            Console.WriteLine($"Carro com a Cilindrada: {Cilindrada}");
            Console.WriteLine($"Carro com a Velocidade: {Velocidade}");
            Console.WriteLine($"Carro com a Data de Registo: {DataRegisto.ToShortDateString()}");
            Console.ReadLine();
        }

        internal void PararCarros()
        {
            Velocidade = 0;
            Console.WriteLine($"Carro com a Marca: {Marca}");
            Console.WriteLine($"Carro com a Modelo: {Modelo}");
            Console.WriteLine($"Carro com a Cor: {Cor}");
            Console.WriteLine($"Carro com a Matrícula: {Matricula}");
            Console.WriteLine($"Carro com a Cilindrada: {Cilindrada}");
            Console.WriteLine($"Carro com a Velocidade: {Velocidade}");
            Console.WriteLine($"Carro com a Data de Registo: {DataRegisto.ToShortDateString()}");
            Console.ReadLine();
        }

        internal void AcelararCarros()
        {
            
            Velocidade = Velocidade + 10;
            Console.WriteLine($"Carro com a Marca: {Marca}");
            Console.WriteLine($"Carro com a Modelo: {Modelo}");
            Console.WriteLine($"Carro com a Cor: {Cor}");
            Console.WriteLine($"Carro com a Matrícula: {Matricula}");
            Console.WriteLine($"Carro com a Cilindrada: {Cilindrada}");
            Console.WriteLine($"Carro com a Velocidade: {Velocidade}");
            Console.WriteLine($"Carro com a Data de Registo: {DataRegisto.ToShortDateString()}");
            Console.ReadLine();

        }


        internal void DesacelararCarros()
        {
            if (Velocidade > 0)
            {
                Velocidade = Velocidade + 10;
                Console.WriteLine($"Carro com a Marca: {Marca}");
                Console.WriteLine($"Carro com a Modelo: {Modelo}");
                Console.WriteLine($"Carro com a Cor: {Cor}");
                Console.WriteLine($"Carro com a Matrícula: {Matricula}");
                Console.WriteLine($"Carro com a Cilindrada: {Cilindrada}");
                Console.WriteLine($"Carro com a Velocidade: {Velocidade}");
                Console.WriteLine($"Carro com a Data de Registo: {DataRegisto.ToShortDateString()}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("O carro já está parado!");
            }
        }
        
        internal void MostrarMenuGeral()
        {
            Dictionary<int, string> dicionarioMenu = new Dictionary<int, string>()
            {
                {1, "Criar Carro" },
                {2, "Listar Carro" },
                {3, "Parar Carro" },
                {4, "Acelarar Carro em 10Km/h" },
                {5, "Desacelarar carro em 10Km/h" },
                {6, "Sair" }
            };

            foreach (KeyValuePair<int, string> item in dicionarioMenu)
            {
                Console.WriteLine("[{0}] - {1}", item.Key, item.Value);
            }
        }

        internal void LerMenuGeral()
        {

            Console.WriteLine("Escolha: ");

            try
            {
                escolha1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Escolha uma das opções do menu!");
            }


        }


        internal bool DecidirMenu()
        {

            switch (escolha1)
            {
                case 1:
                    PedirDadosCarros();
                    return true;
                case 2:
                    MostrarCarros();
                    return true;
                case 3:
                    PararCarros();
                    return true;
                case 4:
                    AcelararCarros();
                    return true;
                case 5:
                    DesacelararCarros();
                    return true;
                case 6:
                    return false;
                default:
                    Console.WriteLine("Escolha apenas uma das opções!");
                    return true;
            }



            /*
            while (escolha == false)
            {


                if (escolha1 == 1)
                {
                    PedirDadosCarros();
                    escolha = false;
                }
                else if (escolha1 == 2)
                {
                    MostrarCarros();
                    escolha = false;
                }
                else if (escolha1 == 3)
                {
                    PararCarros();
                    escolha = false;
                }
                else if (escolha1 == 4)
                {
                    AcelararCarros();
                    escolha = false;
                }
                else if (escolha1 == 5)
                {
                    DesacelararCarros();
                    escolha = false;
                }
                else if (escolha1 == 6)
                {
                    escolha = true;
                }
            }
            */
        }
        #endregion
    }

}
