using Logica.Database;
using Logica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FrmAlumnosEvaluados : Form
    {
        

        public FrmAlumnosEvaluados()
        {
            InitializeComponent();
            Serializacion.Deserializar();
        }

        private void FrmAlumnosEvaluados_Load(object sender, EventArgs e)
        {

        }

        private void AgregarALista(Alumno alumno)
        {
            if(lstAlumnosEvaluados.InvokeRequired)
            {
                lstAlumnosEvaluados.BeginInvoke((MethodInvoker)delegate() {
                    lstAlumnosEvaluados.DataSource = null;
                    //lstAlumnosEvaluados.DataSource = alumno;
                });
            }

        }

    }
}
