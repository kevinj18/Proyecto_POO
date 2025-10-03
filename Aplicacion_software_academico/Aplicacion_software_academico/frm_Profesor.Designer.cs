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
            SuspendLayout();
            // 
            // btnSubirNota
            // 
            btnSubirNota.Location = new Point(37, 60);
            btnSubirNota.Name = "btnSubirNota";
            btnSubirNota.Size = new Size(131, 73);
            btnSubirNota.TabIndex = 1;
            btnSubirNota.Text = "Subir Nota";
            btnSubirNota.UseVisualStyleBackColor = true;
            btnSubirNota.Click += btnSubirNota_Click;
            // 
            // btnSubirAsistencia
            // 
            btnSubirAsistencia.Location = new Point(37, 165);
            btnSubirAsistencia.Name = "btnSubirAsistencia";
            btnSubirAsistencia.Size = new Size(131, 73);
            btnSubirAsistencia.TabIndex = 2;
            btnSubirAsistencia.Text = "Subir Asistencia";
            btnSubirAsistencia.UseVisualStyleBackColor = true;
            btnSubirAsistencia.Click += btnSubirAsistencia_Click;
            // 
            // btnEditarNota
            // 
            btnEditarNota.Location = new Point(37, 281);
            btnEditarNota.Name = "btnEditarNota";
            btnEditarNota.Size = new Size(131, 73);
            btnEditarNota.TabIndex = 3;
            btnEditarNota.Text = "Editar Nota";
            btnEditarNota.UseVisualStyleBackColor = true;
            btnEditarNota.Click += btnEditarNota_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(798, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(85, 23);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEditarAsistencia
            // 
            btnEditarAsistencia.Location = new Point(37, 395);
            btnEditarAsistencia.Name = "btnEditarAsistencia";
            btnEditarAsistencia.Size = new Size(131, 73);
            btnEditarAsistencia.TabIndex = 5;
            btnEditarAsistencia.Text = "Editar Asistencia";
            btnEditarAsistencia.UseVisualStyleBackColor = true;
            btnEditarAsistencia.Click += btnEditarAsistencia_Click;
            // 
            // btnResponderSolicitudes
            // 
            btnResponderSolicitudes.Location = new Point(37, 512);
            btnResponderSolicitudes.Name = "btnResponderSolicitudes";
            btnResponderSolicitudes.Size = new Size(131, 73);
            btnResponderSolicitudes.TabIndex = 6;
            btnResponderSolicitudes.Text = "Responder Solicitudes";
            btnResponderSolicitudes.UseVisualStyleBackColor = true;
            btnResponderSolicitudes.Click += btnResponderSolicitudes_Click;
            // 
            // frm_Profesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 644);
            Controls.Add(btnResponderSolicitudes);
            Controls.Add(btnEditarAsistencia);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEditarNota);
            Controls.Add(btnSubirAsistencia);
            Controls.Add(btnSubirNota);
            Name = "frm_Profesor";
            Text = "frm_Profesor";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubirNota;
        private Button btnSubirAsistencia;
        private Button btnEditarNota;
        private Button btnCerrarSesion;
        private Button btnEditarAsistencia;
        private Button btnResponderSolicitudes;
    }
}