namespace Aplicacion_software_academico
{
    partial class frm_CrearCurso
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
            btnCrearCurso = new Button();
            txtNombreCurso = new TextBox();
            txtCreditos = new TextBox();
            cmbIdProfesor = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 39);
            label1.Name = "label1";
            label1.Size = new Size(304, 35);
            label1.TabIndex = 0;
            label1.Text = "crear asignatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 133);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(112, 212);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 2;
            label3.Text = "Créditos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 294);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 3;
            label4.Text = "Id Profesor:";
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCrearCurso.Location = new Point(257, 380);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(94, 29);
            btnCrearCurso.TabIndex = 4;
            btnCrearCurso.Text = "Crear";
            btnCrearCurso.UseVisualStyleBackColor = true;
            btnCrearCurso.Click += btnCrearCurso_Click;
            // 
            // txtNombreCurso
            // 
            txtNombreCurso.Location = new Point(205, 133);
            txtNombreCurso.Name = "txtNombreCurso";
            txtNombreCurso.Size = new Size(276, 27);
            txtNombreCurso.TabIndex = 5;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(205, 213);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(146, 27);
            txtCreditos.TabIndex = 6;
            // 
            // cmbIdProfesor
            // 
            cmbIdProfesor.FormattingEnabled = true;
            cmbIdProfesor.Location = new Point(205, 298);
            cmbIdProfesor.Name = "cmbIdProfesor";
            cmbIdProfesor.Size = new Size(210, 28);
            cmbIdProfesor.TabIndex = 7;
            cmbIdProfesor.SelectedIndexChanged += cmbIdProfesor_SelectedIndexChanged;
            // 
            // frm_CrearCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(604, 460);
            Controls.Add(cmbIdProfesor);
            Controls.Add(txtCreditos);
            Controls.Add(txtNombreCurso);
            Controls.Add(btnCrearCurso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_CrearCurso";
            Text = "frm_CrearCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrearCurso;
        private TextBox txtNombreCurso;
        private TextBox txtCreditos;
        private ComboBox cmbIdProfesor;
    }
}