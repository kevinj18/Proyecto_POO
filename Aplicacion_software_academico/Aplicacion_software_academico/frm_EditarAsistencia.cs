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
    public partial class frm_EditarAsistencia : Form
    {
        public frm_EditarAsistencia()
        {
            InitializeComponent();
        }

        private void frm_EditarAsistencia_Load(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor { IdProfesor = SesionActual.IdProfesor };
            cmbIdAsignatura.DataSource = profesor.ObtenerAsignaturas();
            cmbIdAsignatura.DisplayMember = "nombre";
            cmbIdAsignatura.ValueMember = "id_asignatura";
            cmbIdAsignatura.SelectedIndex = -1;

            // Opciones de estado
            cmbNuevoEstado.Items.AddRange(new string[] { "Presente", "Ausente", "Tarde" });
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
        }

        private void cmbIdEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdEstudiante.SelectedValue != null && cmbIdAsignatura.SelectedValue != null &&
                int.TryParse(cmbIdEstudiante.SelectedValue.ToString(), out int idEstudiante) &&
                int.TryParse(cmbIdAsignatura.SelectedValue.ToString(), out int idAsignatura))
            {
                Asistencia asistencia = new Asistencia();
                DataTable dt = asistencia.ObtenerAsistenciasPorEstudianteYAsignatura(idEstudiante, idAsignatura);

                dgvAsistencias.DataSource = dt;
                if (dgvAsistencias.Columns.Contains("id_asistencia"))
                {
                    dgvAsistencias.Columns["id_asistencia"].Visible = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.CurrentRow != null && cmbNuevoEstado.SelectedItem != null)
            {
                int idAsistencia = Convert.ToInt32(dgvAsistencias.CurrentRow.Cells["id_asistencia"].Value);
                string nuevoEstado = cmbNuevoEstado.SelectedItem.ToString();

                Asistencia asistencia = new Asistencia();
                if (asistencia.ModificarAsistencia(idAsistencia, nuevoEstado))
                {
                    MessageBox.Show("Asistencia modificada correctamente");

                    // Esto es para refrescar el DataGridView
                    cmbIdEstudiante_SelectedIndexChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Error al modificar asistencia");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila en el DataGridView y un estado nuevo");
            }
        }
    }
}
