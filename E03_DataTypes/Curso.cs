using System;

namespace D03_DataTypes
{
    class Curso
    {
        // Class elements: constructors, methods, properties, events 

        #region Fields (devem ser privados)

        private String nome;


        #endregion


        #region Properties (devem ser públicas): auto-implemented

        public int CursoID { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double NumeroHoras { get; set; }

        #endregion



    }
}
