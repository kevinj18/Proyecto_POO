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
            panel1 = new Panel();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnConsutNota
            // 
            btnConsutNota.Location = new Point(69, 169);
            btnConsutNota.Name = "btnConsutNota";
            btnConsutNota.Size = new Size(131, 73);
            btnConsutNota.TabIndex = 0;
            btnConsutNota.Text = "Consultar Nota";
            btnConsutNota.UseVisualStyleBackColor = true;
            btnConsutNota.Click += button1_Click;
            // 
            // btnConsultAsistencia
            // 
            btnConsultAsistencia.Location = new Point(249, 169);
            btnConsultAsistencia.Name = "btnConsultAsistencia";
            btnConsultAsistencia.Size = new Size(131, 73);
            btnConsultAsistencia.TabIndex = 1;
            btnConsultAsistencia.Text = "Consultar Asistencia";
            btnConsultAsistencia.UseVisualStyleBackColor = true;
            btnConsultAsistencia.Click += btnConsultAsistencia_Click;
            // 
            // btnSoliRevision
            // 
            btnSoliRevision.Location = new Point(69, 292);
            btnSoliRevision.Name = "btnSoliRevision";
            btnSoliRevision.Size = new Size(131, 73);
            btnSoliRevision.TabIndex = 2;
            btnSoliRevision.Text = "Solicitud de Revisión";
            btnSoliRevision.UseVisualStyleBackColor = true;
            btnSoliRevision.Click += btnSoliRevision_Click;
            // 
            // btnConsultRevision
            // 
            btnConsultRevision.Location = new Point(249, 292);
            btnConsultRevision.Name = "btnConsultRevision";
            btnConsultRevision.Size = new Size(131, 73);
            btnConsultRevision.TabIndex = 3;
            btnConsultRevision.Text = "Consultar Revisión";
            btnConsultRevision.UseVisualStyleBackColor = true;
            btnConsultRevision.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 26);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 4;
            label1.Text = "estudiantes";
            // 
            // panel1
            // 
            panel1.Location = new Point(444, 129);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 265);
            panel1.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(801, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(85, 23);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // frm_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(898, 568);
            Controls.Add(btnCerrarSesion);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnConsultRevision);
            Controls.Add(btnSoliRevision);
            Controls.Add(btnConsultAsistencia);
            Controls.Add(btnConsutNota);
            Name = "frm_Estudiantes";
            Text = "frm_Estudiantes";
            Load += frm_Estudiantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsutNota;
        private Button btnConsultAsistencia;
        private Button btnSoliRevision;
        private Button btnConsultRevision;
        private Label label1;
        private Panel panel1;
        private Button btnCerrarSesion;
    }
}