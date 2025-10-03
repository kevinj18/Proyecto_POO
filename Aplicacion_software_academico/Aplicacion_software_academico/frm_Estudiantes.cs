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

                formNotas.ShowDialog();
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

                formAsistencia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la consulta de notas: "
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void btnSoliRevision_Click(object sender, EventArgs e)
        {
            frm_SolicitudRevisioncs solicitudForm = new frm_SolicitudRevisioncs();

            solicitudForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificamos que el estudiante esté en sesión
                if (SesionActual.Rol == "estudiante" && SesionActual.IdEstudiante > 0)
                {
                    frm_ConsultarSolicitudes frm = new frm_ConsultarSolicitudes();
                    frm.Show();
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

            InicioSesion frm = new InicioSesion();
            frm.Show();

            this.Close();
        }
    }
}
