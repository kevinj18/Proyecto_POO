using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_software_academico
{
    public partial class frm_Registrar : Form
    {
        public frm_Registrar()
        {
            InitializeComponent();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelEstudiante.Visible = false;
            panelProfesor.Visible = false;
            panelAdmin.Visible = false;

            if (cmbRol.SelectedItem == null)
                return;

            switch (cmbRol.SelectedItem.ToString())
            {
                case "estudiante":
                    panelEstudiante.Visible = true;
                    break;
                case "profesor":
                    panelProfesor.Visible = true;
                    break;
                case "administrador":
                    panelAdmin.Visible = true;
                    break;
            }
        }

        private void frm_Registrar_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
            cmbRol.Items.Clear();
            // Agregar los roles disponibles
            cmbRol.Items.Add("administrador");
            cmbRol.Items.Add("profesor");
            cmbRol.Items.Add("estudiante");
            cmbRol.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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

                string rol = cmbRol.SelectedItem.ToString().Trim().ToLower();

                TablasSQL.Usuario usuario = new TablasSQL.Usuario();
                //string resultado = usuario.registrarUsuario(nombre, correo, contrasena, rol);

                //MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Usuario usuario = new Usuario();
                //usuario.registrarUsuario(txtNombre.Text.Trim(),
                //                     txtCorreo.Text.Trim(),
                //                     txtContrasena.Text.Trim(),
                //                     cmbRol.SelectedItem.ToString().Trim());

                //MessageBox.Show("Usuario creado exitosamente.");

                string rolUsuario = cmbRol.SelectedItem.ToString();
                if (rolUsuario == "estudiante")
                {
                    string semestre = txtSemestre.Text;
                    DateTime fechaIngreso = dtpFechaIngreso.Value;

                    string resultado = usuario.registrarUsuario(nombre, correo, contrasena, rol,
                                                        semestre, fechaIngreso);
                    MessageBox.Show(resultado);
                }
                else if (rol == "profesor")
                {
                    string especialidad = txtEspecialidad.Text;
                    DateTime fechaContratacion = dtpFehcaContratacion.Value;
                    string resultado = usuario.registrarUsuario(nombre, correo, contrasena, rol,
                                                        null, null, especialidad, fechaContratacion);
                    MessageBox.Show(resultado);
                }

                else if (rol == "administrador")
                {
                    string cargo = txtCargo.Text;

                    string resultado = usuario.registrarUsuario(nombre, correo, contrasena, rol,
                                                        null, null, null, null, cargo);
                    MessageBox.Show(resultado);
                }


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
            cmbRol.Font = new Font("Segoe UI", 10);
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.BackColor = Color.White;
            cmbRol.ForeColor = Color.FromArgb(44, 62, 80); // gris oscuro
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- BOTÓN GUARDAR ---
            btnRegistrar.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnRegistrar.FlatAppearance.BorderSize = 0;

            // Hover y Click
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235); // Hover
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216); // Click

            // Bordes redondeados
            btnRegistrar.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnRegistrar.Width, btnRegistrar.Height, 15, 15)
            );
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
