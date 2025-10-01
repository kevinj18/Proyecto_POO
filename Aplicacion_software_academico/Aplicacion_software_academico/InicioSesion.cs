using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicacion_software_academico
{
    public static class SesionActual
    {
        public static string Correo { get; set; }
        public static string Rol { get; set; }
        public static int IdEstudiante { get; set; }
    }
    public partial class InicioSesion : Form
    {
        

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
            //TablasSQL.Estudiante estudiante = new TablasSQL.Estudiante();
            string Usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            string validarUser = usuario.validarUsuario(Usuario, contraseña);

            if (validarUser == "estudiante")
            {
                SesionActual.Correo = txtUsuario.Text;
                SesionActual.Rol = "estudiante";
                
                frm_Estudiantes formEstudiante = new frm_Estudiantes();
                formEstudiante.Show();
                this.Hide();
            }

            //if (validarUser.Equals("estudiante"))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso como Estudiante");
            //    UserActu = txtUsuario.Text;

            //    // abrir la interfaz de estudiante
            //    frm_Estudiantes formEstudiante = new frm_Estudiantes();
            //    formEstudiante.Show();

            //    this.Hide();
            //}
            //if (validarUser.Equals("Correcto"))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso");
            //    UserActu = txtUsuario.Text;
            //}
            else
            {
                MessageBox.Show(validarUser);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
