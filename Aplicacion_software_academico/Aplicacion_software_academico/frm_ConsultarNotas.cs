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
    public partial class frm_ConsultarNotas : Form
    {
        cConexion conexion = new cConexion();

        public frm_ConsultarNotas()
        {
            InitializeComponent();
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedIndex != -1)
            {
                MostrarNotas();
            }
        }

        int idEstudiante = new Estudiante().ObtenerIdEstudiantePorCorreo(SesionActual.Correo);
        private void CargarMaterias(int idEstudiante)
        {
            string query = @"SELECT a.id_asignatura, a.nombre
                     FROM Asignatura a
                     INNER JOIN Estudiante_Asignatura ea ON a.id_asignatura = ea.id_asignatura
                     WHERE ea.id_estudiante = @idEstudiante";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();
                row["id_asignatura"] = DBNull.Value;
                row["nombre"] = "Todas";
                dt.Rows.InsertAt(row, 0);
            }
            // Primero configuro DisplayMember(Es la columna de la tabla en este caso el nombre de la asignatura) y ValueMember(Es la columna con el id de la asignatura)
            cmbMaterias.DisplayMember = "nombre";
            cmbMaterias.ValueMember = "id_asignatura";

            // Luego asigno el DataSource
            cmbMaterias.DataSource = dt;


        }

        private void MostrarNotas()
        {
            //int idEstudiante = new Estudiante().ObtenerIdEstudiantePorCorreo(SesionActual.Correo);
            int? idAsignatura = null;

            if (cmbMaterias.SelectedValue != null &&
                cmbMaterias.SelectedValue != DBNull.Value &&
                !(cmbMaterias.SelectedValue is DataRowView))
            {
                idAsignatura = Convert.ToInt32(cmbMaterias.SelectedValue);
            }

            Calificacion calificacion = new Calificacion();
            var lista = calificacion.ObtenerPorEstudianteYAsignatura(idEstudiante, idAsignatura);

            dgvNotas.DataSource = lista;

        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarNotas();
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
    int nWidthEllipse, int nHeightEllipse
);

        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.FromArgb(244, 246, 249); // #F4F6F9 gris azulado muy claro

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel1.BackColor = Color.FromArgb(74, 144, 226); // #4A90E2 azul pastel
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // --- COMBOBOX MATERIAS ---
            cmbMaterias.Font = new Font("Segoe UI", 10);
            cmbMaterias.FlatStyle = FlatStyle.Flat;
            cmbMaterias.BackColor = Color.White;
            cmbMaterias.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro

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
            dgvNotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 255); // azul muy claro
            dgvNotas.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvNotas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS ALTERNADAS
            dgvNotas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252); // gris-azulado suave

            // LÍNEAS Y DETALLES
            dgvNotas.GridColor = Color.FromArgb(230, 235, 240);
            dgvNotas.RowHeadersVisible = false;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void frm_ConsultarNotas_Load(object sender, EventArgs e)
        {
            CargarMaterias(idEstudiante);
            AplicarEstilos();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
