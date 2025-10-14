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
    public partial class frm_ConsultarAsistencia : Form
    {
        cConexion conexion = new cConexion();

        public frm_ConsultarAsistencia()
        {
            InitializeComponent();
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarAsistencias();
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

            // Insertar opción "Todas"
            if(dt.Rows.Count > 0)
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

        private void MostrarAsistencias()
        {
            
            int? idAsignatura = null;

            if (cmbMaterias.SelectedValue != null &&
                cmbMaterias.SelectedValue != DBNull.Value &&
                !(cmbMaterias.SelectedValue is DataRowView))
            {
                idAsignatura = Convert.ToInt32(cmbMaterias.SelectedValue);
            }

            Asistencia asistencia = new Asistencia();
            var lista = asistencia.ObtenerPorEstudianteYAsignatura(idEstudiante, idAsignatura);

            dgvAsistencias.DataSource = lista;
        }


        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedIndex != -1)
            {
                MostrarAsistencias();
            }
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
    int nWidthEllipse, int nHeightEllipse
);

        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.FromArgb(244, 246, 249); // #F4F6F9 gris azulado muy claro (igual que la pantalla de notas)

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel1.BackColor = Color.FromArgb(74, 144, 226); // #4A90E2 azul pastel (armonía con el sistema)
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // --- ETIQUETAS ---
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Segoe UI", 11, FontStyle.Regular);

            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Font = new Font("Poppins", 16, FontStyle.Bold);

            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);

            // --- COMBOBOX MATERIAS ---
            cmbMaterias.Font = new Font("Segoe UI", 10);
            cmbMaterias.FlatStyle = FlatStyle.Flat;
            cmbMaterias.BackColor = Color.White;
            cmbMaterias.ForeColor = Color.FromArgb(44, 62, 80); // texto gris oscuro
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- DATAGRIDVIEW ASISTENCIA ---
            dgvAsistencias.BackgroundColor = Color.White;
            dgvAsistencias.BorderStyle = BorderStyle.None;
            dgvAsistencias.EnableHeadersVisualStyles = false;

            // ENCABEZADOS
            dgvAsistencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 144, 226); // azul pastel
            dgvAsistencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAsistencias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvAsistencias.ColumnHeadersHeight = 35;
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // CELDAS
            dgvAsistencias.DefaultCellStyle.BackColor = Color.White;
            dgvAsistencias.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            dgvAsistencias.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvAsistencias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 255); // azul claro de selección
            dgvAsistencias.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAsistencias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS ALTERNADAS
            dgvAsistencias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252); // gris-azulado suave

            // LÍNEAS Y DETALLES
            dgvAsistencias.GridColor = Color.FromArgb(230, 235, 240); // líneas tenues
            dgvAsistencias.RowHeadersVisible = false;
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void frm_ConsultarAsistencia_Load(object sender, EventArgs e)
        {
            CargarMaterias(idEstudiante);
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AplicarEstilos();
        }
    }
}
