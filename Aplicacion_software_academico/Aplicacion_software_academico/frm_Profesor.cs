using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_software_academico
{
    public partial class frm_Profesor : Form
    {
        public frm_Profesor()
        {
            InitializeComponent();
        }

        private async void AbrirFormularioEnPanel(Form formularioHijo)
        {
            try
            {
                pnlContenedor.Controls.Clear();

                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.None; // importante para controlar posición
                formularioHijo.Location = new Point(pnlContenedor.Width, 0); // empieza fuera del panel
                formularioHijo.Size = pnlContenedor.Size;

                pnlContenedor.Controls.Add(formularioHijo);
                formularioHijo.Show();

                // --- Animación de desplazamiento ---
                int targetX = 0;
                int speed = 40; // velocidad del movimiento
                while (formularioHijo.Left > targetX)
                {
                    formularioHijo.Left -= speed;
                    await Task.Delay(10); // tiempo entre cada movimiento
                }

                formularioHijo.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubirNota_Click(object sender, EventArgs e)
        {
            try
            {
                frm_SubirNota formSubirNota = new frm_SubirNota();


                AbrirFormularioEnPanel(formSubirNota);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de subir nota: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubirAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                frm_SubirAsistencia formSubirAsistencia = new frm_SubirAsistencia();


                AbrirFormularioEnPanel(formSubirAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de subir asistencia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionActual.Correo = null;
            SesionActual.Rol = null;
            SesionActual.IdEstudiante = 0;
            SesionActual.IdProfesor = 0;

            frm_login frm = new frm_login();
            frm.Show();

            this.Close();
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        private void btnResponderSolicitudes_Click(object sender, EventArgs e)
        {

            try
            {
                frm_ResponderSolicitudes formSolicitud = new frm_ResponderSolicitudes();


                AbrirFormularioEnPanel(formSolicitud);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de responder solicitud: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Profesor_Load(object sender, EventArgs e)
        {
            AplicarEstiloBoton(btnSubirNota);
            AplicarEstiloBoton(btnSubirAsistencia);
            AplicarEstiloBoton(btnResponderSolicitudes);
            //AplicarEstiloBoton(btnCerrar);
        }

        private void AplicarEstiloBoton(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = Color.FromArgb(30, 64, 175); // Azul principal
            boton.ForeColor = Color.White;
            boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235); // Hover
            boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216); // Click
            boton.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            boton.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, boton.Width, boton.Height, 20, 20) // 🔹 Bordes curvos
            );
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SesionActual.Correo = null;
            SesionActual.Rol = null;
            SesionActual.IdEstudiante = 0;
            SesionActual.IdProfesor = 0;

            frm_login frm = new frm_login();
            frm.Show();

            this.Close();
        }
    }
}
