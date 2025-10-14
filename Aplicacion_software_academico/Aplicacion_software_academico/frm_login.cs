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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            txtUsuario.TabStop = false;
            txtContrasena.TabStop = false;
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            AplicarEstilosLogin();
            this.ActiveControl = null;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0'; // Desactiva PasswordChar para mostrar el texto
            }
            else
            {
                txtContrasena.PasswordChar = '*'; // Activa PasswordChar si hay texto
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);

        private void AplicarEstilosLogin()
        {
            // --- BOTÓN LOGIN ---
            btnIniciar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnIniciar.Width, btnIniciar.Height, 20, 20));

            // Efecto hover
            btnIniciar.MouseEnter += (s, e) => btnIniciar.BackColor = Color.FromArgb(52, 152, 219); // #3498DB
            btnIniciar.MouseLeave += (s, e) => btnIniciar.BackColor = Color.FromArgb(41, 128, 185);
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.PasswordChar = '*'; // Activa PasswordChar para la contraseña
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0'; // Desactiva PasswordChar para el placeholder
            }
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            TablasSQL.Usuario usuario = new TablasSQL.Usuario();
            //TablasSQL.Estudiante estudiante = new TablasSQL.Estudiante();
            string Usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            string validarUser = usuario.validarUsuario(Usuario, contraseña);

            if (validarUser == "estudiante")
            {
                //SesionActual.Correo = txtUsuario.Text;
                //SesionActual.Rol = "estudiante";

                frm_Estudiantes formEstudiante = new frm_Estudiantes();
                formEstudiante.Show();
                this.Hide();
            }

            //if (validarUser.Equals("estudiante"))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso como Estudiante");
            //    UserActu = txtUsuario.Text;

            //    // abrir la interfaz de estudiante
            //    frm_Estudiantes formEstudiante = new frm_Estudiantes();
            //    formEstudiante.Show();

            //    this.Hide();
            //}
            //if (validarUser.Equals("Correcto"))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso");
            //    UserActu = txtUsuario.Text;
            //}

            else if (validarUser == "profesor")
            {
                frm_Profesor formProfesor = new frm_Profesor();
                formProfesor.Show();
                this.Hide();
            }
            else if (validarUser == "administrador")
            {
                frm_Administrador formAdmin = new frm_Administrador();
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validarUser);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            TablasSQL.Usuario usuario = new TablasSQL.Usuario();
            //TablasSQL.Estudiante estudiante = new TablasSQL.Estudiante();
            string Usuario = txtUsuario.Text;
            string contraseña = txtContrasena.Text;

            string validarUser = usuario.validarUsuario(Usuario, contraseña);

            if (validarUser == "estudiante")
            {
                //SesionActual.Correo = txtUsuario.Text;
                //SesionActual.Rol = "estudiante";

                frm_Estudiantes formEstudiante = new frm_Estudiantes();
                formEstudiante.Show();
                this.Hide();
            }

            //if (validarUser.Equals("estudiante"))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso como Estudiante");
            //    UserActu = txtUsuario.Text;

            //    // abrir la interfaz de estudiante
            //    frm_Estudiantes formEstudiante = new frm_Estudiantes();
            //    formEstudiante.Show();

            //    this.Hide();
            //}
            //if (validarUser.Equals("Correcto"))
            //{
            //    MessageBox.Show("Inicio de sesión exitoso");
            //    UserActu = txtUsuario.Text;
            //}

            else if (validarUser == "profesor")
            {
                frm_Profesor formProfesor = new frm_Profesor();
                formProfesor.Show();
                this.Hide();
            }
            else if (validarUser == "administrador")
            {
                frm_Administrador formAdmin = new frm_Administrador();
                formAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validarUser);
            }
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    public static class SesionActual
    {
        public static string Correo { get; set; }
        public static string Rol { get; set; }
        public static int IdEstudiante { get; set; }
        public static int IdProfesor { get; set; }
        public static int IdAdmin { get; set; }
    }
}
