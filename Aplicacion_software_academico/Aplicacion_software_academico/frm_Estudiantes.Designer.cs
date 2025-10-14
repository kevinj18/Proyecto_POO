namespace Aplicacion_software_academico
{
    partial class frm_Estudiantes
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
            pnlContenedor = new Panel();
            btnCerrarSesion = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btnConsultRevision = new Button();
            btnConsutNota = new Button();
            btnConsultAsistencia = new Button();
            btnSoliRevision = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContenedor.Location = new Point(250, 93);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(935, 545);
            pnlContenedor.TabIndex = 5;
            pnlContenedor.Paint += panel1_Paint;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(1089, 10);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(85, 23);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 26);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 4;
            label1.Text = "estudiantes";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(250, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 90);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(853, 3);
            button1.Name = "button1";
            button1.Size = new Size(79, 52);
            button1.TabIndex = 8;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // btnConsultRevision
            // 
            btnConsultRevision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultRevision.Location = new Point(55, 493);
            btnConsultRevision.Name = "btnConsultRevision";
            btnConsultRevision.Size = new Size(131, 73);
            btnConsultRevision.TabIndex = 3;
            btnConsultRevision.Text = "Consultar Revisión";
            btnConsultRevision.UseVisualStyleBackColor = true;
            btnConsultRevision.Click += button1_Click_1;
            // 
            // btnConsutNota
            // 
            btnConsutNota.BackColor = Color.FromArgb(37, 99, 235);
            btnConsutNota.FlatStyle = FlatStyle.Flat;
            btnConsutNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsutNota.ForeColor = Color.White;
            btnConsutNota.Location = new Point(55, 151);
            btnConsutNota.Name = "btnConsutNota";
            btnConsutNota.Size = new Size(131, 73);
            btnConsutNota.TabIndex = 0;
            btnConsutNota.Text = "Consultar Nota";
            btnConsutNota.UseVisualStyleBackColor = false;
            btnConsutNota.Click += button1_Click;
            // 
            // btnConsultAsistencia
            // 
            btnConsultAsistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsultAsistencia.Location = new Point(55, 257);
            btnConsultAsistencia.Name = "btnConsultAsistencia";
            btnConsultAsistencia.Size = new Size(131, 73);
            btnConsultAsistencia.TabIndex = 1;
            btnConsultAsistencia.Text = "Consultar Asistencia";
            btnConsultAsistencia.UseVisualStyleBackColor = true;
            btnConsultAsistencia.Click += btnConsultAsistencia_Click;
            // 
            // btnSoliRevision
            // 
            btnSoliRevision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoliRevision.Location = new Point(55, 379);
            btnSoliRevision.Name = "btnSoliRevision";
            btnSoliRevision.Size = new Size(131, 73);
            btnSoliRevision.TabIndex = 2;
            btnSoliRevision.Text = "Solicitud de Revisión";
            btnSoliRevision.UseVisualStyleBackColor = true;
            btnSoliRevision.Click += btnSoliRevision_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(55, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 121);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 58, 138);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnSoliRevision);
            panel2.Controls.Add(btnConsultAsistencia);
            panel2.Controls.Add(btnConsutNota);
            panel2.Controls.Add(btnConsultRevision);
            panel2.Location = new Point(-1, -1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 637);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // frm_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1184, 637);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlContenedor);
            Name = "frm_Estudiantes";
            Text = "frm_Estudiantes";
            Load += frm_Estudiantes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContenedor;
        private Button btnCerrarSesion;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button btnConsultRevision;
        private Button btnConsutNota;
        private Button btnConsultAsistencia;
        private Button btnSoliRevision;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}