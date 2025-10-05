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

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Registrar formCrearUser = new frm_Registrar();


                formCrearUser.Show();
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
    }
}
