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
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(210, 248);
            dgvAsistencias.Margin = new Padding(3, 4, 3, 4);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.RowHeadersWidth = 51;
            dgvAsistencias.Size = new Size(685, 511);
            dgvAsistencias.TabIndex = 3;
            dgvAsistencias.CellContentClick += dgvNotas_CellContentClick;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(441, 140);
            cmbMaterias.Margin = new Padding(3, 4, 3, 4);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(287, 28);
            cmbMaterias.TabIndex = 5;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 140);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 4;
            label1.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 26);
            label2.Name = "label2";
            label2.Size = new Size(361, 35);
            label2.TabIndex = 6;
            label2.Text = "Consultar asistencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(493, 207);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 7;
            label3.Text = "Resultados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 95);
            panel1.TabIndex = 8;
            // 
            // frm_ConsultarAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1123, 788);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(cmbMaterias);
            Controls.Add(label1);
            Controls.Add(dgvAsistencias);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_ConsultarAsistencia";
            Text = "frm_ConsultarAsistencia";
            Load += frm_ConsultarAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAsistencias;
        private ComboBox cmbMaterias;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}