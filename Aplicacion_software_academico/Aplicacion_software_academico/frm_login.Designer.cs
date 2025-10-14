namespace Aplicacion_software_academico
{
    partial class frm_login
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
            lblTitulo = new Label();
            panelIzquierdo = new Panel();
            picLogo = new PictureBox();
            txtUsuario = new TextBox();
            lblIniciarSesion = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            btnIniciar = new Button();
            txtContrasena = new TextBox();
            panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Transparent;
            lblTitulo.Location = new Point(3, 139);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 72);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Sistema \r\nAcadémico";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.FromArgb(33, 77, 140);
            panelIzquierdo.Controls.Add(picLogo);
            panelIzquierdo.Controls.Add(lblTitulo);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(169, 403);
            panelIzquierdo.TabIndex = 6;
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = Properties.Resources.Logo;
            picLogo.BackgroundImageLayout = ImageLayout.Stretch;
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(128, 90);
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(273, 174);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(164, 23);
            txtUsuario.TabIndex = 10;
            txtUsuario.TextChanged += txtUsuario_TextChanged_1;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // lblIniciarSesion
            // 
            lblIniciarSesion.AutoSize = true;
            lblIniciarSesion.BackColor = Color.FromArgb(34, 36, 49);
            lblIniciarSesion.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIniciarSesion.ForeColor = Color.Transparent;
            lblIniciarSesion.Location = new Point(273, 75);
            lblIniciarSesion.Name = "lblIniciarSesion";
            lblIniciarSesion.Size = new Size(151, 27);
            lblIniciarSesion.TabIndex = 13;
            lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Transparent;
            lblUsuario.Location = new Point(273, 156);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(51, 15);
            lblUsuario.TabIndex = 8;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Arial", 9F);
            lblContrasena.ForeColor = Color.Transparent;
            lblContrasena.Location = new Point(273, 216);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(72, 15);
            lblContrasena.TabIndex = 9;
            lblContrasena.Text = "Contraseña";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(33, 77, 140);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.FromArgb(34, 36, 49);
            btnIniciar.Location = new Point(273, 298);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(164, 31);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(273, 234);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(164, 23);
            txtContrasena.TabIndex = 11;
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(535, 403);
            Controls.Add(txtUsuario);
            Controls.Add(lblIniciarSesion);
            Controls.Add(lblUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(btnIniciar);
            Controls.Add(txtContrasena);
            Controls.Add(panelIzquierdo);
            Name = "frm_login";
            Text = "frm_login";
            Load += frm_login_Load;
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Panel panelIzquierdo;
        private PictureBox picLogo;
        private TextBox txtUsuario;
        private Label lblIniciarSesion;
        private Label lblUsuario;
        private Label lblContrasena;
        private Button btnIniciar;
        private TextBox txtContrasena;
    }
}