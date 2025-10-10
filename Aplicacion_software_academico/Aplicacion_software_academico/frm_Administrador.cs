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
    public partial class frm_Administrador : Form
    {
        public frm_Administrador()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Limpia el panel antes de agregar un nuevo formulario
            pnlContenedor.Controls.Clear();

            // Configura el formulario para que se comporte como un control
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agrega el formulario al panel y lo muestra
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Registrar formCrearUser = new frm_Registrar();


                AbrirFormularioEnPanel(formCrearUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de crear usuario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionActual.Correo = null;
            SesionActual.Rol = null;
            SesionActual.IdEstudiante = 0;
            SesionActual.IdProfesor = 0;
            SesionActual.IdAdmin = 0;

            InicioSesion frm = new InicioSesion();
            frm.Show();

            this.Close();
        }

        private void btnAsignarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AsignarEstudiante formAsigEstudiante = new frm_AsignarEstudiante();

                AbrirFormularioEnPanel(formAsigEstudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de crear usuario: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            try
            {
                frm_CrearCurso formCrearCurso = new frm_CrearCurso();
                AbrirFormularioEnPanel(formCrearCurso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de crear asignatura: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
