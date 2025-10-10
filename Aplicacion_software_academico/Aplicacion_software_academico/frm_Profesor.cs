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

        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Limpia el panel antes de agregar un nuevo formulario
            pnlContenedor.Controls.Clear();

            // Configura el formulario para que se comporte como un control
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
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

            InicioSesion frm = new InicioSesion();
            frm.Show();

            this.Close();
        }

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
    }
}
