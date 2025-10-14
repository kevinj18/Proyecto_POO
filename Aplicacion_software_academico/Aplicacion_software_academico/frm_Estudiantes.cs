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
    public partial class frm_Estudiantes : Form
    {
        public frm_Estudiantes()
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que exista sesión
                if (string.IsNullOrEmpty(SesionActual.Correo))
                {
                    MessageBox.Show("Debe iniciar sesión para acceder a esta función.",
                        "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar que el rol sea estudiante
                if (SesionActual.Rol != "estudiante")
                {
                    MessageBox.Show("Solo los estudiantes pueden consultar notas.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Abrir el formulario de consulta de notas
                frm_ConsultarNotas formNotas = new frm_ConsultarNotas();

                // Opcional: pasarle el correo o id del estudiante al constructor
                //formNotas.CorreoEstudiante = SesionActual.Correo;

                AbrirFormularioEnPanel(formNotas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la consulta de notas: "
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultAsistencia_Click(object sender, EventArgs e)
        {

            try
            {
                // 1. Validar que exista sesión
                if (string.IsNullOrEmpty(SesionActual.Correo))
                {
                    MessageBox.Show("Debe iniciar sesión para acceder a esta función.",
                        "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar que el rol sea estudiante
                if (SesionActual.Rol != "estudiante")
                {
                    MessageBox.Show("Solo los estudiantes pueden consultar notas.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Abrir el formulario de consulta de notas
                frm_ConsultarAsistencia formAsistencia = new frm_ConsultarAsistencia();

                // Opcional: pasarle el correo o id del estudiante al constructor
                //formNotas.CorreoEstudiante = SesionActual.Correo;

                AbrirFormularioEnPanel(formAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la consulta de notas: "
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse
);


        private void frm_Estudiantes_Load(object sender, EventArgs e)
        {
            AplicarEstiloBoton(btnConsutNota);
            AplicarEstiloBoton(btnConsultAsistencia);
            AplicarEstiloBoton(btnSoliRevision);
            AplicarEstiloBoton(btnConsultRevision);
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


        private void btnSoliRevision_Click(object sender, EventArgs e)
        {
            frm_SolicitudRevisioncs solicitudForm = new frm_SolicitudRevisioncs();
            AbrirFormularioEnPanel(solicitudForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificamos que el estudiante esté en sesión
                if (SesionActual.Rol == "estudiante" && SesionActual.IdEstudiante > 0)
                {
                    frm_ConsultarSolicitudes frm = new frm_ConsultarSolicitudes();
                    AbrirFormularioEnPanel(frm);
                }
                else
                {
                    MessageBox.Show("Solo los estudiantes pueden consultar solicitudes.",
                                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de solicitudes: " + ex.Message,
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
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
