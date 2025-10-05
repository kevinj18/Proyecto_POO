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
            btnEditarNota = new Button();
            btnCerrarSesion = new Button();
            btnEditarAsistencia = new Button();
            btnResponderSolicitudes = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubirNota
            // 
            btnSubirNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubirNota.Location = new Point(42, 80);
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
            btnSubirAsistencia.Location = new Point(42, 220);
            btnSubirAsistencia.Margin = new Padding(3, 4, 3, 4);
            btnSubirAsistencia.Name = "btnSubirAsistencia";
            btnSubirAsistencia.Size = new Size(150, 97);
            btnSubirAsistencia.TabIndex = 2;
            btnSubirAsistencia.Text = "Subir Asistencia";
            btnSubirAsistencia.UseVisualStyleBackColor = true;
            btnSubirAsistencia.Click += btnSubirAsistencia_Click;
            // 
            // btnEditarNota
            // 
            btnEditarNota.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditarNota.Location = new Point(42, 375);
            btnEditarNota.Margin = new Padding(3, 4, 3, 4);
            btnEditarNota.Name = "btnEditarNota";
            btnEditarNota.Size = new Size(150, 97);
            btnEditarNota.TabIndex = 3;
            btnEditarNota.Text = "Editar Nota";
            btnEditarNota.UseVisualStyleBackColor = true;
            btnEditarNota.Click += btnEditarNota_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(912, 16);
            btnCerrarSesion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(97, 31);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEditarAsistencia
            // 
            btnEditarAsistencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditarAsistencia.Location = new Point(42, 527);
            btnEditarAsistencia.Margin = new Padding(3, 4, 3, 4);
            btnEditarAsistencia.Name = "btnEditarAsistencia";
            btnEditarAsistencia.Size = new Size(150, 97);
            btnEditarAsistencia.TabIndex = 5;
            btnEditarAsistencia.Text = "Editar Asistencia";
            btnEditarAsistencia.UseVisualStyleBackColor = true;
            btnEditarAsistencia.Click += btnEditarAsistencia_Click;
            // 
            // btnResponderSolicitudes
            // 
            btnResponderSolicitudes.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnResponderSolicitudes.Location = new Point(42, 683);
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
            label1.Location = new Point(397, 16);
            label1.Name = "label1";
            label1.Size = new Size(255, 35);
            label1.TabIndex = 7;
            label1.Text = "menú profesor";
            // 
            // frm_Profesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1023, 859);
            Controls.Add(label1);
            Controls.Add(btnResponderSolicitudes);
            Controls.Add(btnEditarAsistencia);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEditarNota);
            Controls.Add(btnSubirAsistencia);
            Controls.Add(btnSubirNota);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Profesor";
            Text = "frm_Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubirNota;
        private Button btnSubirAsistencia;
        private Button btnEditarNota;
        private Button btnCerrarSesion;
        private Button btnEditarAsistencia;
        private Button btnResponderSolicitudes;
        private Label label1;
    }
}