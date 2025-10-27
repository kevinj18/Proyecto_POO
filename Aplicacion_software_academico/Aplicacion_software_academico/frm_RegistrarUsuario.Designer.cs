namespace Aplicacion_software_academico
{
    partial class frm_RegistrarUsuario
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnImportar = new Button();
            panel1 = new Panel();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnImportar);
            groupBox1.Location = new Point(-4, -2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(834, 549);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(799, 360);
            dataGridView1.TabIndex = 1;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(16, 114);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(145, 40);
            btnImportar.TabIndex = 0;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-7, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 79);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(312, 27);
            label5.Name = "label5";
            label5.Size = new Size(253, 29);
            label5.TabIndex = 8;
            label5.Text = "Registrar usuario";
            // 
            // frm_RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 540);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frm_RegistrarUsuario";
            Text = "frm_RegistrarUsuario";
            Load += frm_RegistrarUsuario_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnImportar;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label5;
    }
}