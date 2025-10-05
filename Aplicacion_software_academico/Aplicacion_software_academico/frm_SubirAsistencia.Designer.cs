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
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 155);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 3;
            label1.Text = "Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 235);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 4;
            label2.Text = "Asignatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 321);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 5;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 402);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            // 
            // cmbIdEstudiante
            // 
            cmbIdEstudiante.FormattingEnabled = true;
            cmbIdEstudiante.Location = new Point(262, 158);
            cmbIdEstudiante.Margin = new Padding(3, 4, 3, 4);
            cmbIdEstudiante.Name = "cmbIdEstudiante";
            cmbIdEstudiante.Size = new Size(250, 28);
            cmbIdEstudiante.TabIndex = 9;
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(262, 238);
            cmbIdAsignatura.Margin = new Padding(3, 4, 3, 4);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(250, 28);
            cmbIdAsignatura.TabIndex = 10;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(262, 323);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(250, 28);
            cmbEstado.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(262, 399);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(281, 505);
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
            label5.Location = new Point(188, 49);
            label5.Name = "label5";
            label5.Size = new Size(283, 35);
            label5.TabIndex = 15;
            label5.Text = "Subir asistencia";
            // 
            // frm_SubirAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(642, 600);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(cmbEstado);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(cmbIdEstudiante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label5;
    }
}