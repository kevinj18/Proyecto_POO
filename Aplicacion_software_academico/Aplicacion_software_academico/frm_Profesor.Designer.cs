namespace Aplicacion_software_academico
{
    partial class frm_Profesor
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
            btnSubirNota = new Button();
            btnSubirAsistencia = new Button();
            btnCerrarSesion = new Button();
            btnResponderSolicitudes = new Button();
            label1 = new Label();
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
            // btnSubirNota
            // 
            btnSubirNota.BackColor = Color.FromArgb(56, 142, 60);
            btnSubirNota.FlatStyle = FlatStyle.Flat;
            btnSubirNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubirNota.ForeColor = Color.White;
            btnSubirNota.Location = new Point(45, 173);
            btnSubirNota.Name = "btnSubirNota";
            btnSubirNota.Size = new Size(137, 76);
            btnSubirNota.TabIndex = 1;
            btnSubirNota.Text = "Subir Nota";
            btnSubirNota.UseVisualStyleBackColor = false;
            btnSubirNota.Click += btnSubirNota_Click;
            // 
            // btnSubirAsistencia
            // 
            btnSubirAsistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubirAsistencia.Location = new Point(45, 303);
            btnSubirAsistencia.Name = "btnSubirAsistencia";
            btnSubirAsistencia.Size = new Size(137, 76);
            btnSubirAsistencia.TabIndex = 2;
            btnSubirAsistencia.Text = "Subir Asistencia";
            btnSubirAsistencia.UseVisualStyleBackColor = true;
            btnSubirAsistencia.Click += btnSubirAsistencia_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(1137, 10);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(85, 23);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnResponderSolicitudes
            // 
            btnResponderSolicitudes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnResponderSolicitudes.Location = new Point(45, 431);
            btnResponderSolicitudes.Name = "btnResponderSolicitudes";
            btnResponderSolicitudes.Size = new Size(137, 76);
            btnResponderSolicitudes.TabIndex = 6;
            btnResponderSolicitudes.Text = "Responder Solicitudes";
            btnResponderSolicitudes.UseVisualStyleBackColor = true;
            btnResponderSolicitudes.Click += btnResponderSolicitudes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 10);
            label1.Name = "label1";
            label1.Size = new Size(133, 29);
            label1.TabIndex = 7;
            label1.Text = "profesor";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Location = new Point(250, 86);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(942, 583);
            pnlContenedor.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(250, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 83);
            panel1.TabIndex = 9;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(860, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(79, 52);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 58, 138);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnSubirNota);
            panel2.Controls.Add(btnSubirAsistencia);
            panel2.Controls.Add(btnResponderSolicitudes);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 718);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(45, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 121);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frm_Profesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1191, 669);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlContenedor);
            Name = "frm_Profesor";
            Text = "frm_Profesor";
            Load += frm_Profesor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubirNota;
        private Button btnSubirAsistencia;
        private Button btnCerrarSesion;
        private Button btnResponderSolicitudes;
        private Label label1;
        private Panel pnlContenedor;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnCerrar;
    }
}