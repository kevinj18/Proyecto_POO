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
    public partial class frm_Estudiantes : Form
    {
        public frm_Estudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que exista sesión
                if (string.IsNullOrEmpty(SesionActual.Correo))
                {
                    MessageBox.Show("Debe iniciar sesión para acceder a esta función.",
                        "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar que el rol sea estudiante
                if (SesionActual.Rol != "estudiante")
                {
                    MessageBox.Show("Solo los estudiantes pueden consultar notas.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Abrir el formulario de consulta de notas
                frm_ConsultarNotas formNotas = new frm_ConsultarNotas();

                // Opcional: pasarle el correo o id del estudiante al constructor
                //formNotas.CorreoEstudiante = SesionActual.Correo;

                formNotas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la consulta de notas: "
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que exista sesión
                if (string.IsNullOrEmpty(SesionActual.Correo))
                {
                    MessageBox.Show("Debe iniciar sesión para acceder a esta función.",
                        "Error de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Validar que el rol sea estudiante
                if (SesionActual.Rol != "estudiante")
                {
                    MessageBox.Show("Solo los estudiantes pueden consultar notas.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Abrir el formulario de consulta de notas
                frm_ConsultarAsistencia formAsistencia = new frm_ConsultarAsistencia();

                // Opcional: pasarle el correo o id del estudiante al constructor
                //formNotas.CorreoEstudiante = SesionActual.Correo;

                formAsistencia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la consulta de notas: "
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
