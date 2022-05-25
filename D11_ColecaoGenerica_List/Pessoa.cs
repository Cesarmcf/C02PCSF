using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_ColecaoGenerica_List
{


    // ************* BASE CLASS ***************
    class Pessoa
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }


        #endregion

        #region Constructor
        public Pessoa()
        {
            Id = 0;     
            Nome = string.Empty;

        }

        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }

        #endregion


        public void ListarPessoa()
        {
            Console.WriteLine($"Pessoa: {Id} - {Nome} ");
        }


    }






}