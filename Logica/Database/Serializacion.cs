using Logica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Logica.Database
{
    public class Serializacion
    {
        static XmlTextReader textReader;
        static XmlSerializer xmlSerializer;
        static List<Docente> listaDocentes;
        static Docente docente;

        public static void Deserializar()
        {
            string pathApp = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml");

            try
            {
                using (textReader = new XmlTextReader(pathApp))
                {
                    xmlSerializer = new XmlSerializer(typeof(List<Docente>));
                    listaDocentes = (List<Docente>)xmlSerializer.Deserialize(textReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                textReader.Close();
            }
        }
    }
}
