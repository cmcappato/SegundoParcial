using Logica.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Database
{
    public class JardinDB : ConexionSQL
    {
        static string pathApp;
        static List<Docente> listaDocentes;
        static Docente docente;

        #region Alumnos

        public static void GuardarAlumnoAprobado()
        {
            pathApp = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\APROBADOS\"
                                            + Alumno.AlumnoEvaluado() + ".xml";

            try
            {
                using (StreamWriter sw = new StreamWriter(pathApp, true, Encoding.Unicode))
                {
                    Evaluaciones.MostrarDatos();
                }

                Connection.Open();
                Command.CommandText = "INSERT INTO [Evaluaciones] ([idAlumno], [idDocente], [idAula], [Nota_1], [Nota_2], [NotaFinal], [Observaciones]) SELECT (idAlumnos)" +
                    " FROM ";


                Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }




        /// <summary>
        /// Generará un archivo XML con los datos del alumno desaprobado en la ruta:
        /// \SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS\
        /// </summary>
        public static void GuardarAlumnoDesaprobado()
        {
            pathApp = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Serializaciones\DESAPROBADOS\"
                                            + Alumno.AlumnoEvaluado() + ".xml");

            try
            {
                using (StreamWriter sw = new StreamWriter(pathApp, true, Encoding.Unicode))
                {
                    Evaluaciones.MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Docentes

        /// <summary>
        /// Cargará la lista de docentes en la base de datos luego de deserializar el XML
        /// Primero validará si la lista de docentes está cargada, 
        /// si es asi borra los datos de la tabla para evitar que se dupliquen y se insertarán los datos
        /// </summary>
        public static void CargarDocentes()
        {
            if (listaDocentes != null)
            {
                try
                {
                    Command.Connection = Connection;
                    Command.CommandText = "TRUNCATE TABLE [dbo].[Docentes]"; //Borro los datos de los docentes para evitar duplicados
                    Ejecutar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                foreach (Docente docente in listaDocentes) //Por cada docente en la lista inserto un docente
                {
                    try
                    {
                        Command.Connection = Connection;
                        Command.Parameters.Clear();
                        Command.CommandText = "INSERT INTO [dbo].[Docentes] (Nombre, Apellido, Edad, Sexo, Dni, Direccion, Email) VALUES (@Nombre, @Apellido, @Edad, @Sexo, @Dni, @Direccion, @Email)";
                        Ejecutar();

                        Command.Parameters.Add(new SqlParameter("Nombre", docente.Nombre));
                        Command.Parameters.Add(new SqlParameter("Apellido", docente.Apellido));
                        Command.Parameters.Add(new SqlParameter("Edad", docente.Edad));
                        Command.Parameters.Add(new SqlParameter("Sexo", docente.Sexo));
                        Command.Parameters.Add(new SqlParameter("Dni", docente.Dni));
                        Command.Parameters.Add(new SqlParameter("Direccion", docente.Direccion));
                        Command.Parameters.Add(new SqlParameter("Email", docente.Email));

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        #endregion
    }
}
