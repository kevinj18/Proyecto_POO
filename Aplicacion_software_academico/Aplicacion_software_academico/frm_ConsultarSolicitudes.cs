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

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
    int nWidthEllipse, int nHeightEllipse
);

        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.White; // Fondo limpio y profesional

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel1.BackColor = Color.FromArgb(78, 115, 223); // Azul pastel elegante (coherente con la interfaz general)
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // --- DATAGRIDVIEW SOLICITUDES ---
            dgvSolicitudes.BackgroundColor = Color.White;
            dgvSolicitudes.BorderStyle = BorderStyle.None;
            dgvSolicitudes.EnableHeadersVisualStyles = false;

            // ENCABEZADOS
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 115, 223); // Azul pastel elegante
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgvSolicitudes.ColumnHeadersHeight = 38;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // CELDAS
            dgvSolicitudes.DefaultCellStyle.BackColor = Color.White;
            dgvSolicitudes.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgvSolicitudes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSolicitudes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 255); // Azul muy claro
            dgvSolicitudes.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSolicitudes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS ALTERNADAS
            dgvSolicitudes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252); // Gris suave (casi blanco)

            // BORDES Y LÍNEAS
            dgvSolicitudes.GridColor = Color.FromArgb(230, 233, 240);
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            AplicarEstilos();
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
