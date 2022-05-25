using System;
using D00_Utility;


namespace E05_CalculadoraV04
{
    public class CalculadoraSimples
    {



        #region Properties

        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }
        public string Operacao { get; set; }

        #endregion



        #region Constructors

        public CalculadoraSimples()
        {
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
            Operacao = string.Empty;
        }


        public CalculadoraSimples(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            Resultado = 0;
            Operacao = string.Empty;
        }

        public CalculadoraSimples(double numero1, double numero2, string operador)
        {
            Numero1 = numero1;
            Numero2 = numero2;
            Resultado = 0;
            Operacao = operador;
        }


        #endregion

        #region Methods


        public void MostrarMenu()
        {
            #region Variáveis

            // variáveis para o menu
            // 1º dimensionar
            string[,] menu = new string[5, 2];

            // 2º atribuir

            menu[0, 0] = "1";
            menu[0, 1] = "Somar";
            menu[1, 0] = "2";
            menu[1, 1] = "Subtrair";
            menu[2, 0] = "3";
            menu[2, 1] = "Multiplicar";
            menu[3, 0] = "4";
            menu[3, 1] = "Dividir";

            menu[4, 0] = "x";
            menu[4, 1] = "Sair";
            string escolha = string.Empty;

            #endregion


            for (int l = 0; l < menu.GetLength(0); l++)    // getlength retira o conjunto de elementos da coluna
            {
                for (int c = 0; c < menu.GetLength(1); c++)
                {
                    Console.Write($"{menu[l, c]} \t");
                }
                Console.WriteLine();
            }


            /*
            while (escolha != "x")
            {

                Console.WriteLine("Escolhe uma operação, para sair escreve X ");

                for (int l = 0; l < menu.GetLength(0); l++)    // getlength retira o conjunto de elementos da coluna
                {
                    for (int c = 0; c < menu.GetLength(1); c++)
                    {
                        Console.Write($"{menu[l, c]} \t");
                    }
                    Console.WriteLine();
                }


                escolha = Console.ReadLine();

                CalculadoraSimples calc3 = new CalculadoraSimples();

                switch (escolha)
                {
                    case "1":
                        calc3.LerDados();
                        calc3.Somar();
                        calc3.ApresentarDados();
                        break;

                    case "2":
                        calc3.LerDados();
                        calc3.Subtrair();
                        calc3.ApresentarDados();
                        break;

                    case "3":
                        calc3.LerDados();
                        calc3.Multiplicar();
                        calc3.ApresentarDados();
                        break;

                    case "4":
                        calc3.LerDados();
                        calc3.Dividir();
                        calc3.ApresentarDados();
                        break;

                    case "x":
                        Console.WriteLine("Obrigado por usar a CalculadoraSimples!!!");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha uma das opções novamente!!!");
                        break;
                }
                */


            /*
            if (escolha == "1")
            {
                CalculadoraSimples calc3 = new CalculadoraSimples();

                calc3.LerDados();
                calc3.Somar();
                calc3.ApresentarDados();
            }
            else if (escolha == "2")
            {
                CalculadoraSimples calc3 = new CalculadoraSimples();

                calc3.LerDados();
                calc3.Subtrair();
                calc3.ApresentarDados();
            }
            else if (escolha == "3")
            {
                CalculadoraSimples calc3 = new CalculadoraSimples();

                calc3.LerDados();
                calc3.Multiplicar();
                calc3.ApresentarDados();
            }
            else if (escolha == "4")
            {
                CalculadoraSimples calc3 = new CalculadoraSimples();

                calc3.LerDados();
                calc3.Dividir();
                calc3.ApresentarDados();
            }
            else if (escolha != "x" || escolha != "1" || escolha != "2" || escolha != "3" || escolha != "4")
            {
                Console.WriteLine("Escolha uma das opções novamente!!!");
            }
            */
        }
        

        public void LerOperacao()
        {

        Console.WriteLine("Operação: ");
        Operacao = Console.ReadLine();
        }

        public bool ValidarOperacao()
        {
            bool validado;

            switch (Operacao)
            {
                case "1":
                    validado = true;
                    break;
                case "2":
                    validado = true;
                    break;
                case "3":
                    validado = true;
                    break;
                case "4":
                    validado = true;
                    break;
                default:
                    validado = false;
                    break;
            }
                return validado;
            
        }

        public void Decisoes()
        {
            if (Operacao == "1")
            {
                Somar();
            }
            else if (Operacao == "2")
            {
                Subtrair();
            }
            else if (Operacao == "3")
            {
                Multiplicar();
            }
            else if (Operacao == "4") 
            {
                Dividir();
            }

        }

        public void LerDados()
        {

            //variáveis que irão conter os números digitados

           
            Console.WriteLine("Digite o primeiro número: ");
            Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Numero2 = Convert.ToDouble(Console.ReadLine());

        }



        public void Somar()
        {


            //efectua a soma e lista na consola
            Resultado = Numero1 + Numero2;
            Operacao = "+";
            
            //Console.WriteLine($"Valor da Soma = {resultado}");
            
        }




        public void Subtrair()
        {

            
            //efectua a subtração e lista na consola
            Resultado = Numero1 - Numero2;
            Operacao = "-";

            //Console.WriteLine($"Valor da Subtração = {resultado}");

        }




        public void Multiplicar()
        {
            //efectua a multiplicação e lista na consola
            Resultado = Numero1 * Numero2;
            Operacao = "*";

            //Console.WriteLine($"Valor da Multiplicação = {resultado}");

        }




        public void Dividir()
        {
            //efectua a divisão e lista na consola
            Resultado = Numero1 / Numero2;
            Operacao = "/";

            //Console.WriteLine($"Valor da Divisão = {resultado}");

        }



        public void ApresentarDados()
        {
            Console.WriteLine($"\n{Numero1} {Operacao} {Numero2} = {Resultado}");
            Console.ReadLine();

        }

        #endregion
       
    }
}
