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
    public partial class frm_SubirAsistencia : Form
    {
        cConexion conexion = new cConexion();
        public frm_SubirAsistencia()
        {
            InitializeComponent();
        }

        private void frm_SubirAsistencia_Load(object sender, EventArgs e)
        {
            CargarMateriasProfesor();
            //Profesor prof = new Profesor(SesionActual.IdProfesor);
            //cmbIdAsignatura.DataSource = prof.ObtenerAsignaturas();
            //cmbIdAsignatura.DisplayMember = "nombre";
            //cmbIdAsignatura.ValueMember = "id_asignatura";

            //cmbEstado.Items.Add("Presente");
            //cmbEstado.Items.Add("Ausente");
            //cmbEstado.Items.Add("Tarde");
        }

        private void CargarMateriasProfesor()
        {
            string query = @"
                SELECT id_asignatura, nombre
                FROM Asignatura
                WHERE id_profesor = @idProfesor";

            SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idProfesor", SesionActual.IdProfesor);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cmbIdAsignatura.DisplayMember = "nombre";
                cmbIdAsignatura.ValueMember = "id_asignatura";
                cmbIdAsignatura.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No tienes asignaturas asignadas.");
            }

            conexion.CerrarConexion();
        }


        private void cmbIdAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdAsignatura.SelectedValue == null) return;

            int idAsignatura = Convert.ToInt32(cmbIdAsignatura.SelectedValue);

            string query = @"
        SELECT a.id_asistencia, e.id_estudiante, u.nombre AS Estudiante,
               a.fecha, a.estado
        FROM Asistencia a
        INNER JOIN Estudiante e ON a.id_estudiante = e.id_estudiante
        INNER JOIN Usuario u ON e.id_usuario = u.id_usuario
        WHERE a.id_asignatura = @idAsignatura
        ORDER BY a.fecha DESC";

            SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Si no hay asistencias registradas, mostrar estudiantes inscritos
            if (dt.Rows.Count == 0)
            {
                // <-- aquí casteamos los NULLs para que el DataTable tenga tipos correctos -->
                query = @"
            SELECT CAST(NULL AS INT) AS id_asistencia,
                   e.id_estudiante,
                   u.nombre AS Estudiante,
                   CAST(NULL AS DATE) AS fecha,
                   CAST(NULL AS VARCHAR(20)) AS estado
            FROM Estudiante_Asignatura ea
            INNER JOIN Estudiante e ON ea.id_estudiante = e.id_estudiante
            INNER JOIN Usuario u ON e.id_usuario = u.id_usuario
            WHERE ea.id_asignatura = @idAsignatura";

                cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }

            // asigno datasource
            dgvAsistencia.DataSource = dt;

            // oculto columnas técnicas si existen
            if (dgvAsistencia.Columns.Contains("id_asistencia"))
                dgvAsistencia.Columns["id_asistencia"].Visible = false;
            if (dgvAsistencia.Columns.Contains("id_estudiante"))
                dgvAsistencia.Columns["id_estudiante"].Visible = false;

            // fecha readonly (no editable)
            if (dgvAsistencia.Columns.Contains("fecha"))
            {
                dgvAsistencia.Columns["fecha"].ReadOnly = true;
            }

            // reemplazar la columna 'estado' por un ComboBox para evitar entrada inválida
            if (dgvAsistencia.Columns.Contains("estado"))
            {
                int idx = dgvAsistencia.Columns["estado"].Index;
                // remover la columna actual
                dgvAsistencia.Columns.Remove("estado");

                var combo = new DataGridViewComboBoxColumn();
                combo.Name = "estado";
                combo.HeaderText = "estado";
                combo.DataPropertyName = "estado"; // enlaza con la columna del DataTable
                combo.Items.AddRange(new string[] { "Presente", "Ausente", "Tarde" });
                combo.FlatStyle = FlatStyle.Flat;

                dgvAsistencia.Columns.Insert(idx, combo);
            }

            conexion.CerrarConexion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbIdAsignatura.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una asignatura.");
                return;
            }

            int idAsignatura = Convert.ToInt32(cmbIdAsignatura.SelectedValue);

            try
            {
                foreach (DataGridViewRow row in dgvAsistencia.Rows)
                {
                    if (row.IsNewRow) continue;

                    // columnas ocultas siempre deben existir en el DataTable
                    int idEstudiante = Convert.ToInt32(row.Cells["id_estudiante"].Value);

                    // estado viene del combo (string)
                    string estado = row.Cells["estado"].Value?.ToString() ?? "Presente";

                    // no usamos la fecha del grid: usamos GETDATE() en SQL
                    string query = @"
                IF EXISTS (
                    SELECT 1 FROM Asistencia
                    WHERE id_estudiante = @idEstudiante
                      AND id_asignatura = @idAsignatura
                      AND CAST(fecha AS DATE) = CAST(GETDATE() AS DATE)
                )
                BEGIN
                    UPDATE Asistencia
                    SET estado = @estado
                    WHERE id_estudiante = @idEstudiante
                      AND id_asignatura = @idAsignatura
                      AND CAST(fecha AS DATE) = CAST(GETDATE() AS DATE)
                END
                ELSE
                BEGIN
                    INSERT INTO Asistencia (id_estudiante, id_asignatura, fecha, estado)
                    VALUES (@idEstudiante, @idAsignatura, GETDATE(), @estado)
                END";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
                    {
                        cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                        cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Asistencias guardadas/actualizadas correctamente.");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error de base de datos: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
