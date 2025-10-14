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
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.FromArgb(244, 246, 249); // Gris azulado muy claro

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel1.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // --- COMBOBOX ASIGNATURAS ---
            cmbIdAsignatura.Font = new Font("Segoe UI", 10);
            cmbIdAsignatura.FlatStyle = FlatStyle.Flat;
            cmbIdAsignatura.BackColor = Color.White;
            cmbIdAsignatura.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            cmbIdAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- DATAGRIDVIEW NOTAS ---
            dgvNotas.BackgroundColor = Color.White;
            dgvNotas.BorderStyle = BorderStyle.None;
            dgvNotas.EnableHeadersVisualStyles = false;

            // ENCABEZADOS
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 144, 226); // azul pastel
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvNotas.ColumnHeadersHeight = 35;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // CELDAS
            dgvNotas.DefaultCellStyle.BackColor = Color.White;
            dgvNotas.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            dgvNotas.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 255); // azul claro de selección
            dgvNotas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNotas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS ALTERNADAS
            dgvNotas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252); // gris-azulado suave

            // LÍNEAS Y DETALLES
            dgvNotas.GridColor = Color.FromArgb(230, 235, 240); // líneas tenues
            dgvNotas.RowHeadersVisible = false;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void frm_SubirNota_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
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
