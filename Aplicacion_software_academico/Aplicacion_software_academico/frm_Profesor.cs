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

        private void btnSubirNota_Click(object sender, EventArgs e)
        {
            try
            {
                frm_SubirNota formSubirNota = new frm_SubirNota();


                formSubirNota.Show();
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


                formSubirAsistencia.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de subir asistencia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            try
            {
                frm_EditarNota formEditarNota = new frm_EditarNota();


                formEditarNota.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de editar nota: " + ex.Message,
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

        private void btnEditarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                frm_EditarAsistencia formEditarAsistencia = new frm_EditarAsistencia();


                formEditarAsistencia.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de editar asistencia: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResponderSolicitudes_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ResponderSolicitudes formSolicitud = new frm_ResponderSolicitudes();


                formSolicitud.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de responder solicitud: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
