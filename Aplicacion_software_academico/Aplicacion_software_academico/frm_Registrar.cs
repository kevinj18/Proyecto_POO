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
                case "Estudiante":
                    panelEstudiante.Visible = true;
                    break;
                case "Profesor":
                    panelProfesor.Visible = true;
                    break;
                case "Administrador":
                    panelAdmin.Visible = true;
                    break;
            }
        }
    }
}
