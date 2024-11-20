using Final1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nom = txtNombre.Text;
            string esp = txtAreaEspecializacion.Text;
            try
            {
                Curso c = a.CrearCurso(dni, nom, esp);
                lbxCursos.Items.Add(c);
            }
            catch (NoNumeroException n)
            {
                MessageBox.Show(n.Message);
            }
          
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {

            string dni = txtDNI.Text;
            string nom = txtNombre.Text;
            string legajo = txtLegajo.Text;
            int idx = lbxCursos.SelectedIndex;
            try
            {
              
            }
            catch (NoNumeroException n)
            {
                MessageBox.Show(n.Message);
            }
        }
    }
}
