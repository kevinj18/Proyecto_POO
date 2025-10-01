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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 45);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 110);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Id Asignatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 172);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 230);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(172, 37);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(219, 23);
            txtIdEstudiante.TabIndex = 4;
            // 
            // txtIdAsignatura
            // 
            txtIdAsignatura.Location = new Point(172, 107);
            txtIdAsignatura.Name = "txtIdAsignatura";
            txtIdAsignatura.Size = new Size(219, 23);
            txtIdAsignatura.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(172, 230);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(219, 95);
            txtDescripcion.TabIndex = 6;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(172, 169);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(219, 23);
            cmbTipo.TabIndex = 7;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(246, 331);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // frm_SolicitudRevisioncs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 411);
            Controls.Add(btnCrear);
            Controls.Add(cmbTipo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIdAsignatura);
            Controls.Add(txtIdEstudiante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_SolicitudRevisioncs";
            Text = "frm_SolicitudRevisioncs";
            Load += frm_SolicitudRevisioncs_Load;
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
    }
}