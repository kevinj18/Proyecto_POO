using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aplicacion_software_academico.TablasSQL;

namespace Aplicacion_software_academico
{
    public partial class frm_AdminCrearUsuario : Form
    {
        public frm_AdminCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            try
            {
                string nombre = txtNombre.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();
                // Normalizo el rol a minúsculas porque tu check en la BD usa minúsculas
                string rol = cmbRol.SelectedItem.ToString().Trim().ToLower();

                TablasSQL.Usuario usuario = new TablasSQL.Usuario();
                string resultado = usuario.registrarUsuario(nombre, correo, contrasena, rol);

                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Usuario usuario = new Usuario();
                //usuario.registrarUsuario(txtNombre.Text.Trim(),
                //                     txtCorreo.Text.Trim(),
                //                     txtContrasena.Text.Trim(),
                //                     cmbRol.SelectedItem.ToString().Trim());

                //MessageBox.Show("Usuario creado exitosamente.");

                // Limpiar campos
                txtNombre.Clear();
                txtCorreo.Clear();
                txtContrasena.Clear();
                cmbRol.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear usuario: " + ex.Message);
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_AdminCrearUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Clear();
            // Agregar los roles disponibles
            cmbRol.Items.Add("administrador");
            cmbRol.Items.Add("profesor");
            cmbRol.Items.Add("estudiante");
            cmbRol.SelectedIndex = 0;
        }
    }
}
