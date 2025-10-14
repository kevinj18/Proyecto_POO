namespace Aplicacion_software_academico
{
    partial class frm_Administrador
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
            btnRegistrarUsuario = new Button();
            btnCerrarSesion = new Button();
            btnAsignarEstudiante = new Button();
            label1 = new Label();
            btnCrearCurso = new Button();
            pnlContenedor = new Panel();
            panel1 = new Panel();
            btnCerrar = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRegistrarUsuario.Location = new Point(23, 215);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(131, 73);
            btnRegistrarUsuario.TabIndex = 22;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(933, 9);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(85, 23);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAsignarEstudiante
            // 
            btnAsignarEstudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAsignarEstudiante.Location = new Point(23, 344);
            btnAsignarEstudiante.Name = "btnAsignarEstudiante";
            btnAsignarEstudiante.Size = new Size(131, 73);
            btnAsignarEstudiante.TabIndex = 24;
            btnAsignarEstudiante.Text = "Asignar Estudiante";
            btnAsignarEstudiante.UseVisualStyleBackColor = true;
            btnAsignarEstudiante.Click += btnAsignarEstudiante_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 22);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 25;
            label1.Text = "Administración";
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCrearCurso.Location = new Point(23, 476);
            btnCrearCurso.Margin = new Padding(3, 2, 3, 2);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(131, 62);
            btnCrearCurso.TabIndex = 27;
            btnCrearCurso.Text = "Crear Curso";
            btnCrearCurso.UseVisualStyleBackColor = true;
            btnCrearCurso.Click += btnCrearCurso_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Location = new Point(189, 68);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(851, 579);
            pnlContenedor.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(182, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 63);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(771, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(72, 57);
            btnCerrar.TabIndex = 26;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 58, 138);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCrearCurso);
            panel2.Controls.Add(btnAsignarEstudiante);
            panel2.Controls.Add(btnRegistrarUsuario);
            panel2.Location = new Point(-1, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 646);
            panel2.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(23, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 121);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // frm_Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1041, 646);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlContenedor);
            Name = "frm_Administrador";
            Text = "frm_Administrador";
            Load += frm_Administrador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarUsuario;
        private Button btnCerrarSesion;
        private Button btnAsignarEstudiante;
        private Label label1;
        private Button btnCrearCurso;
        private Panel pnlContenedor;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCerrar;
    }
}