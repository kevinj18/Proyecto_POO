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
            //string query = @"
            //select e.id_estudiante, u.nombre as nombrecompleto
            //from estudiante e
            //inner join usuario u on e.id_usuario = u.id_usuario
            //where u.rol = 'estudiante'";

            //using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    cmbIdEstudiante.DataSource = dt;
            //    cmbIdEstudiante.DisplayMember = "nombrecompleto";
            //    cmbIdEstudiante.ValueMember = "id_estudiante";
            //    conexion.CerrarConexion();
            //}

            try
            {

                Profesor profesor = new Profesor { IdProfesor = SesionActual.IdProfesor };


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
            foreach (DataGridViewRow row in dgvNotas.Rows)
            {
                if (row.IsNewRow) continue;

                int idEstudiante = Convert.ToInt32(row.Cells["id_estudiante"].Value);
                int idAsignatura = Convert.ToInt32(cmbIdAsignatura.SelectedValue);

                decimal nota1 = Convert.ToDecimal(row.Cells["Nota1"].Value);
                decimal nota2 = Convert.ToDecimal(row.Cells["Nota2"].Value);
                decimal nota3 = Convert.ToDecimal(row.Cells["Nota3"].Value);
                decimal nota4 = Convert.ToDecimal(row.Cells["Nota4"].Value);

                string query = @"
                    IF EXISTS (SELECT 1 FROM Calificacion WHERE id_estudiante=@idEstudiante AND id_asignatura=@idAsignatura)
                    UPDATE Calificacion
                    SET nota1=@nota1, nota2=@nota2, nota3=@nota3, nota4=@nota4, fecha_registro=GETDATE()
                    WHERE id_estudiante=@idEstudiante AND id_asignatura=@idAsignatura
                    ELSE
                    INSERT INTO Calificacion (id_estudiante, id_asignatura, nota1, nota2, nota3, nota4)
                    VALUES (@idEstudiante, @idAsignatura, @nota1, @nota2, @nota3, @nota4)";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                cmd.Parameters.AddWithValue("@nota1", nota1);
                cmd.Parameters.AddWithValue("@nota2", nota2);
                cmd.Parameters.AddWithValue("@nota3", nota3);
                cmd.Parameters.AddWithValue("@nota4", nota4);

                cmd.ExecuteNonQuery();
            }

            conexion.CerrarConexion();
            MessageBox.Show("Notas guardadas correctamente.");
        }

        private void cmbIdAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdAsignatura.SelectedValue == null)
                return;

            int idAsignatura;
            if (!int.TryParse(cmbIdAsignatura.SelectedValue.ToString(), out idAsignatura))
                return;

            string query = @"
                SELECT e.id_estudiante, u.nombre AS Estudiante,
                ISNULL(c.nota1, 0) AS Nota1,
                ISNULL(c.nota2, 0) AS Nota2,
                ISNULL(c.nota3, 0) AS Nota3,
                ISNULL(c.nota4, 0) AS Nota4,
                ISNULL(c.nota_final, 0) AS NotaFinal
                FROM Estudiante e
                INNER JOIN Usuario u ON e.id_usuario = u.id_usuario
                INNER JOIN Estudiante_Asignatura ea ON e.id_estudiante = ea.id_estudiante
                LEFT JOIN Calificacion c ON e.id_estudiante = c.id_estudiante 
                AND ea.id_asignatura = c.id_asignatura
                WHERE ea.id_asignatura = @idAsignatura";

            SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvNotas.DataSource = dt;


            conexion.CerrarConexion();
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
