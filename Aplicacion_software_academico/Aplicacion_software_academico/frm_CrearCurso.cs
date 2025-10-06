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
    }
}
