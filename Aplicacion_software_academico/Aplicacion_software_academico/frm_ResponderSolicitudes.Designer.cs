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
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Location = new Point(12, 155);
            dgvSolicitudes.Margin = new Padding(3, 4, 3, 4);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.RowHeadersWidth = 51;
            dgvSolicitudes.Size = new Size(886, 609);
            dgvSolicitudes.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(437, 42);
            label3.Name = "label3";
            label3.Size = new Size(381, 35);
            label3.TabIndex = 20;
            label3.Text = "Responder Solicitudes";
            label3.Click += label3_Click;
            // 
            // btnAprobar
            // 
            btnAprobar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAprobar.Location = new Point(42, 108);
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
            btnRechazar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnRechazar.Location = new Point(42, 268);
            btnRechazar.Margin = new Padding(3, 4, 3, 4);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(150, 97);
            btnRechazar.TabIndex = 22;
            btnRechazar.Text = "Rechazar";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(btnAprobar);
            panel1.Controls.Add(btnRechazar);
            panel1.Location = new Point(919, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 654);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 127);
            panel2.TabIndex = 24;
            // 
            // frm_ResponderSolicitudes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1199, 777);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvSolicitudes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_ResponderSolicitudes";
            Text = "frm_ResponderSolicitudes";
            Load += frm_ResponderSolicitudes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSolicitudes;
        private Label label3;
        private Button btnAprobar;
        private Button btnRechazar;
        private Panel panel1;
        private Panel panel2;
    }
}