namespace Aplicacion_software_academico
{
    partial class frm_ConsultarSolicitudes
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
            dgvSolicitudes = new DataGridView();
            Solicitudes = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(64, 125);
            dgvSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(934, 581);
            dgvSolicitudes.TabIndex = 0;
            dgvSolicitudes.CellContentClick += dgvSolicitudes_CellContentClick;
            // 
            // Solicitudes
            // 
            Solicitudes.AutoSize = true;
            Solicitudes.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Solicitudes.Location = new Point(64, 77);
            Solicitudes.Name = "Solicitudes";
            Solicitudes.Size = new Size(107, 28);
            Solicitudes.TabIndex = 1;
            Solicitudes.Text = "Solicitudes:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 20);
            label1.Name = "label1";
            label1.Size = new Size(356, 35);
            label1.TabIndex = 2;
            label1.Text = "Consulta solicitudes";
            // 
            // frm_ConsultarSolicitudes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1049, 743);
            Controls.Add(label1);
            Controls.Add(Solicitudes);
            Controls.Add(dgvSolicitudes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_ConsultarSolicitudes";
            Text = "frm_ConsultarSolicitudes";
            Load += frm_ConsultarSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSolicitudes;
        private Label Solicitudes;
        private Label label1;
    }
}