namespace Aplicacion_software_academico
{
    partial class frm_EditarNota
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
            cmbIdAsignatura = new ComboBox();
            label2 = new Label();
            cmbIdEstudiante = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            cmbNotas = new ComboBox();
            label4 = new Label();
            txtNuevaNota = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(177, 54);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 11;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 52);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 10;
            label2.Text = "Asignatura";
            label2.Click += label2_Click;
            // 
            // cmbIdEstudiante
            // 
            cmbIdEstudiante.FormattingEnabled = true;
            cmbIdEstudiante.Location = new Point(557, 54);
            cmbIdEstudiante.Name = "cmbIdEstudiante";
            cmbIdEstudiante.Size = new Size(219, 23);
            cmbIdEstudiante.TabIndex = 13;
            cmbIdEstudiante.SelectedIndexChanged += cmbIdEstudiante_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 54);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 12;
            label1.Text = "Estudiante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 133);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 14;
            label3.Text = "Notas Registradas";
            // 
            // cmbNotas
            // 
            cmbNotas.FormattingEnabled = true;
            cmbNotas.Location = new Point(177, 135);
            cmbNotas.Name = "cmbNotas";
            cmbNotas.Size = new Size(219, 23);
            cmbNotas.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(437, 133);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 16;
            label4.Text = "Nueva Nota";
            // 
            // txtNuevaNota
            // 
            txtNuevaNota.Location = new Point(557, 135);
            txtNuevaNota.Name = "txtNuevaNota";
            txtNuevaNota.Size = new Size(100, 23);
            txtNuevaNota.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(343, 228);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frm_EditarNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 300);
            Controls.Add(btnGuardar);
            Controls.Add(txtNuevaNota);
            Controls.Add(label4);
            Controls.Add(cmbNotas);
            Controls.Add(label3);
            Controls.Add(cmbIdEstudiante);
            Controls.Add(label1);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Name = "frm_EditarNota";
            Text = "frm_EditarNota";
            Load += frm_EditarNota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIdAsignatura;
        private Label label2;
        private ComboBox cmbIdEstudiante;
        private Label label1;
        private Label label3;
        private ComboBox cmbNotas;
        private Label label4;
        private TextBox txtNuevaNota;
        private Button btnGuardar;
    }
}