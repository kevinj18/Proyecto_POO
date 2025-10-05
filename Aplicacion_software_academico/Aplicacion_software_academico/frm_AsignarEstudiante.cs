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
    public partial class frm_AsignarEstudiante : Form
    {
        cConexion conexion = new cConexion();
        public frm_AsignarEstudiante()
        {
            InitializeComponent();
        }

        private void CargarEstudiantes()
        {
            string query = @"select e.id_estudiante, u.nombre 
                     from Estudiante e
                     inner join Usuario u on e.id_usuario = u.id_usuario";

            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbEstudiantes.DisplayMember = "nombre";
            cmbEstudiantes.ValueMember = "id_estudiante";
            cmbEstudiantes.DataSource = dt;

            conexion.CerrarConexion();
        }

        private void CargarMaterias()
        {
            string query = "select id_asignatura, nombre from Asignatura";

            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbAsignatura.DisplayMember = "nombre";
            cmbAsignatura.ValueMember = "id_asignatura";
            cmbAsignatura.DataSource = dt;

            conexion.CerrarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEstudiantes.SelectedValue == null || cmbAsignatura.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un estudiante y una materia.");
                return;
            }

            int idEstudiante = Convert.ToInt32(cmbEstudiantes.SelectedValue);
            int idAsignatura = Convert.ToInt32(cmbAsignatura.SelectedValue);

            try
            {
                string query = @"INSERT INTO Estudiante_Asignatura (id_estudiante, id_asignatura)
                         VALUES (@idEstudiante, @idAsignatura)";

                SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);

                comando.ExecuteNonQuery();

                MessageBox.Show("Estudiante asignado correctamente a la materia.");
                conexion.CerrarConexion();

                // Refrescar inscripciones
                CargarInscripciones(idAsignatura);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // PK violada → ya existe
                {
                    MessageBox.Show("Este estudiante ya está inscrito en la materia seleccionada.");
                }
                else
                {
                    MessageBox.Show("Error al asignar: " + ex.Message);
                }
            }
        }

        private void CargarInscripciones(int idAsignatura)
        {
            string query = @"select u.nombre AS Estudiante
                     from Estudiante_Asignatura ea
                     inner join Estudiante e ON ea.id_estudiante = e.id_estudiante
                     inner join Usuario u ON e.id_usuario = u.id_usuario
                     where ea.id_asignatura = @idAsignatura";

            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvInscripciones.DataSource = dt;

            conexion.CerrarConexion();
        }

        private void frm_AsignarEstudiante_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarMaterias();
        }
    }
}
