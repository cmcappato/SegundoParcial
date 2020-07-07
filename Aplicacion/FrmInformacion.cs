using Logica.Database;
using Logica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FrmInformacion : Form
    {
        public Queue<Alumno> colaAlumnos;
        public List<Alumno> alumnos;
        FrmAlumnosEvaluados frmAlumnosEvaluados;

        public Thread hiloRecreo;
        public delegate void DelegadoLlamarARecreo(object o);
        public event DelegadoLlamarARecreo LlamarAlRecreo;

        public Thread hiloEvaluar;
        public delegate void DelegadoInsertarAlumno(object alumno);
        public event DelegadoInsertarAlumno InsertarAlumno;

        public FrmInformacion()
        {
            InitializeComponent();
            CargarAlumnosSinEvaluar();
            lblRecreo.Text = string.Empty;
            colaAlumnos = new Queue<Alumno>();
            alumnos = new List<Alumno>();
            

            hiloRecreo = new Thread(new ParameterizedThreadStart(Recreo));
            LlamarAlRecreo += Recreo;
            //hiloEvaluar = new Thread(new ParameterizedThreadStart(EvaluarAlumno));
            //InsertarAlumno += EvaluarAlumno;

            FrmAlumnosEvaluados frmAlumnosEvaluados = new FrmAlumnosEvaluados();
            frmAlumnosEvaluados.Show();
        }

        //private void EvaluarAlumno(object alumno)
        //{
        //    Thread.Sleep(8000);

        //    alumnos.Add((Alumno)alumno);

        //    frmAlumnosEvaluados.Agreg
        //}

        private void Recreo(object objeto)
        {
            Label label = (Label)objeto;

            while (true)
            {
                Thread.Sleep(20000);
                if (label.InvokeRequired)
                {
                    label.BeginInvoke((MethodInvoker)delegate () {
                        label.Text = "ALUMNOS EN RECREO";
                    });
                }

                Thread.Sleep(5000);
                if (label.InvokeRequired)
                {                    
                    label.BeginInvoke((MethodInvoker)delegate () {
                        label.Text = String.Empty;
                    });
                }
            }
        }



        #region Iniciar hilos

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            //if (!hiloEvaluar.IsAlive)
            //{
            //    hiloEvaluar.Start();
            //}

            if (!hiloRecreo.IsAlive)
            {
                hiloRecreo.Start(lblRecreo);
            }
        } 
        #endregion


        private void FrmInformacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hiloEvaluar.IsAlive)
            {
                hiloEvaluar.Abort();
            }

            if (hiloRecreo.IsAlive)
            {
                hiloRecreo.Abort();
            }
        }


        private void CargarAlumnosSinEvaluar()
        {
            colaAlumnos = new Queue<Alumno>();
            SqlConnection connection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.ConnectionString = @"Data Source = CARO\SQLEXPRESS; Initial Catalog = JardinUtn; Integrated Security = True";
            try
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "SELECT Apellido, Nombre FROM [Alumnos]";
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    string apellido = dr["apellido"].ToString();
                    string nombre = dr["nombre"].ToString();
                    Alumno alumno = new Alumno(apellido,nombre);
                    colaAlumnos.Enqueue(alumno);
                }

                lstAlumnosSinEvaluar.DataSource = colaAlumnos;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Seleccionara un docente al azar para que evalue al alumno.
        /// Si la nota es mayor o igual a 6 el alumno está aprobado, si es menor a 6 está desaprobado
        /// </summary>
        public static void EvaluarAlumno()
        {
            Random notaRandom = new Random();
            Random docenteQueEvaluara = new Random();

            Evaluaciones.Nota_1 = notaRandom.Next(1, 10);
            Evaluaciones.Nota_2 = notaRandom.Next(1, 10);
            docenteQueEvaluara.Next(1, 10);

            Evaluaciones.NotaFinal = (Evaluaciones.Nota_1 + Evaluaciones.Nota_2) / 2;

            if (Evaluaciones.NotaFinal >= 6)
            {
                JardinDB.GuardarAlumnoAprobado();
            }
            else
            {
                JardinDB.GuardarAlumnoDesaprobado();
            }

        }


    }
}
