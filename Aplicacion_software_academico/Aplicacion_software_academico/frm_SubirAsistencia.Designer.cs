namespace Aplicacion_software_academico
{
    partial class frm_SubirAsistencia
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
            label2 = new Label();
            cmbIdAsignatura = new ComboBox();
            btnGuardar = new Button();
            label5 = new Label();
            dgvAsistencia = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(335, 152);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 4;
            label2.Text = "Asignatura:";
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(461, 152);
            cmbIdAsignatura.Margin = new Padding(3, 4, 3, 4);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(250, 28);
            cmbIdAsignatura.TabIndex = 10;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(515, 16);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(420, 34);
            label5.Name = "label5";
            label5.Size = new Size(283, 35);
            label5.TabIndex = 15;
            label5.Text = "Subir asistencia";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(66, 220);
            dgvAsistencia.Margin = new Padding(3, 4, 3, 4);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(914, 333);
            dgvAsistencia.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(-3, 584);
            panel1.Name = "panel1";
            panel1.Size = new Size(1288, 221);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1288, 98);
            panel2.TabIndex = 18;
            // 
            // frm_SubirAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1284, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvAsistencia);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_SubirAsistencia";
            Text = "frm_SubirAsistencia";
            Load += frm_SubirAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cmbIdAsignatura;
        private Button btnGuardar;
        private Label label5;
        private DataGridView dgvAsistencia;
        private Panel panel1;
        private Panel panel2;
    }
}