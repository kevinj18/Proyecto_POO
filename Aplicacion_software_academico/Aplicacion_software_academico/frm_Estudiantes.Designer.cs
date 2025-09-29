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
            SuspendLayout();
            // 
            // btnConsutNota
            // 
            btnConsutNota.Location = new Point(12, 60);
            btnConsutNota.Name = "btnConsutNota";
            btnConsutNota.Size = new Size(131, 73);
            btnConsutNota.TabIndex = 0;
            btnConsutNota.Text = "Consultar Nota";
            btnConsutNota.UseVisualStyleBackColor = true;
            btnConsutNota.Click += button1_Click;
            // 
            // btnConsultAsistencia
            // 
            btnConsultAsistencia.Location = new Point(12, 162);
            btnConsultAsistencia.Name = "btnConsultAsistencia";
            btnConsultAsistencia.Size = new Size(131, 73);
            btnConsultAsistencia.TabIndex = 1;
            btnConsultAsistencia.Text = "Consultar Asistencia";
            btnConsultAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnSoliRevision
            // 
            btnSoliRevision.Location = new Point(12, 269);
            btnSoliRevision.Name = "btnSoliRevision";
            btnSoliRevision.Size = new Size(131, 73);
            btnSoliRevision.TabIndex = 2;
            btnSoliRevision.Text = "Solicitud de Revisión";
            btnSoliRevision.UseVisualStyleBackColor = true;
            // 
            // frm_Estudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 568);
            Controls.Add(btnSoliRevision);
            Controls.Add(btnConsultAsistencia);
            Controls.Add(btnConsutNota);
            Name = "frm_Estudiantes";
            Text = "frm_Estudiantes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConsutNota;
        private Button btnConsultAsistencia;
        private Button btnSoliRevision;
    }
}