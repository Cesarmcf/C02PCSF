using System;
using D00_Utility;

namespace D09_Classes
{

    class Methods
    {

        #region Procedimento: método void (não devolve valor)
        public static void Procedure()
        {

            Console.WriteLine("Procedimento: método void, que não devolve valor.");
            Console.WriteLine("\n\n");

        }
        #endregion

        #region Função: método não void (devolve valor)
        public static string Function()
        {

            return "Função: método não void, que devolve valor.";

        }
        #endregion

        #region Método com argumento obrigatório
        public static void MethodWithMandatoryArgument(string message01, string message02)
        {

            Console.WriteLine($"Mensagem 01: {message01}");
            Console.WriteLine($"Mensagem 02: {message02}");
            Console.WriteLine("\n\n");

        }
        #endregion

        #region Método com argumento opcional
        public static void MethodWithOptionalArgument(string message01, string message02 = "C#") // tem que se passar para o metodo o valor 1 o 2º é opcional, caso não passe assume c#
        {                                                                                        // os opcionais têm que ser inseridos sempre no fim

            Console.WriteLine($"Mensagem 01: {message01}");
            Console.WriteLine($"Mensagem 02: {message02}");
            Console.WriteLine("\n\n");

        }
        #endregion

        #region Método com argumento designado
        public static void MethodWithNamedArgument(string message01, string message02)
        {

            Console.WriteLine($"Mensagem 01: {message01}");
            Console.WriteLine($"Mensagem 02: {message02}");
            Console.WriteLine("\n\n");

        }
        #endregion

        #region Método com passagem por valor
        // Alterações a 'mensagem' não afetam o seu valor original
        public static void PassingValueToMethod(string message)
        {            

            message = "Mensagem alterada - por valor.";

        }        
        #endregion

        #region Método com passagem por referência
        // Alterações a 'mensagem' afetam o seu valor original
        public static void PassingReferenceToMethod(ref string message)
        {

            message = "Mensagem alterada - por referência.";

        }
        #endregion

        #region Método para chamar todos os outros métodos e que vai ser executado no Main()
        public static void MethodsCall()
        {

            Utility.WriteTitle("Procedure");
            Procedure();

            Utility.WriteTitle("Function");
            Console.WriteLine(Methods.Function() + "\n\n");

            Utility.WriteTitle("Method with mandatory argument");
            MethodWithMandatoryArgument("Microsoft", "C#");

            Utility.WriteTitle("Method with optional argument");
            MethodWithOptionalArgument("Microsoft");

            Utility.WriteTitle("Method with named argument");
            MethodWithNamedArgument(message02: "C#", message01: "Microsoft");

            Utility.WriteTitle("Passing value to method");
            string value = "Mensagem original.";
            Console.WriteLine($"Mensagem ANTES de mudar a variável: {value}");
            PassingValueToMethod(value);
            Console.WriteLine($"Mensagem DEPOIS de mudar a variável: {value}\n\n");

            Utility.WriteTitle("Passing reference to method");
            string reference = "Mensagem original.";
            Console.WriteLine($"Mensagem ANTES de mudar a variável: {reference}");
            PassingReferenceToMethod(ref reference);
            Console.WriteLine($"Mensagem DEPOIS de mudar a variável: {reference}\n\n");

            Utility.TerminateConsole();

        }
        #endregion

    }

}