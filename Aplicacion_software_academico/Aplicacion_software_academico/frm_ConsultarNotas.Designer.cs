namespace Aplicacion_software_academico
{
    partial class frm_ConsultarNotas
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
            label1 = new Label();
            cmbMaterias = new ComboBox();
            dgvNotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 68);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(137, 64);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(252, 23);
            cmbMaterias.TabIndex = 1;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(61, 125);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.Size = new Size(599, 383);
            dgvNotas.TabIndex = 2;
            dgvNotas.CellContentClick += dgvNotas_CellContentClick;
            // 
            // frm_ConsultarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 578);
            Controls.Add(dgvNotas);
            Controls.Add(cmbMaterias);
            Controls.Add(label1);
            Name = "frm_ConsultarNotas";
            Text = "frm_ConsultarNotas";
            Load += frm_ConsultarNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMaterias;
        private DataGridView dgvNotas;
    }
}