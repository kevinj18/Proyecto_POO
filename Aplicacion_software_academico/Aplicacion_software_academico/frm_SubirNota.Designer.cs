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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbIdEstudiante = new ComboBox();
            cmbIdAsignatura = new ComboBox();
            txtNota = new TextBox();
            btnGuardar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 124);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 2;
            label1.Text = "Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 188);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 3;
            label2.Text = "Asignatura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 251);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 4;
            label3.Text = "Nota:";
            // 
            // cmbIdEstudiante
            // 
            cmbIdEstudiante.FormattingEnabled = true;
            cmbIdEstudiante.Location = new Point(277, 122);
            cmbIdEstudiante.Name = "cmbIdEstudiante";
            cmbIdEstudiante.Size = new Size(219, 23);
            cmbIdEstudiante.TabIndex = 8;
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(277, 188);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 9;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(277, 251);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(149, 23);
            txtNota.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(293, 316);
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
            label4.Location = new Point(258, 36);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 14;
            label4.Text = "Subir Notas";
            // 
            // frm_SubirNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(663, 373);
            Controls.Add(label4);
            Controls.Add(btnGuardar);
            Controls.Add(txtNota);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(cmbIdEstudiante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_SubirNota";
            Text = "frm_SubirNota";
            Load += frm_SubirNota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbIdEstudiante;
        private ComboBox cmbIdAsignatura;
        private TextBox txtNota;
        private Button btnGuardar;
        private Label label4;
    }
}