using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Entidades
{
    [Serializable]
    public class Evaluaciones
    {
        #region Campos

        private decimal idEvaluacion;
        private decimal idAlumno;
        private decimal idDocente;
        private static decimal nota1;
        private static decimal nota2;
        private static decimal notaFinal;
        private string observaciones;

        #endregion

        #region Propiedades

        public decimal IdEvaluacion
        {
            get { return idEvaluacion; }
            set { idEvaluacion = value; }
        }

        public decimal IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public decimal IdDocente
        {
            get { return idDocente; }
            set { idDocente = value; }
        }

        public static decimal Nota_1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public static decimal Nota_2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public static decimal NotaFinal
        {
            get { return notaFinal; }
            set { notaFinal = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        #endregion

        #region Constructor

        public Evaluaciones()
        {

        }

        #endregion

        #region Métodos

        /// <summary>
        /// Muestra los datos del alumno
        /// </summary>
        /// <returns></returns>
        public static string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre del alumno: " + Alumno.Nombre);
            sb.AppendLine("Apellido del alumno: " + Alumno.Apellido);
            sb.AppendFormat("Nota 1: {0} \n Nota 2: {1}: ", nota1, nota2);
            sb.AppendLine("Nota final: " + notaFinal);
            sb.AppendLine("Fecha de evaluacion: " + DateTime.Now.ToString("dd-MM-yyyy"));
            sb.AppendLine("-----------------------------------------------------------");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Evaluaciones.MostrarDatos();
        }

        #endregion
    }
}
