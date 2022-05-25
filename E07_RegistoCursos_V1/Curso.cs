using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E07_RegistoCursos_V1
{
    //Classe para ser usada somente na mesma assembly
    internal class Curso
    {
        #region Variáveis
        // Variável para uso interno da classe
        private int duracaoHoras;
        
        // Variável da classe ou dericadas, com valor 10
        protected int numeroMedioSessoes = 10;

        // Variável para ter uma coleção de valores
        internal static List<Curso> listaCursos = new List<Curso>();

       
        #endregion

        #region Atributos

        // Atributo de suporte à propriedade clássica NomeCurso ( tudo que é atributo tem que ser private)
        private string nomeCurso;

        #endregion

        #region Propriedades

        // Propriedade clássica
        internal string NomeCurso
        {
            get { return nomeCurso; }
            set { nomeCurso = value; }
        }

        // Propriedades automáticas
        internal int CursoID { get; set; }
        internal int NumeroSessoes { get; set; }
        internal int NumeroHorasPorSessao { get; set; }


        #endregion

        #region Construtores

        internal Curso()
        {
            NomeCurso = string.Empty;
            CursoID = 0;
            NumeroSessoes = 0;
            NumeroHorasPorSessao = 0;
        }

        internal Curso(string nomeCurso, int cursoID, int numeroSessoes, int numeroHorasPorSessao)
        {
            NomeCurso = nomeCurso;
            CursoID = cursoID;
            NumeroSessoes = numeroSessoes;
            NumeroHorasPorSessao = numeroHorasPorSessao;
        }


        #endregion



        // Métodos privados à classe

        #region Método para calcular a duração total de horas, guardar na respetiva variável e devolver: CalcularNumeroHoras

        private int CalcularNumeroHoras()
        {
            duracaoHoras = NumeroHorasPorSessao * NumeroSessoes;
            return duracaoHoras;

        }

        #endregion

        #region Método para transformar e devolver o nome do curso em maiúsculas: TransformarNomeCursoMaiusculas
        private string TransformarNomeCursoMaiusculas(string nomeCurso) //aproveita-se o atributo, manipula-se e devolve-se o mesmo
        {
            return nomeCurso.ToUpper();                                 // não se deve usar a propriedade porque a mesma já tem valor
        }
    #endregion

    // Métodos da classe ou derivadas

        #region Método de instância void que pede os valores ao user, guarda nas propriedades e adiciona à lista: InserirCurso

       
        protected internal void InserirCurso()
        {
            #region Variáveis
            bool resultado; // int.TryParse()
            int varCursoID, varNumeroSessoes, varNumeroHorasPorSessao, varNumeroTotalHoras; // Suporte aos out parameters
            string varNomeCurso;
            StringBuilder curso = new StringBuilder();
            #endregion

            #region CursoID
            Console.WriteLine("Nº do curso: ");
            // Os output parameters não podem ser atribuidos diretamente às propriedades
            resultado = int.TryParse(Console.ReadLine(), out varCursoID);
            varCursoID = ValidarCursoID(resultado, varCursoID);
            CursoID = varCursoID;
            #endregion

            #region NomeCurso
            Console.Write("Nome do curso: ");
            varNomeCurso = Console.ReadLine();
            varNomeCurso = ValidarNomeCurso(varNomeCurso);
            NomeCurso = TransformarNomeCursoMaiusculas(varNomeCurso);
            #endregion

            #region NumeroSessoes
            Console.WriteLine("Nº de sessões: ");
            resultado = true; // resetar!
            resultado = int.TryParse(Console.ReadLine(), out varNumeroSessoes);
            varNumeroSessoes = ValidarNumeroSessoes(resultado, varNumeroSessoes);
            NumeroSessoes = varNumeroSessoes;
            #endregion

            #region NumeroHorasPorSessão
            Console.WriteLine("Nº de horas p/ sessão: ");
            resultado = true;
            resultado = int.TryParse(Console.ReadLine(), out varNumeroHorasPorSessao);
            varNumeroHorasPorSessao = ValidarNumeroHorasPorSessoes(resultado, varNumeroHorasPorSessao);
            NumeroHorasPorSessao = varNumeroHorasPorSessao;
            #endregion

            #region NumeroTotalHoras  // calculado
            varNumeroTotalHoras = CalcularNumeroHoras();
            #endregion

            #region Construir o curso como será listado
            curso.Append($"Nº curso: {CursoID} \n");
            curso.Append($"Nome do curso: {NomeCurso} \n");
            curso.Append($"Nº de sessões: {NumeroSessoes} \n");
            curso.Append($"Nº de horas: {NumeroHorasPorSessao} \n");
            curso.Append($"Nº total de horas: {varNumeroTotalHoras} \n");   // uso da variavel através do StringBuilder
            #endregion

            #region Adicionar curso à lista
            listaCursos.Add(this); // Keyword this refere-se ao próprio objeto
            #endregion

        }


        #endregion

        #region Metodo para validar a inserção do cursoID


        protected internal int ValidarCursoID(bool resultado, int varCursoID)
        {
            if (!resultado)
            {
                varCursoID = 1;
            }
            
            return varCursoID;
        }
        #endregion

        #region Metodo para validar a inserção do nome do curso
        protected internal string ValidarNomeCurso(string varNomeCurso)
        {
            if (varNomeCurso == string.Empty)
            {
                varNomeCurso = "Novo Curso";
            }
            
            return varNomeCurso;
        }
        #endregion


        #region Metodo para validar a inserção do nº de sessões
        protected internal int ValidarNumeroSessoes(bool resultado, int varNumeroSessoes)
        {
            if (!resultado)
            {
                varNumeroSessoes = 1;
            }

            return varNumeroSessoes;
        }
        #endregion

        #region Metodo para validar a inserção por nº de horas p/ sessão
        protected internal int ValidarNumeroHorasPorSessoes(bool resultado, int varNumeroHorasPorSessao)
        {
            if (!resultado)
            {
                varNumeroHorasPorSessao = 3;
            }

            return varNumeroHorasPorSessao;
        }
        #endregion

        #region teste linq

        protected internal static void CalcularTotalHorasCursos()
        {
            System.Nullable<int> tot = (from curso in listaCursos
                                        where curso.duracaoHoras != 0
                                        select curso.duracaoHoras).Sum();


            Utility.WriteTitle("Total de Horas");
            Console.WriteLine("Total de de horas dos cursos: {0}",tot);

        }
        #endregion


        #region Método estático void que recebe a lista de cursos e mostra no ecrã: ListarCurso

        protected internal static void ListarCurso(List<Curso> listaCursos)
        {
            
            foreach (var item in listaCursos)
            {
                Utility.WriteTitle($"Curso {item.NomeCurso}");

                Console.WriteLine("Nº do curso: {0} \nNº de sessões: {1} \nNº de horas por sessão: {2} \nTotal de horas: {3}", item.CursoID, item.NumeroSessoes, item.NumeroHorasPorSessao, item.duracaoHoras);

            }

        }
    
    #endregion
    }
}
