namespace Aplicacion_software_academico
{
    partial class frm_AdminCrearUsuario
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
            label2 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            txtContrasena = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbRol = new ComboBox();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 140);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(235, 143);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(388, 27);
            txtNombre.TabIndex = 18;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(235, 228);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(388, 27);
            txtCorreo.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 225);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 19;
            label1.Text = "Correo";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(235, 315);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(388, 27);
            txtContrasena.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 312);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 21;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(114, 401);
            label4.Name = "label4";
            label4.Size = new Size(40, 28);
            label4.TabIndex = 23;
            label4.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(235, 399);
            cmbRol.Margin = new Padding(3, 4, 3, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(388, 28);
            cmbRol.TabIndex = 24;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(320, 490);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(115, 87);
            btnCrear.TabIndex = 25;
            btnCrear.Text = "Crear Usuario";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // frm_AdminCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(750, 600);
            Controls.Add(btnCrear);
            Controls.Add(cmbRol);
            Controls.Add(label4);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_AdminCrearUsuario";
            Text = "frm_AdminCrearUsuario";
            Load += frm_AdminCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label1;
        private TextBox txtContrasena;
        private Label label3;
        private Label label4;
        private ComboBox cmbRol;
        private Button btnCrear;
    }
}