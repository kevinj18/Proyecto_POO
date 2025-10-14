namespace Aplicacion_software_academico
{
    partial class frm_SubirNota
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
            btnGuardar = new Button();
            label4 = new Label();
            cmbIdAsignatura = new ComboBox();
            dgvNotas = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 126);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Asignatura:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(422, 477);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 55);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(377, 35);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 14;
            label4.Text = "Subir Notas";
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(377, 126);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 9;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(19, 180);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.RowHeadersWidth = 51;
            dgvNotas.Size = new Size(895, 291);
            dgvNotas.TabIndex = 15;
            dgvNotas.CellContentClick += dgvNotas_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 98);
            panel1.TabIndex = 16;
            // 
            // frm_SubirNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(926, 544);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Controls.Add(dgvNotas);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Name = "frm_SubirNota";
            Text = "frm_SubirNota";
            Load += frm_SubirNota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnGuardar;
        private Label label4;
        private ComboBox cmbIdAsignatura;
        private DataGridView dgvNotas;
        private Panel panel1;
    }
}