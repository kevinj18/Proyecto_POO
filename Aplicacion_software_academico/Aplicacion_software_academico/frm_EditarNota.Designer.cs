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
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(223, 125);
            cmbIdAsignatura.Margin = new Padding(3, 4, 3, 4);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(250, 28);
            cmbIdAsignatura.TabIndex = 11;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 122);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 10;
            label2.Text = "Asignatura:";
            label2.Click += label2_Click;
            // 
            // cmbIdEstudiante
            // 
            cmbIdEstudiante.FormattingEnabled = true;
            cmbIdEstudiante.Location = new Point(658, 125);
            cmbIdEstudiante.Margin = new Padding(3, 4, 3, 4);
            cmbIdEstudiante.Name = "cmbIdEstudiante";
            cmbIdEstudiante.Size = new Size(250, 28);
            cmbIdEstudiante.TabIndex = 13;
            cmbIdEstudiante.SelectedIndexChanged += cmbIdEstudiante_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(535, 125);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 12;
            label1.Text = "Estudiante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 230);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 14;
            label3.Text = "Notas Registradas:";
            // 
            // cmbNotas
            // 
            cmbNotas.FormattingEnabled = true;
            cmbNotas.Location = new Point(223, 233);
            cmbNotas.Margin = new Padding(3, 4, 3, 4);
            cmbNotas.Name = "cmbNotas";
            cmbNotas.Size = new Size(250, 28);
            cmbNotas.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(520, 230);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 16;
            label4.Text = "Nueva Nota:";
            // 
            // txtNuevaNota
            // 
            txtNuevaNota.Location = new Point(658, 233);
            txtNuevaNota.Margin = new Padding(3, 4, 3, 4);
            txtNuevaNota.Name = "txtNuevaNota";
            txtNuevaNota.Size = new Size(114, 27);
            txtNuevaNota.TabIndex = 17;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(461, 324);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(400, 34);
            label5.Name = "label5";
            label5.Size = new Size(223, 35);
            label5.TabIndex = 19;
            label5.Text = "Editar notas";
            // 
            // frm_EditarNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(995, 393);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(txtNuevaNota);
            Controls.Add(label4);
            Controls.Add(cmbNotas);
            Controls.Add(label3);
            Controls.Add(cmbIdEstudiante);
            Controls.Add(label1);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label5;
    }
}