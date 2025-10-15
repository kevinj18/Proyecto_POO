namespace Aplicacion_software_academico
{
    partial class frm_Registrar
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
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            label5 = new Label();
            cmbRol = new ComboBox();
            panelEstudiante = new Panel();
            label8 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            label7 = new Label();
            txtSemestre = new TextBox();
            label6 = new Label();
            panelAdmin = new Panel();
            txtCargo = new TextBox();
            label13 = new Label();
            label12 = new Label();
            btnRegistrar = new Button();
            panelProfesor = new Panel();
            dtpFehcaContratacion = new DateTimePicker();
            txtEspecialidad = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panelEstudiante.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelProfesor.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 147);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 208);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(248, 263);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 324);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 3;
            label4.Text = "Rol:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(376, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(376, 208);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(363, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(376, 263);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(365, 27);
            txtContrasena.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 36);
            label5.Name = "label5";
            label5.Size = new Size(317, 35);
            label5.TabIndex = 8;
            label5.Text = "Registrar usuario";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(376, 328);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(297, 28);
            cmbRol.TabIndex = 9;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // panelEstudiante
            // 
            panelEstudiante.Controls.Add(label8);
            panelEstudiante.Controls.Add(dtpFechaIngreso);
            panelEstudiante.Controls.Add(label7);
            panelEstudiante.Controls.Add(txtSemestre);
            panelEstudiante.Controls.Add(label6);
            panelEstudiante.Location = new Point(248, 464);
            panelEstudiante.Name = "panelEstudiante";
            panelEstudiante.Size = new Size(493, 239);
            panelEstudiante.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(158, 16);
            label8.Name = "label8";
            label8.Size = new Size(195, 24);
            label8.TabIndex = 13;
            label8.Text = "Panel estudiante";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(176, 148);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(297, 27);
            dtpFechaIngreso.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 147);
            label7.Name = "label7";
            label7.Size = new Size(136, 28);
            label7.TabIndex = 2;
            label7.Text = "Fecha ingreso:";
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(176, 75);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(297, 27);
            txtSemestre.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 71);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 0;
            label6.Text = "Semestre:";
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(txtCargo);
            panelAdmin.Controls.Add(label13);
            panelAdmin.Controls.Add(label12);
            panelAdmin.Location = new Point(247, 460);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(491, 237);
            panelAdmin.TabIndex = 5;
            panelAdmin.Paint += panelAdmin_Paint;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(138, 115);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(270, 27);
            txtCargo.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(56, 115);
            label13.Name = "label13";
            label13.Size = new Size(69, 28);
            label13.TabIndex = 1;
            label13.Text = "Cargo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(152, 28);
            label12.Name = "label12";
            label12.Size = new Size(246, 24);
            label12.TabIndex = 0;
            label12.Text = "Panel administrativo:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(448, 379);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 53);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panelProfesor
            // 
            panelProfesor.Controls.Add(dtpFehcaContratacion);
            panelProfesor.Controls.Add(txtEspecialidad);
            panelProfesor.Controls.Add(label11);
            panelProfesor.Controls.Add(label10);
            panelProfesor.Controls.Add(label9);
            panelProfesor.Location = new Point(222, 461);
            panelProfesor.Name = "panelProfesor";
            panelProfesor.Size = new Size(550, 239);
            panelProfesor.TabIndex = 12;
            // 
            // dtpFehcaContratacion
            // 
            dtpFehcaContratacion.Location = new Point(249, 151);
            dtpFehcaContratacion.Name = "dtpFehcaContratacion";
            dtpFehcaContratacion.Size = new Size(297, 27);
            dtpFehcaContratacion.TabIndex = 13;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(249, 93);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(212, 27);
            txtEspecialidad.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(178, 29);
            label11.Name = "label11";
            label11.Size = new Size(183, 24);
            label11.TabIndex = 2;
            label11.Text = "Panel profesor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(35, 153);
            label10.Name = "label10";
            label10.Size = new Size(208, 28);
            label10.TabIndex = 1;
            label10.Text = "Fecha de contratación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 91);
            label9.Name = "label9";
            label9.Size = new Size(123, 28);
            label9.TabIndex = 0;
            label9.Text = "Especialidad:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-10, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 108);
            panel1.TabIndex = 13;
            // 
            // frm_Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(941, 720);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            Controls.Add(panelProfesor);
            Controls.Add(btnRegistrar);
            Controls.Add(panelEstudiante);
            Controls.Add(cmbRol);
            Controls.Add(txtContrasena);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_Registrar";
            Text = "Form2";
            Load += frm_Registrar_Load;
            panelEstudiante.ResumeLayout(false);
            panelEstudiante.PerformLayout();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelProfesor.ResumeLayout(false);
            panelProfesor.PerformLayout();
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
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private Label label5;
        private ComboBox cmbRol;
        private Panel panelEstudiante;
        private Label label6;
        private Label label7;
        private TextBox txtSemestre;
        private Button btnRegistrar;
        private Label label8;
        private DateTimePicker dtpFechaIngreso;
        private Panel panelProfesor;
        private TextBox txtEspecialidad;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panelAdmin;
        private TextBox txtCargo;
        private Label label13;
        private Label label12;
        private DateTimePicker dtpFehcaContratacion;
        private Panel panel1;
    }
}