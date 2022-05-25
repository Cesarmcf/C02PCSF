using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_NomeCompletoV01
{
    public class Funcionario
    {

        // nesta versão é fazer o exercício normalmente
        // numa segunda versão deve validar com if se a variavel tem valor, caso não tenha não concatena


        #region Properties

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }


        #endregion

        #region Constructors
        public Funcionario()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
        }
        #endregion

        #region Methods

        public void ReadNames()
        {
            Console.WriteLine("Insert your first name:");
            FirstName = Console.ReadLine();

            Console.WriteLine("Insert your middle name:");
            MiddleName = Console.ReadLine();

            Console.WriteLine("Insert your last name:");
            LastName = Console.ReadLine();

        }

        public void JoinNames()
        {

            if (FirstName == "" && MiddleName == "" && LastName == "")
                {

                FullName = "";

                }
            else if (FirstName == "" && MiddleName != "" && LastName != "")
                {

                FullName = ($"{MiddleName} {LastName}");

                }
            else if (MiddleName == "" && FirstName != "" && LastName != "")
                {

                FullName = ($"{FirstName} {LastName}");
                
                }
            else if (LastName == "" && FirstName != "" && MiddleName != "")
                {

                FullName = ($"{FirstName} {MiddleName}");

                }
            else if (FirstName == "" && MiddleName == "" && LastName != "")
                {

                FullName = LastName;

                }
            else if (LastName == "" && MiddleName == "" && FirstName != "")
                {

                FullName = FirstName;

                }
            else if (FirstName == "" && LastName == "" && MiddleName != "")
                {

                FullName = MiddleName;

                }
            else if (FirstName != "" && MiddleName != "" && LastName != "")
                {

                FullName = ($"{FirstName} {MiddleName} {LastName}");

                }
            //  FullName = FullName.Trim();      retirar espaços

        }

        public void CreateFullName()
        {
            if (!string.IsNullOrEmpty(FirstName))  // += incrementa á variavel o valor
            {
                FullName += $"{FirstName} ";
            }

            if (!string.IsNullOrEmpty(MiddleName))
            {
                FullName += $"{MiddleName} ";
            }

            if (!string.IsNullOrEmpty(LastName))
            {
                FullName += $"{LastName}";
            }
        }

        public void ShowFullName()
        {

            if (FullName == "")
            {

                Console.WriteLine("You dont have a name !!!");

            }
            else
            {

                Console.WriteLine($"\nYour full name is: {FullName}");

            }

        }
        #endregion
    }
}
