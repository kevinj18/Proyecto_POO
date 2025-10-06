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
            SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrarUsuario.Location = new Point(35, 101);
            btnRegistrarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(150, 97);
            btnRegistrarUsuario.TabIndex = 22;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(1011, 16);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(97, 31);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAsignarEstudiante
            // 
            btnAsignarEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAsignarEstudiante.Location = new Point(35, 256);
            btnAsignarEstudiante.Margin = new Padding(3, 4, 3, 4);
            btnAsignarEstudiante.Name = "btnAsignarEstudiante";
            btnAsignarEstudiante.Size = new Size(150, 97);
            btnAsignarEstudiante.TabIndex = 24;
            btnAsignarEstudiante.Text = "Asignar Estudiante";
            btnAsignarEstudiante.UseVisualStyleBackColor = true;
            btnAsignarEstudiante.Click += btnAsignarEstudiante_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(445, 16);
            label1.Name = "label1";
            label1.Size = new Size(264, 35);
            label1.TabIndex = 25;
            label1.Text = "Administración";
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCrearCurso.Location = new Point(35, 453);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(150, 83);
            btnCrearCurso.TabIndex = 27;
            btnCrearCurso.Text = "Crear Curso";
            btnCrearCurso.UseVisualStyleBackColor = true;
            btnCrearCurso.Click += btnCrearCurso_Click;
            // 
            // frm_Administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1125, 564);
            Controls.Add(btnCrearCurso);
            Controls.Add(label1);
            Controls.Add(btnAsignarEstudiante);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRegistrarUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Administrador";
            Text = "frm_Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarUsuario;
        private Button btnCerrarSesion;
        private Button btnAsignarEstudiante;
        private Label label1;
        private Button btnCrearCurso;
    }
}