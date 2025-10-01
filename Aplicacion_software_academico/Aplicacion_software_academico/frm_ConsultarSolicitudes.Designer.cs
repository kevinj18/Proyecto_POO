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
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(56, 94);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.Size = new Size(817, 436);
            dgvSolicitudes.TabIndex = 0;
            dgvSolicitudes.CellContentClick += dgvSolicitudes_CellContentClick;
            // 
            // Solicitudes
            // 
            Solicitudes.AutoSize = true;
            Solicitudes.Location = new Point(56, 58);
            Solicitudes.Name = "Solicitudes";
            Solicitudes.Size = new Size(64, 15);
            Solicitudes.TabIndex = 1;
            Solicitudes.Text = "Solicitudes";
            // 
            // frm_ConsultarSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 557);
            Controls.Add(Solicitudes);
            Controls.Add(dgvSolicitudes);
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
    }
}