using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicacion_software_academico
{
    public partial class InicioSesion : Form
    {
        public static string UserActu { get; set; }
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            TablasSQL.Usuario usuario = new TablasSQL.Usuario();
            string Usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            string validarUser = usuario.validarUsuario(Usuario, contraseña);

            if (validarUser.Equals("Correcto"))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                UserActu = txtUsuario.Text;
            }
            else
            {
                MessageBox.Show(validarUser);
            }
        }
    }
}
