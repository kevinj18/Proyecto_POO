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
    public partial class frm_CrearCurso : Form
    {
        cConexion conexion = new cConexion();
        public frm_CrearCurso()
        {
            InitializeComponent();
            CargarProfesores();
        }

        private void CargarProfesores()
        {
            string query = @"select p.id_profesor, u.nombre 
                     from Profesor p
                     inner join Usuario u on p.id_usuario = u.id_usuario";

            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbIdProfesor.DisplayMember = "id_profesor";
            cmbIdProfesor.ValueMember = "id_profesor";
            cmbIdProfesor.DataSource = dt;

            conexion.CerrarConexion();
        }

        private void cmbIdProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCurso.Text) ||
                string.IsNullOrWhiteSpace(txtCreditos.Text) ||
                string.IsNullOrWhiteSpace(cmbIdProfesor.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            try
            {
                string nombre = txtNombreCurso.Text.Trim();
                string creditos = txtCreditos.Text.Trim();
                string idProfesor = cmbIdProfesor.Text.Trim();

                TablasSQL.Asignatura Asignatura = new TablasSQL.Asignatura();
                string resultado = Asignatura.registrarAsignatura(idProfesor, nombre, creditos);

                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Usuario usuario = new Usuario();
                //usuario.registrarUsuario(txtNombre.Text.Trim(),
                //                     txtCorreo.Text.Trim(),
                //                     txtContrasena.Text.Trim(),
                //                     cmbRol.SelectedItem.ToString().Trim());

                //MessageBox.Show("Usuario creado exitosamente.");

                // Limpiar campos
                txtNombreCurso.Clear();
                txtCreditos.Clear();
                cmbIdProfesor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
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
            cmbIdProfesor.Font = new Font("Segoe UI", 10);
            cmbIdProfesor.FlatStyle = FlatStyle.Flat;
            cmbIdProfesor.BackColor = Color.White;
            cmbIdProfesor.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            cmbIdProfesor.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- BOTÓN GUARDAR ---
            btnCrearCurso.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            btnCrearCurso.ForeColor = Color.White;
            btnCrearCurso.FlatStyle = FlatStyle.Flat;
            btnCrearCurso.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnCrearCurso.FlatAppearance.BorderSize = 0;

            // Hover y Click
            btnCrearCurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235); // Hover
            btnCrearCurso.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216); // Click

            // Bordes redondeados
            btnCrearCurso.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnCrearCurso.Width, btnCrearCurso.Height, 15, 15)
            );
        }
        private void frm_CrearCurso_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
        }
    }
}
