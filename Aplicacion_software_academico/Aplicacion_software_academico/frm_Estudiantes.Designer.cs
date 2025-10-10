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
            btnConsutNota = new Button();
            btnConsultAsistencia = new Button();
            btnSoliRevision = new Button();
            btnConsultRevision = new Button();
            label1 = new Label();
            pnlContenedor = new Panel();
            btnCerrarSesion = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsutNota
            // 
            btnConsutNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsutNota.Location = new Point(68, 76);
            btnConsutNota.Margin = new Padding(3, 4, 3, 4);
            btnConsutNota.Name = "btnConsutNota";
            btnConsutNota.Size = new Size(150, 97);
            btnConsutNota.TabIndex = 0;
            btnConsutNota.Text = "Consultar Nota";
            btnConsutNota.UseVisualStyleBackColor = true;
            btnConsutNota.Click += button1_Click;
            // 
            // btnConsultAsistencia
            // 
            btnConsultAsistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConsultAsistencia.Location = new Point(68, 232);
            btnConsultAsistencia.Margin = new Padding(3, 4, 3, 4);
            btnConsultAsistencia.Name = "btnConsultAsistencia";
            btnConsultAsistencia.Size = new Size(150, 97);
            btnConsultAsistencia.TabIndex = 1;
            btnConsultAsistencia.Text = "Consultar Asistencia";
            btnConsultAsistencia.UseVisualStyleBackColor = true;
            btnConsultAsistencia.Click += btnConsultAsistencia_Click;
            // 
            // btnSoliRevision
            // 
            btnSoliRevision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoliRevision.Location = new Point(68, 394);
            btnSoliRevision.Margin = new Padding(3, 4, 3, 4);
            btnSoliRevision.Name = "btnSoliRevision";
            btnSoliRevision.Size = new Size(150, 97);
            btnSoliRevision.TabIndex = 2;
            btnSoliRevision.Text = "Solicitud de Revisión";
            btnSoliRevision.UseVisualStyleBackColor = true;
            btnSoliRevision.Click += btnSoliRevision_Click;
            // 
            // btnConsultRevision
            // 
            btnConsultRevision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultRevision.Location = new Point(68, 546);
            btnConsultRevision.Margin = new Padding(3, 4, 3, 4);
            btnConsultRevision.Name = "btnConsultRevision";
            btnConsultRevision.Size = new Size(150, 97);
            btnConsultRevision.TabIndex = 3;
            btnConsultRevision.Text = "Consultar Revisión";
            btnConsultRevision.UseVisualStyleBackColor = true;
            btnConsultRevision.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(664, 42);
            label1.Name = "label1";
            label1.Size = new Size(211, 35);
            label1.TabIndex = 4;
            label1.Text = "estudiantes";
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackgroundImageLayout = ImageLayout.Stretch;
            pnlContenedor.Location = new Point(308, 136);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1020, 669);
            pnlContenedor.TabIndex = 5;
            pnlContenedor.Paint += panel1_Paint;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(1245, 14);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(97, 31);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1355, 120);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(btnSoliRevision);
            panel2.Controls.Add(btnConsultAsistencia);
            panel2.Controls.Add(btnConsutNota);
            panel2.Controls.Add(btnConsultRevision);
            panel2.Location = new Point(-1, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 712);
            panel2.TabIndex = 8;
            // 
            // frm_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1353, 827);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlContenedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Estudiantes";
            Text = "frm_Estudiantes";
            Load += frm_Estudiantes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsutNota;
        private Button btnConsultAsistencia;
        private Button btnSoliRevision;
        private Button btnConsultRevision;
        private Label label1;
        private Panel pnlContenedor;
        private Button btnCerrarSesion;
        private Panel panel1;
        private Panel panel2;
    }
}