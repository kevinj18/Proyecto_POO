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
                if (ex.Number == 2627) // PK ya existe
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
            cmbAsignatura.Font = new Font("Segoe UI", 10);
            cmbAsignatura.FlatStyle = FlatStyle.Flat;
            cmbAsignatura.BackColor = Color.White;
            cmbAsignatura.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            cmbAsignatura.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- COMBOBOX ESTUDIANTES ---
            cmbEstudiantes.Font = new Font("Segoe UI", 10);
            cmbEstudiantes.FlatStyle = FlatStyle.Flat;
            cmbEstudiantes.BackColor = Color.White;
            cmbEstudiantes.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            cmbEstudiantes.DropDownStyle = ComboBoxStyle.DropDownList;

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
        private void frm_AsignarEstudiante_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
            CargarEstudiantes();
            CargarMaterias();
        }
    }
}
