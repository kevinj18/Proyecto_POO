namespace Aplicacion_software_academico
{
    partial class frm_SolicitudRevisioncs
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
            txtIdEstudiante = new TextBox();
            txtIdAsignatura = new TextBox();
            txtDescripcion = new TextBox();
            cmbTipo = new ComboBox();
            btnCrear = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 90);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 0;
            label1.Text = "Id Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(425, 179);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 1;
            label2.Text = "Id Asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 266);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(501, 20);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(425, 122);
            txtIdEstudiante.Margin = new Padding(3, 4, 3, 4);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(250, 27);
            txtIdEstudiante.TabIndex = 4;
            // 
            // txtIdAsignatura
            // 
            txtIdAsignatura.Location = new Point(425, 211);
            txtIdAsignatura.Margin = new Padding(3, 4, 3, 4);
            txtIdAsignatura.Name = "txtIdAsignatura";
            txtIdAsignatura.Size = new Size(250, 27);
            txtIdAsignatura.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(344, 60);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(434, 175);
            txtDescripcion.TabIndex = 6;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(425, 298);
            cmbTipo.Margin = new Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(250, 28);
            cmbTipo.TabIndex = 7;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(516, 243);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 31);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(400, 18);
            label5.Name = "label5";
            label5.Size = new Size(311, 35);
            label5.TabIndex = 9;
            label5.Text = "Solicitud Revisión";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 62);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(btnCrear);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(-2, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(1228, 287);
            panel2.TabIndex = 11;
            // 
            // frm_SolicitudRevisioncs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1226, 651);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cmbTipo);
            Controls.Add(txtIdAsignatura);
            Controls.Add(txtIdEstudiante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_SolicitudRevisioncs";
            Text = "frm_SolicitudRevisioncs";
            Load += frm_SolicitudRevisioncs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdEstudiante;
        private TextBox txtIdAsignatura;
        private TextBox txtDescripcion;
        private ComboBox cmbTipo;
        private Button btnCrear;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
    }
}