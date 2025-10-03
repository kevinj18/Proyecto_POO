using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aplicacion_software_academico.TablasSQL;

namespace Aplicacion_software_academico
{
    public partial class frm_ResponderSolicitudes : Form
    {
        public frm_ResponderSolicitudes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_ResponderSolicitudes_Load(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud();
            dgvSolicitudes.DataSource = solicitud.ObtenerSolicitudesPendientes();

            // Ocultar columnas
            if (dgvSolicitudes.Columns.Contains("id_solicitud"))
            {
                dgvSolicitudes.Columns["id_solicitud"].Visible = false;
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow != null)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["id_solicitud"].Value);

                Solicitud solicitud = new Solicitud();
                solicitud.MarcarSolicitud(idSolicitud, "Aprobada");

                MessageBox.Show("La solicitud fue aprobada.");

                dgvSolicitudes.DataSource = solicitud.ObtenerSolicitudesPendientes();
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow != null)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["id_solicitud"].Value);

                Solicitud solicitud = new Solicitud();
                solicitud.MarcarSolicitud(idSolicitud, "Rechazada");

                MessageBox.Show("La solicitud fue rechazada.");

                dgvSolicitudes.DataSource = solicitud.ObtenerSolicitudesPendientes();
            }
        }
    }
}
