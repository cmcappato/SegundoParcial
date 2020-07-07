using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Entidades
{
    public class Alumno
    {
        #region Campos

        private decimal idAlumno;
        private static string apellido;
        private static string nombre;
        private decimal edad;
        private string sexo;
        private decimal dni;
        private string direccion;
        private string responsable;

        #endregion

        #region Propiedades

        public decimal IdAlumnos
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public static string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public static string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public decimal Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        #endregion

        #region Constructores
        
        public Alumno()
        {

        }

        public Alumno(string apellido, string nombre) : this()
        {
            Apellido = apellido;
            Nombre = nombre;
        }


        public Alumno(decimal idAlumnos, string apellido, string nombre, decimal edad, string sexo, decimal dni, string direccion, string responsable) : this(apellido,nombre)
        {
            IdAlumnos = idAlumnos;
            Edad = edad;
            Sexo = sexo;
            Dni = dni;
            Direccion = direccion;
            Responsable = responsable;
        }

        #endregion

        #region Métodos

        public static string AlumnoEvaluado()
        {
            return Apellido + "_" + Nombre + "_" + DateTime.Now.ToString("dd_MM_yyyy");
        }

        public static string NombreProximoAlumno()
        {
            return Nombre + " " + Apellido;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Dos alumnos serán iguales si tienen el mismo dni
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return a1.Dni == a2.Dni;
        }

        /// <summary>
        /// Dos alumnos serán distintos si el dni es distinto
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        #endregion


        
    }
}
