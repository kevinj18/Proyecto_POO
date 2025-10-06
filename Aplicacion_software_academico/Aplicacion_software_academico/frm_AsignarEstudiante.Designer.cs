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
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // cmbEstudiantes
            // 
            cmbEstudiantes.FormattingEnabled = true;
            cmbEstudiantes.Location = new Point(628, 155);
            cmbEstudiantes.Margin = new Padding(3, 4, 3, 4);
            cmbEstudiantes.Name = "cmbEstudiantes";
            cmbEstudiantes.Size = new Size(250, 28);
            cmbEstudiantes.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(516, 155);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 18;
            label1.Text = "Estudiante:";
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(217, 158);
            cmbAsignatura.Margin = new Padding(3, 4, 3, 4);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(250, 28);
            cmbAsignatura.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 158);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 20;
            label2.Text = "Asignatura:";
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(42, 263);
            dgvInscripciones.Margin = new Padding(3, 4, 3, 4);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersWidth = 51;
            dgvInscripciones.Size = new Size(570, 313);
            dgvInscripciones.TabIndex = 22;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(711, 531);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(137, 45);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 35);
            label3.Name = "label3";
            label3.Size = new Size(329, 35);
            label3.TabIndex = 24;
            label3.Text = "Asignar estudiante";
            // 
            // frm_AsignarEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(939, 599);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(dgvInscripciones);
            Controls.Add(cmbAsignatura);
            Controls.Add(label2);
            Controls.Add(cmbEstudiantes);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label3;
    }
}