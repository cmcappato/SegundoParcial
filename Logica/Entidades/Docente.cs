using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Entidades
{

    [Serializable]
    public class Docente
    {
        #region Campos

        private string nombre;
        private string apellido;
        private decimal edad;
        private decimal dni;
        private string direccion;
        private decimal id;
        private string sexo;
        private string email;

        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
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
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public decimal Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        #endregion

        #region Constructores

        public Docente()
        {

        }

        public Docente(decimal id, string apellido, string nombre, decimal edad, decimal dni, string sexo, string email, string direccion) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.email = email;
            this.direccion = direccion;
            this.id = id;
        }

        #endregion
    }
}
