namespace Final1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearSeleccion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtAreaEspecializacion = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxCursos = new System.Windows.Forms.ListBox();
            this.rbnDocente = new System.Windows.Forms.RadioButton();
            this.rbnAlumno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCrearSeleccion
            // 
            this.btnCrearSeleccion.Location = new System.Drawing.Point(306, 175);
            this.btnCrearSeleccion.Name = "btnCrearSeleccion";
            this.btnCrearSeleccion.Size = new System.Drawing.Size(150, 44);
            this.btnCrearSeleccion.TabIndex = 0;
            this.btnCrearSeleccion.Text = "Crear Seleccion ";
            this.btnCrearSeleccion.UseVisualStyleBackColor = false;
            this.btnCrearSeleccion.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(68, 33);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(154, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // txtAreaEspecializacion
            // 
            this.txtAreaEspecializacion.Location = new System.Drawing.Point(228, 29);
            this.txtAreaEspecializacion.Name = "txtAreaEspecializacion";
            this.txtAreaEspecializacion.Size = new System.Drawing.Size(154, 20);
            this.txtAreaEspecializacion.TabIndex = 4;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(231, 72);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(151, 20);
            this.txtLegajo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Area de Especializacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Legajo:";
            // 
            // lbxCursos
            // 
            this.lbxCursos.FormattingEnabled = true;
            this.lbxCursos.Location = new System.Drawing.Point(12, 108);
            this.lbxCursos.Name = "lbxCursos";
            this.lbxCursos.Size = new System.Drawing.Size(288, 186);
            this.lbxCursos.TabIndex = 11;
            // 
            // rbnDocente
            // 
            this.rbnDocente.AutoSize = true;
            this.rbnDocente.Location = new System.Drawing.Point(309, 118);
            this.rbnDocente.Name = "rbnDocente";
            this.rbnDocente.Size = new System.Drawing.Size(66, 17);
            this.rbnDocente.TabIndex = 13;
            this.rbnDocente.TabStop = true;
            this.rbnDocente.Text = "Docente";
            this.rbnDocente.UseVisualStyleBackColor = true;
            // 
            // rbnAlumno
            // 
            this.rbnAlumno.AutoSize = true;
            this.rbnAlumno.Location = new System.Drawing.Point(309, 141);
            this.rbnAlumno.Name = "rbnAlumno";
            this.rbnAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbnAlumno.TabIndex = 14;
            this.rbnAlumno.TabStop = true;
            this.rbnAlumno.Text = "Alumno";
            this.rbnAlumno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 312);
            this.Controls.Add(this.rbnAlumno);
            this.Controls.Add(this.rbnDocente);
            this.Controls.Add(this.lbxCursos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtAreaEspecializacion);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCrearSeleccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearSeleccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtAreaEspecializacion;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxCursos;
        private System.Windows.Forms.RadioButton rbnDocente;
        private System.Windows.Forms.RadioButton rbnAlumno;
    }
}

