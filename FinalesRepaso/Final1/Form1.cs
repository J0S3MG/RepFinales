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
        Alumnado a = new Alumnado();
        string path = Application.StartupPath + "\\Facultad.dat";
        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string dni = txtDNI.Text;
            string legajo = txtLegajo.Text;
            try
            {
                #region Datos levantados
                string nom = txtNombre.Text;
                string esp = txtAreaEspecializacion.Text;
                int idx = lbxCursos.SelectedIndex;
                #endregion
                if (rbnDocente.Checked)
                {
                    Curso c = a.CrearCurso(dni, nom, esp);
                    lbxCursos.Items.Add(c);
                }
                else if (rbnAlumno.Checked) 
                {
                    a.AgregarAlumno(dni, nom, legajo, idx);
                    Curso c = a[idx];
                    MessageBox.Show("Se inscribio a: "+c.VerEsp());
                }

            }
            catch (NoNumeroException n)
            {
                MessageBox.Show(n.Message);
                fs = new FileStream("Excepciones.csv",FileMode.OpenOrCreate,FileAccess.Write);
                sw = new StreamWriter(fs);
                string valormalo = a.ValorMalo(dni,legajo);
                sw.WriteLine($"{n};{valormalo}");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
          
        }

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
                    if(a == null) a = new Alumnado();
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
