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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbIdEstudiante = new ComboBox();
            cmbIdAsignatura = new ComboBox();
            cmbEstado = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 52);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 3;
            label1.Text = "Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 112);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 4;
            label2.Text = "Asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 176);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 5;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 237);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 6;
            label4.Text = "Fecha";
            // 
            // cmbIdEstudiante
            // 
            cmbIdEstudiante.FormattingEnabled = true;
            cmbIdEstudiante.Location = new Point(206, 54);
            cmbIdEstudiante.Name = "cmbIdEstudiante";
            cmbIdEstudiante.Size = new Size(219, 23);
            cmbIdEstudiante.TabIndex = 9;
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(206, 114);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 10;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(206, 178);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(219, 23);
            cmbEstado.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(206, 235);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(219, 23);
            dtpFecha.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(222, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frm_SubirAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(cmbEstado);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(cmbIdEstudiante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_SubirAsistencia";
            Text = "frm_SubirAsistencia";
            Load += frm_SubirAsistencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbIdEstudiante;
        private ComboBox cmbIdAsignatura;
        private ComboBox cmbEstado;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
    }
}