namespace Aplicacion_software_academico
{
    partial class frm_AsignarEstudiante
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
            cmbEstudiantes = new ComboBox();
            label1 = new Label();
            cmbAsignatura = new ComboBox();
            label2 = new Label();
            dgvInscripciones = new DataGridView();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(549, 103);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(219, 23);
            cmbEstudiantes.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, 103);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 18;
            label1.Text = "Estudiante:";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(189, 105);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(219, 23);
            cmbAsignatura.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 105);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 20;
            label2.Text = "Asignatura:";
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(37, 197);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.Size = new Size(499, 235);
            dgvInscripciones.TabIndex = 22;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(648, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 34);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frm_AsignarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 449);
            Controls.Add(btnGuardar);
            Controls.Add(dgvInscripciones);
            Controls.Add(cmbAsignatura);
            Controls.Add(label2);
            Controls.Add(cmbEstudiantes);
            Controls.Add(label1);
            Name = "frm_AsignarEstudiante";
            Text = "frm_AsignarUsuario";
            Load += frm_AsignarEstudiante_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEstudiantes;
        private Label label1;
        private ComboBox cmbAsignatura;
        private Label label2;
        private DataGridView dgvInscripciones;
        private Button btnGuardar;
    }
}