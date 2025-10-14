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
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 0;
            label1.Text = "Materia:";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(350, 94);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(252, 23);
            cmbMaterias.TabIndex = 1;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(150, 185);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.RowHeadersWidth = 51;
            dgvNotas.Size = new Size(599, 383);
            dgvNotas.TabIndex = 2;
            dgvNotas.CellContentClick += dgvNotas_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 21);
            label2.Name = "label2";
            label2.Size = new Size(244, 29);
            label2.TabIndex = 3;
            label2.Text = "Consulta de notas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(401, 152);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 4;
            label3.Text = "Resultados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 72);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // frm_ConsultarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(963, 578);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(dgvNotas);
            Controls.Add(cmbMaterias);
            Controls.Add(label1);
            Name = "frm_ConsultarNotas";
            Text = "frm_ConsultarNotas";
            Load += frm_ConsultarNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMaterias;
        private DataGridView dgvNotas;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}