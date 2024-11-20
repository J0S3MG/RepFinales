using Final1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Alumnado a = new Alumnado();//Me aseguro que exista.
        string path = Application.StartupPath + "\\Facultad.dat";//creo la ruta para la percistencia.
        #region Procesamos el boton Seleccion
        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            #region Datos para el Archivo de Excepciones
            FileStream fs = null;
            StreamWriter sw = null;
            #endregion
            string dni = txtDNI.Text;
            string legajo = txtLegajo.Text;
            try
            {
                #region Datos levantados
                string nom = txtNombre.Text;
                string esp = txtAreaEspecializacion.Text;
                int idx = lbxCursos.SelectedIndex;
                #endregion
                if (rbnDocente.Checked)//Chequeo que hagan click en el Docente.
                {   //Si hace click creo el curso con los datos del docente.
                    Curso c = a.CrearCurso(dni, nom, esp);
                    lbxCursos.Items.Add(c);//Lo agrego al lisbox.
                }
                else if (rbnAlumno.Checked)//Chequeo que hagan click en el Alumno. 
                {   //Si se cumple agrego el alumno al curso que seleccione.
                    a.AgregarAlumno(dni, nom, legajo, idx);
                    Curso c = a[idx];//Muestro el curso al que se inscribio.
                    MessageBox.Show("Se inscribio a: "+c.VerEsp());
                }

            }
            catch (NoNumeroException n)//Cacho la excepcion personalizada.
            {
                MessageBox.Show(n.Message);//Hago la exportacion segun me lo pide el ejercicio.
                fs = new FileStream("Excepciones.csv",FileMode.OpenOrCreate,FileAccess.Write);
                sw = new StreamWriter(fs);//Cada que ocurra una excepcion guardo los datos de la misma en el archivo.
                string valormalo = a.ValorMalo(dni,legajo);//Me sirve para saber que dato genero la excepcion.
                sw.WriteLine($"{n};{valormalo}");
            }
            finally//Cierro los recursos.
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
          
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    a = bf.Deserialize(fs) as Alumnado;
                }
                finally
                {
                    if(fs != null) fs.Close();
                }
                if(a != null)
                {
                    for(int i = 0;i < a.CantCurso; i++)
                    {
                        Curso curso = a[i];
                        lbxCursos.Items.Add(curso);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, a);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
