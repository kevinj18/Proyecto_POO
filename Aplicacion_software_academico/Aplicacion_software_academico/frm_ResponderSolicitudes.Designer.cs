namespace Aplicacion_software_academico
{
    partial class frm_ResponderSolicitudes
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
            label3 = new Label();
            btnAprobar = new Button();
            btnRechazar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(26, 212);
            dgvSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(882, 525);
            dgvSolicitudes.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(429, 62);
            label3.Name = "label3";
            label3.Size = new Size(381, 35);
            label3.TabIndex = 20;
            label3.Text = "Responder Solicitudes";
            label3.Click += label3_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAprobar.Location = new Point(989, 335);
            btnAprobar.Margin = new Padding(3, 4, 3, 4);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(150, 97);
            btnAprobar.TabIndex = 21;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnResponder_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRechazar.Location = new Point(989, 499);
            btnRechazar.Margin = new Padding(3, 4, 3, 4);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(150, 97);
            btnRechazar.TabIndex = 22;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // frm_ResponderSolicitudes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1199, 777);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(label3);
            Controls.Add(dgvSolicitudes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_ResponderSolicitudes";
            Text = "frm_ResponderSolicitudes";
            Load += frm_ResponderSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSolicitudes;
        private Label label3;
        private Button btnAprobar;
        private Button btnRechazar;
    }
}