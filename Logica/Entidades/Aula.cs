using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Entidades
{
    public class Aula
    {
        #region Campos

        private int idAula;
        private string salita;

        #endregion

        #region Propiedades

        public int IdAula
        {
            get { return idAula; }
            set { idAula = value; }
        }

        public string Salita
        {
            get { return salita; }
            set { salita = value; }
        } 

        #endregion
    }
}
