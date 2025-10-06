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
    public partial class frm_SubirAsistencia : Form
    {
        public frm_SubirAsistencia()
        {
            InitializeComponent();
        }

        private void frm_SubirAsistencia_Load(object sender, EventArgs e)
        {
            Profesor prof = new Profesor(SesionActual.IdProfesor);
            cmbIdAsignatura.DataSource = prof.ObtenerAsignaturas();
            cmbIdAsignatura.DisplayMember = "nombre";
            cmbIdAsignatura.ValueMember = "id_asignatura";

            cmbEstado.Items.Add("Presente");
            cmbEstado.Items.Add("Ausente");
            cmbEstado.Items.Add("Tarde");
        }

        private void cmbIdAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdAsignatura.SelectedValue != null && int.TryParse(cmbIdAsignatura.SelectedValue.ToString(), out int idAsignatura))
            {
                Estudiante est = new Estudiante();
                DataTable dt = est.ObtenerEstudiantesPorAsignatura(idAsignatura);
                if (dt.Rows.Count > 0)
                {
                    cmbIdEstudiante.DataSource = dt;
                    cmbIdEstudiante.DisplayMember = "nombrecompleto";
                    cmbIdEstudiante.ValueMember = "id_estudiante";
                }
                else
                {
                    // Limpia el combo si no hay estudiantes
                    cmbIdEstudiante.DataSource = null;
                    cmbIdEstudiante.Items.Clear();
                    cmbIdEstudiante.Text = string.Empty;
                }
            }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbIdEstudiante.SelectedValue != null && cmbIdAsignatura.SelectedValue != null && cmbEstado.SelectedItem != null)
            {
                Asistencia asistencia = new Asistencia
                {
                    IdEstudiante = Convert.ToInt32(cmbIdEstudiante.SelectedValue),
                    IdAsignatura = Convert.ToInt32(cmbIdAsignatura.SelectedValue),
                    Fecha = dtpFecha.Value.Date,
                    Estado = cmbEstado.SelectedItem.ToString()
                };

                Asistencia dao = new Asistencia();
                if (dao.RegistrarAsistencia(asistencia))
                {
                    MessageBox.Show("Asistencia registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar asistencia.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar todos los campos.");
            }
        }
    }
}
