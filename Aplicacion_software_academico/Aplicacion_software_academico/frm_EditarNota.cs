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
    public partial class frm_EditarNota : Form
    {
        public frm_EditarNota()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbNotas.SelectedValue != null && decimal.TryParse(txtNuevaNota.Text, out decimal nuevaNota))
            {
                int idCalificacion = Convert.ToInt32(cmbNotas.SelectedValue);

                Calificacion cal = new Calificacion();
                if (cal.ModificarNota(idCalificacion, nuevaNota))
                {
                    MessageBox.Show("Nota modificada correctamente");
                    cmbIdEstudiante_SelectedIndexChanged(null, null);
                }
                else
                {
                    MessageBox.Show("Error al modificar la nota");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una nota y escribir un valor válido");
            }
        }

        private void frm_EditarNota_Load(object sender, EventArgs e)
        {
            try
            {
                Profesor profesor = new Profesor { IdProfesor = SesionActual.IdProfesor };

                DataTable asignaturas = profesor.ObtenerAsignaturas();

                cmbIdAsignatura.DataSource = asignaturas;
                cmbIdAsignatura.DisplayMember = "nombre";
                cmbIdAsignatura.ValueMember = "id_asignatura";
                cmbIdAsignatura.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asignaturas: " + ex.Message);
            }

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
                // Cargar notas existentes del estudiante en esa asignatura
                Calificacion cal = new Calificacion();
                DataTable dtNotas = cal.ObtenerNotasPorEstudianteYAsignatura(idEstudiante, idAsignatura);

                cmbNotas.DataSource = dtNotas;
                cmbNotas.DisplayMember = "nota";
                cmbNotas.ValueMember = "id_calificacion";
                cmbNotas.SelectedIndex = -1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
