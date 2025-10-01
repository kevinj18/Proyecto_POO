namespace Aplicacion_software_academico
{
    partial class frm_ConsultarAsistencia
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
            dgvAsistencias = new DataGridView();
            cmbMaterias = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            SuspendLayout();
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(135, 187);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.Size = new Size(599, 383);
            dgvAsistencias.TabIndex = 3;
            dgvAsistencias.CellContentClick += dgvNotas_CellContentClick;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(321, 97);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(252, 23);
            cmbMaterias.TabIndex = 5;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 101);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Materia";
            // 
            // frm_ConsultarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 591);
            Controls.Add(cmbMaterias);
            Controls.Add(label1);
            Controls.Add(dgvAsistencias);
            Name = "frm_ConsultarAsistencia";
            Text = "frm_ConsultarAsistencia";
            Load += frm_ConsultarAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAsistencias;
        private ComboBox cmbMaterias;
        private Label label1;
    }
}