namespace Aplicacion_software_academico
{
    partial class frm_Profesor
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
            btnSubirNota = new Button();
            btnSubirAsistencia = new Button();
            btnCerrarSesion = new Button();
            btnResponderSolicitudes = new Button();
            label1 = new Label();
            pnlContenedor = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubirNota
            // 
            btnSubirNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubirNota.Location = new Point(36, 65);
            btnSubirNota.Margin = new Padding(3, 4, 3, 4);
            btnSubirNota.Name = "btnSubirNota";
            btnSubirNota.Size = new Size(150, 97);
            btnSubirNota.TabIndex = 1;
            btnSubirNota.Text = "Subir Nota";
            btnSubirNota.UseVisualStyleBackColor = true;
            btnSubirNota.Click += btnSubirNota_Click;
            // 
            // btnSubirAsistencia
            // 
            btnSubirAsistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubirAsistencia.Location = new Point(36, 258);
            btnSubirAsistencia.Margin = new Padding(3, 4, 3, 4);
            btnSubirAsistencia.Name = "btnSubirAsistencia";
            btnSubirAsistencia.Size = new Size(150, 97);
            btnSubirAsistencia.TabIndex = 2;
            btnSubirAsistencia.Text = "Subir Asistencia";
            btnSubirAsistencia.UseVisualStyleBackColor = true;
            btnSubirAsistencia.Click += btnSubirAsistencia_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(1299, 14);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(97, 31);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnResponderSolicitudes
            // 
            btnResponderSolicitudes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnResponderSolicitudes.Location = new Point(36, 452);
            btnResponderSolicitudes.Margin = new Padding(3, 4, 3, 4);
            btnResponderSolicitudes.Name = "btnResponderSolicitudes";
            btnResponderSolicitudes.Size = new Size(150, 97);
            btnResponderSolicitudes.TabIndex = 6;
            btnResponderSolicitudes.Text = "Responder Solicitudes";
            btnResponderSolicitudes.UseVisualStyleBackColor = true;
            btnResponderSolicitudes.Click += btnResponderSolicitudes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(680, 38);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 7;
            label1.Text = "profesor";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Location = new Point(241, 134);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1155, 597);
            pnlContenedor.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 111);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.Controls.Add(btnSubirNota);
            panel2.Controls.Add(btnSubirAsistencia);
            panel2.Controls.Add(btnResponderSolicitudes);
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 636);
            panel2.TabIndex = 10;
            // 
            // frm_Profesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1408, 743);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlContenedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Profesor";
            Text = "frm_Profesor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubirNota;
        private Button btnSubirAsistencia;
        private Button btnCerrarSesion;
        private Button btnResponderSolicitudes;
        private Label label1;
        private Panel pnlContenedor;
        private Panel panel1;
        private Panel panel2;
    }
}