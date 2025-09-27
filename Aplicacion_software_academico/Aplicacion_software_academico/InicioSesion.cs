using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicacion_software_academico
{
    public partial class InicioSesion : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sistema_Academico;Trusted_Connection=True;";
        public InicioSesion()
        {
            InitializeComponent();
        }


        private void CargarDatos()
        {
            //using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario";
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                //da.Fill(dt);
                //dgvUsuarios.DataSource = dt;
            }
        }
    }
}
