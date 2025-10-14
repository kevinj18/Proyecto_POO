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

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.FromArgb(244, 246, 249); // Gris azulado muy claro

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel2.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 15, 15));

            // --- COMBOBOX ASIGNATURAS ---
            cmbIdAsignatura.Font = new Font("Segoe UI", 10);
            cmbIdAsignatura.FlatStyle = FlatStyle.Flat;
            cmbIdAsignatura.BackColor = Color.White;
            cmbIdAsignatura.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            cmbIdAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- DATAGRIDVIEW ASISTENCIA ---
            dgvAsistencia.BackgroundColor = Color.White;
            dgvAsistencia.BorderStyle = BorderStyle.None;
            dgvAsistencia.EnableHeadersVisualStyles = false;

            // ENCABEZADOS
            dgvAsistencia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 144, 226); // azul pastel
            dgvAsistencia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAsistencia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAsistencia.ColumnHeadersHeight = 35;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // CELDAS
            dgvAsistencia.DefaultCellStyle.BackColor = Color.White;
            dgvAsistencia.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            dgvAsistencia.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAsistencia.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 255); // azul claro de selección
            dgvAsistencia.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAsistencia.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS ALTERNADAS
            dgvAsistencia.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252); // gris-azulado suave

            // LÍNEAS Y DETALLES
            dgvAsistencia.GridColor = Color.FromArgb(230, 235, 240); // líneas tenues
            dgvAsistencia.RowHeadersVisible = false;
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- BOTÓN GUARDAR ---
            btnGuardar.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnGuardar.FlatAppearance.BorderSize = 0;

            // Hover y Click
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235); // Hover
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216); // Click

            // Bordes redondeados
            btnGuardar.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnGuardar.Width, btnGuardar.Height, 15, 15)
            );
        }


        private void frm_SubirAsistencia_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
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


            dgvAsistencia.DataSource = dt;

            // oculto columnas técnicas si existen
            if (dgvAsistencia.Columns.Contains("id_asistencia"))
                dgvAsistencia.Columns["id_asistencia"].Visible = false;
            if (dgvAsistencia.Columns.Contains("id_estudiante"))
                dgvAsistencia.Columns["id_estudiante"].Visible = false;


            if (dgvAsistencia.Columns.Contains("fecha"))
            {
                dgvAsistencia.Columns["fecha"].ReadOnly = true;
            }


            if (dgvAsistencia.Columns.Contains("estado"))
            {
                int idx = dgvAsistencia.Columns["estado"].Index;
                // remover la columna actual
                dgvAsistencia.Columns.Remove("estado");

                var combo = new DataGridViewComboBoxColumn();
                combo.Name = "estado";
                combo.HeaderText = "estado";
                combo.DataPropertyName = "estado";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencia.Rows)
            {
                if (row.Cells["fecha"].Value != null &&
                    Convert.ToDateTime(row.Cells["fecha"].Value).Date != DateTime.Today)
                {
                    row.ReadOnly = true;
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }
    }
}
