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
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(293, 114);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Asignatura:";
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(403, 114);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 10;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(418, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(78, 54);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(368, 26);
            label5.Name = "label5";
            label5.Size = new Size(225, 29);
            label5.TabIndex = 15;
            label5.Text = "Subir asistencia";
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(58, 165);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.Size = new Size(800, 307);
            dgvAsistencia.TabIndex = 16;
            dgvAsistencia.CellContentClick += dgvAsistencia_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-3, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 74);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // frm_SubirAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(926, 544);
            Controls.Add(btnGuardar);
            Controls.Add(panel2);
            Controls.Add(dgvAsistencia);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Name = "frm_SubirAsistencia";
            Text = "frm_SubirAsistencia";
            Load += frm_SubirAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
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
        private Panel panel2;
    }
}