namespace Aplicacion_software_academico
{
    partial class frm_EditarAsistencia
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
            cmbIdEstudiante = new ComboBox();
            label1 = new Label();
            dgvAsistencias = new DataGridView();
            label3 = new Label();
            cmbNuevoEstado = new ComboBox();
            label4 = new Label();
            btnGuardar = new Button();
            label5 = new Label();
            label2 = new Label();
            cmbIdAsignatura = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            SuspendLayout();
            // 
            // cmbIdEstudiante
            // 
            cmbIdEstudiante.FormattingEnabled = true;
            cmbIdEstudiante.Location = new Point(551, 82);
            cmbIdEstudiante.Name = "cmbIdEstudiante";
            cmbIdEstudiante.Size = new Size(219, 23);
            cmbIdEstudiante.TabIndex = 17;
            cmbIdEstudiante.SelectedIndexChanged += cmbIdEstudiante_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(453, 82);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 16;
            label1.Text = "Estudiante:";
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(12, 183);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.RowHeadersWidth = 51;
            dgvAsistencias.Size = new Size(499, 235);
            dgvAsistencias.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 145);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 19;
            label3.Text = "Asistencias registradas";
            // 
            // cmbNuevoEstado
            // 
            cmbNuevoEstado.FormattingEnabled = true;
            cmbNuevoEstado.Location = new Point(551, 183);
            cmbNuevoEstado.Name = "cmbNuevoEstado";
            cmbNuevoEstado.Size = new Size(219, 23);
            cmbNuevoEstado.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(606, 145);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 21;
            label4.Text = "Nuevo Estado";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(600, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 34);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 24);
            label5.Name = "label5";
            label5.Size = new Size(239, 29);
            label5.TabIndex = 23;
            label5.Text = "editar asistencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 82);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 14;
            label2.Text = "Asignatura:";
            // 
            // cmbIdAsignatura
            // 
            cmbIdAsignatura.FormattingEnabled = true;
            cmbIdAsignatura.Location = new Point(171, 82);
            cmbIdAsignatura.Name = "cmbIdAsignatura";
            cmbIdAsignatura.Size = new Size(219, 23);
            cmbIdAsignatura.TabIndex = 15;
            cmbIdAsignatura.SelectedIndexChanged += cmbIdAsignatura_SelectedIndexChanged;
            // 
            // frm_EditarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(cmbNuevoEstado);
            Controls.Add(label3);
            Controls.Add(dgvAsistencias);
            Controls.Add(cmbIdEstudiante);
            Controls.Add(label1);
            Controls.Add(cmbIdAsignatura);
            Controls.Add(label2);
            Name = "frm_EditarAsistencia";
            Text = "frm_EditarAsistencia";
            Load += frm_EditarAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIdEstudiante;
        private Label label1;
        private DataGridView dgvAsistencias;
        private Label label3;
        private ComboBox cmbNuevoEstado;
        private Label label4;
        private Button btnGuardar;
        private Label label5;
        private Label label2;
        private ComboBox cmbIdAsignatura;
    }
}