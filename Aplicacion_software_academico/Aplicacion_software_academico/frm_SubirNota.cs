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
using static Aplicacion_software_academico.TablasSQL;

namespace Aplicacion_software_academico
{
    public partial class frm_SubirNota : Form
    {
        cConexion conexion = new cConexion();

        public frm_SubirNota()
        {
            InitializeComponent();
        }

        private void frm_SubirNota_Load(object sender, EventArgs e)
        {
            string query = @"
            select e.id_estudiante, u.nombre as nombrecompleto
            from estudiante e
            inner join usuario u on e.id_usuario = u.id_usuario
            where u.rol = 'estudiante'";

            using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbIdEstudiante.DataSource = dt;
                cmbIdEstudiante.DisplayMember = "nombrecompleto";
                cmbIdEstudiante.ValueMember = "id_estudiante";
                conexion.CerrarConexion();
            }

            try
            {
               
                Profesor profesor = new Profesor{ IdProfesor = SesionActual.IdProfesor };

                
                DataTable asignaturas = profesor.ObtenerAsignaturas();

                cmbIdAsignatura.DataSource = asignaturas;
                cmbIdAsignatura.DisplayMember = "nombre";
                cmbIdAsignatura.ValueMember = "id_asignatura";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando asignaturas: " + ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstudiante = Convert.ToInt32(cmbIdEstudiante.SelectedValue);
                int idAsignatura = Convert.ToInt32(cmbIdAsignatura.SelectedValue);
                decimal nota = Convert.ToDecimal(txtNota.Text);

                string query = "insert into Calificacion (id_estudiante, id_asignatura, nota) " +
                               "values (@idEstudiante, @idAsignatura, @nota)";

                using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                    cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                    cmd.Parameters.AddWithValue("@nota", nota);

                    cmd.ExecuteNonQuery();
                }

                conexion.CerrarConexion();
                MessageBox.Show("Nota registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
