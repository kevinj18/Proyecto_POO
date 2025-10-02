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
            SuspendLayout();
            // 
            // btnConsutNota
            // 
            btnConsutNota.Location = new Point(79, 225);
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
            btnConsultAsistencia.Location = new Point(285, 225);
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
            btnSoliRevision.Location = new Point(79, 389);
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
            btnConsultRevision.Location = new Point(285, 389);
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
            label1.Location = new Point(412, 35);
            label1.Name = "label1";
            label1.Size = new Size(211, 35);
            label1.TabIndex = 4;
            label1.Text = "estudiantes";
            // 
            // panel1
            // 
            panel1.Location = new Point(507, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 353);
            panel1.TabIndex = 5;
            // 
            // frm_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1026, 757);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnConsultRevision);
            Controls.Add(btnSoliRevision);
            Controls.Add(btnConsultAsistencia);
            Controls.Add(btnConsutNota);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}