using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_software_academico
{
    public partial class frm_ConsultarSolicitudes : Form
    {
        int idEstudiante = SesionActual.IdEstudiante;
        cConexion conexion = new cConexion();
        public frm_ConsultarSolicitudes()
        {
            InitializeComponent();
        }

        private void frm_ConsultarSolicitudes_Load(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = SesionActual.IdEstudiante;

                if (idEstudiante > 0)
                {
                    CargarSolicitudes(idEstudiante);
                }
                else
                {
                    MessageBox.Show("No se encontró el ID del estudiante en la sesión.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las solicitudes: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CargarSolicitudes(idEstudiante);

        }

        private void CargarSolicitudes(int idEstudiante)
        {
            string query = "select id_solicitud, tipo, descripcion, estado, fecha " +
                   "from solicitud where id_estudiante = @idEstudiante";

            using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSolicitudes.DataSource = dt; 
            }

            conexion.CerrarConexion();
        }

    }
}
