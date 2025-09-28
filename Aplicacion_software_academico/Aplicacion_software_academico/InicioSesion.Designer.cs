namespace Aplicacion_software_academico
{
    partial class InicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Usuario = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            txtContrasena = new TextBox();
            btnIniciar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(168, 143);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(239, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(287, 23);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 193);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(239, 185);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(287, 23);
            txtContrasena.TabIndex = 2;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(239, 313);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(378, 313);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 530);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIniciar);
            Controls.Add(txtContrasena);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(Usuario);
            Name = "InicioSesion";
            Text = "Inicio Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuario;
        private TextBox txtUsuario;
        private Label label1;
        private TextBox txtContrasena;
        private Button btnIniciar;
        private Button btnRegistrar;
    }
}
