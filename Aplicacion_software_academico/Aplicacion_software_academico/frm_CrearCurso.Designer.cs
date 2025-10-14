namespace Aplicacion_software_academico
{
    partial class frm_CrearCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCrearCurso = new Button();
            txtNombreCurso = new TextBox();
            txtCreditos = new TextBox();
            cmbIdProfesor = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 25);
            label1.Name = "label1";
            label1.Size = new Size(242, 29);
            label1.TabIndex = 0;
            label1.Text = "crear asignatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 131);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 190);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Créditos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 251);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 3;
            label4.Text = "Id Profesor:";
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCrearCurso.Location = new Point(367, 316);
            btnCrearCurso.Margin = new Padding(3, 2, 3, 2);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(82, 48);
            btnCrearCurso.TabIndex = 4;
            btnCrearCurso.Text = "Crear";
            btnCrearCurso.UseVisualStyleBackColor = true;
            btnCrearCurso.Click += btnCrearCurso_Click;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(321, 131);
            txtNombreCurso.Margin = new Padding(3, 2, 3, 2);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(242, 23);
            txtNombreCurso.TabIndex = 5;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(321, 191);
            txtCreditos.Margin = new Padding(3, 2, 3, 2);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(128, 23);
            txtCreditos.TabIndex = 6;
            // 
            // cmbIdProfesor
            // 
            cmbIdProfesor.FormattingEnabled = true;
            cmbIdProfesor.Location = new Point(321, 255);
            cmbIdProfesor.Margin = new Padding(3, 2, 3, 2);
            cmbIdProfesor.Name = "cmbIdProfesor";
            cmbIdProfesor.Size = new Size(184, 23);
            cmbIdProfesor.TabIndex = 7;
            cmbIdProfesor.SelectedIndexChanged += cmbIdProfesor_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 98);
            panel1.TabIndex = 26;
            // 
            // frm_CrearCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(835, 540);
            Controls.Add(panel1);
            Controls.Add(cmbIdProfesor);
            Controls.Add(txtCreditos);
            Controls.Add(txtNombreCurso);
            Controls.Add(btnCrearCurso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_CrearCurso";
            Text = "frm_CrearCurso";
            Load += frm_CrearCurso_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrearCurso;
        private TextBox txtNombreCurso;
        private TextBox txtCreditos;
        private ComboBox cmbIdProfesor;
        private Panel panel1;
    }
}