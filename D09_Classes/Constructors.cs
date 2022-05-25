using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_Classes
{
    class Constructors
    {

        #region Fields: Variáveis privadas ás classes que suportam as propriedades clássicas

        private string nome;

        #endregion

        #region Properties

        // Propriedades auto-implementes
        public int ColaboradorID { get; set; }



        // Propriedades Clássicas
        public String Nome // usa-se o correspondente field
        {
            get { return nome; }
            set { nome = value; }
        }






        public string Email { get; set; }
        public string Localidade { get; set; }

        #endregion

        #region Constructors

        public Constructors()
        {
            ColaboradorID = 0;
            Nome = "";
            Email = string.Empty;
            Localidade = "";
        }

        public Constructors(int colaboradorID, string nome, string email, string localidade) // com os parametros obrigatórios
        {
            ColaboradorID = colaboradorID;
            Nome = nome;
            Email = email;
            Localidade = localidade;
        }


        public Constructors(int colaboradorID, string nome, string email) // com os parametros obrigatórios
        {
            ColaboradorID = colaboradorID;
            Nome = nome;
            Email = email;
            Localidade = "Porto";
        }


        #endregion

        #region menus

        #region 1º Construtor
        public static void ConstructorsCall()
        {

            Constructors constructors01 = new Constructors(); //usar o 1º construtor
            Utility.WriteTitle("1º Construtor");
            // sets
            constructors01.ColaboradorID = 1;
            constructors01.Nome = "Ana";
            constructors01.Email = "a@a,pt";
            constructors01.Localidade = "G";

            // gets
            Console.WriteLine(constructors01.ColaboradorID);
            Console.WriteLine(constructors01.Nome);
            Console.WriteLine(constructors01.Email);
            Console.WriteLine(constructors01.Localidade);

            #endregion
            Utility.WriteTitle("2º Construtor");
            #region 2º Construtor

            Constructors constructors02 = new Constructors(2, "Milena", "b@b.pt", "Lisboa");

            // gets
            Console.WriteLine(constructors02.ColaboradorID);
            Console.WriteLine(constructors02.Nome);
            Console.WriteLine(constructors02.Email);
            Console.WriteLine(constructors02.Localidade);


            #endregion
            Utility.WriteTitle("3º Construtor");
            #region 3º Construtor

            Constructors constructors03 = new Constructors(3, "César", "c@c.pt");

            // gets
            Console.WriteLine(constructors03.ColaboradorID);
            Console.WriteLine(constructors03.Nome);
            Console.WriteLine(constructors03.Email);
            Console.WriteLine(constructors03.Localidade);

            #endregion
            Utility.WriteTitle("4º Construtor");
            #region 4º Construtor

            Constructors constructors04 = new Constructors(4, "César", "c@c.pt");
            constructors04.Localidade = "Braga";

            // gets
            Console.WriteLine(constructors04.ColaboradorID);
            Console.WriteLine(constructors04.Nome);
            Console.WriteLine(constructors04.Email);
            Console.WriteLine(constructors04.Localidade);

            #endregion

            Utility.TerminateConsole();

            #endregion
        }
    }
}
