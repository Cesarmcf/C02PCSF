using System;

namespace D03_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Declarar variaveis

            #region 1. Declarar variáveis e instanciar objetos

            
            // Value types    Diz-se declarar variável 
            byte idade;
            bool inscrito;
            double altura;
            DateTime data;
            DateTime hora;
            DateTime agora;    //timestamp
            DateTime dataInscricao;
            DateTime dataAtual;
            DateTime dataVazia;

            // Reference types      Diz-se instanciar variável
            string nome;
            Curso curso01 = new Curso();        // variavel que é um objeto ( classe curso ), é instanciar
            Curso curso02 = new Curso();

            #endregion

            #region 2. Atribuir valores às variáveis e às propriedades da classe

            idade = 50;
            inscrito = false;
            altura = 1.6;

            data = new DateTime(2022, 12, 25);              // formas = overloads
            hora = new DateTime(2022, 05, 04, 20, 35, 0);
            agora = DateTime.Now;
            dataAtual = DateTime.Today;
            dataVazia = DateTime.MinValue;

            nome = "aaa";

            curso01.Nome = "C# Foundations";
            curso01.DataInicio = new DateTime(2022, 05, 03);

            curso02.CursoID = 2;
            curso02.NumeroHoras = 30;



            #endregion

            #region 3. Listar as variáveis e às propriedades da classe

            Console.WriteLine($"Byte: {idade}");
            Console.WriteLine($"Boolean: {inscrito}");
            Console.WriteLine($"Double: {altura}");

            Console.WriteLine($"\nDatetime - date: {data}");
            Console.WriteLine($"Datetime - short date: {data.ToShortDateString()}");
            Console.WriteLine($"Datetime - short date: {data.ToLongDateString()}");
            Console.WriteLine($"\nDatetime-  time: {hora}");
            Console.WriteLine($"Datetime - short time: {hora.ToShortTimeString()}");
            Console.WriteLine($"Datetime - long time: {hora.ToLongTimeString()}");
            Console.WriteLine($"Datetime - timestamp: {agora}");
            Console.WriteLine($"Datetime - today: {dataAtual}");
            Console.WriteLine($"Datetime - empty: {dataVazia}");

            Console.WriteLine($"\nString: {nome}");

            Console.WriteLine($"\nAno atual: {agora.Year}");
            Console.WriteLine($"Mês atual: {agora.Month}");
            Console.WriteLine($"Dia atual: {agora.Day}");
            Console.WriteLine($"\nHora atual: {agora.Hour}");
            Console.WriteLine($"Minuto atual: {agora.Minute}");
            Console.WriteLine($"Segundo atual: {agora.Second}");

            Console.WriteLine($"\nCurso1 - nome; {curso01.Nome}");
            Console.WriteLine($"Curso1 - data de inicio: {curso01.DataInicio.ToShortDateString()}");
            Console.WriteLine($"\nCurso2 - ID: {curso02.CursoID}");
            Console.WriteLine($"Curso2 - nº horas: {curso02.NumeroHoras}");

            #endregion


            Console.ReadLine();

        }
    }
}
