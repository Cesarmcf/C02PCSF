using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_Colecao_ArrayList
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



    }

    // *************** DERIVED CLASS **************
    class Funcionario : Pessoa // Herança Inheritance  ( herda tudo o que está na class pessoa Id e nome .......)
    {
        #region Propriedades

        public string Departamento { get; set; }

        #endregion

        #region Constructors

        //  Mapear od construtores desta classe para os construtores da sua base class
        public Funcionario() : base()
        {
            // fica vazio para herdar do base class, se colocar aqui Departamento = stringEmpty; significa que sempre que criar o funcionário é obrigatorio o departamento
        }

        public Funcionario(int id, string nome, string departamento) : base (id, nome)
        {

            Departamento = departamento;

        }

        #endregion



    }





}


