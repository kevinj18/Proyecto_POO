namespace Aplicacion_software_academico
{
    partial class frm_AsignarEst
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
            btnCargar = new Button();
            dgvAsignaciones = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(12, 110);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(120, 34);
            btnCargar.TabIndex = 24;
            btnCargar.Text = "Importar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvAsignaciones
            // 
            dgvAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaciones.Location = new Point(12, 160);
            dgvAsignaciones.Name = "dgvAsignaciones";
            dgvAsignaciones.RowHeadersWidth = 51;
            dgvAsignaciones.Size = new Size(799, 368);
            dgvAsignaciones.TabIndex = 25;
            dgvAsignaciones.CellContentClick += dgvInscripciones_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 95);
            panel1.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 32);
            label3.Name = "label3";
            label3.Size = new Size(262, 29);
            label3.TabIndex = 24;
            label3.Text = "Asignar estudiante";
            // 
            // frm_AsignarEst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 540);
            Controls.Add(panel1);
            Controls.Add(dgvAsignaciones);
            Controls.Add(btnCargar);
            Name = "frm_AsignarEst";
            Text = "frm_AsignarEst";
            Load += frm_AsignarEst_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private DataGridView dgvAsignaciones;
        private Panel panel1;
        private Label label3;
    }
}