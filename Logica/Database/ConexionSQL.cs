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
    public abstract class ConexionSQL
    {        
        private static SqlConnection connection;
        private static SqlCommand command;

        protected static SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }

        protected static SqlCommand Command
        {
            get
            {
                return command;
            }
        }

        public ConexionSQL()
        {
            connection = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = JardinUtn; Integrated Security = True");
            command = new SqlCommand();
        }
                

        protected static void Ejecutar()
        {
            try
            {
                ConexionSQL.Connection.Open();
                ConexionSQL.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (ConexionSQL.Connection.State == System.Data.ConnectionState.Open)
                {
                    ConexionSQL.Connection.Close();
                }
            }
        }

    }
}
