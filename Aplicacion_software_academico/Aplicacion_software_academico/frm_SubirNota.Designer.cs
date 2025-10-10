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
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 94);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Asignatura:";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(360, 605);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 32);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 14;
            label4.Text = "Subir Notas";
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(379, 94);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 9;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(12, 200);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.Size = new Size(870, 386);
            dgvNotas.TabIndex = 15;
            dgvNotas.CellContentClick += dgvNotas_CellContentClick;
            // 
            // frm_SubirNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(894, 640);
            Controls.Add(dgvNotas);
            Controls.Add(label4);
            Controls.Add(btnGuardar);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Name = "frm_SubirNota";
            Text = "frm_SubirNota";
            Load += frm_SubirNota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnGuardar;
        private Label label4;
        private ComboBox cmbIdAsignatura;
        private DataGridView dgvNotas;
    }
}