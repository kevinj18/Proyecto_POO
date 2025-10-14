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
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(10, 116);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(675, 416);
            dgvSolicitudes.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 32);
            label3.Name = "label3";
            label3.Size = new Size(304, 29);
            label3.TabIndex = 20;
            label3.Text = "Responder Solicitudes";
            label3.Click += label3_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAprobar.Location = new Point(770, 174);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(131, 73);
            btnAprobar.TabIndex = 21;
            btnAprobar.Text = "Aprobar";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnResponder_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRechazar.Location = new Point(770, 339);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(131, 73);
            btnRechazar.TabIndex = 22;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 95);
            panel2.TabIndex = 24;
            // 
            // frm_ResponderSolicitudes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(926, 544);
            Controls.Add(btnAprobar);
            Controls.Add(panel2);
            Controls.Add(btnRechazar);
            Controls.Add(dgvSolicitudes);
            Name = "frm_ResponderSolicitudes";
            Text = "frm_ResponderSolicitudes";
            Load += frm_ResponderSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSolicitudes;
        private Label label3;
        private Button btnAprobar;
        private Button btnRechazar;
        private Panel panel2;
    }
}