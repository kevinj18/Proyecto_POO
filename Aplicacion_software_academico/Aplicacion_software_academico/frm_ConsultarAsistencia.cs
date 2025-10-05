using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aplicacion_software_academico.TablasSQL;

namespace Aplicacion_software_academico
{
    public partial class frm_ConsultarAsistencia : Form
    {
        cConexion conexion = new cConexion();

        public frm_ConsultarAsistencia()
        {
            InitializeComponent();
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarAsistencias();
        }
        int idEstudiante = new Estudiante().ObtenerIdEstudiantePorCorreo(SesionActual.Correo);
        private void CargarMaterias()
        {
            string query = @"SELECT DISTINCT a.id_asignatura, a.nombre
                     FROM Asignatura a
                     INNER JOIN Asistencia asi ON a.id_asignatura = asi.id_asignatura
                     WHERE asi.id_estudiante = @idEstudiante";
            SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion());
            comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Insertar opción "Todas"
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();
                row["id_asignatura"] = DBNull.Value;
                row["nombre"] = "Todas";
                dt.Rows.InsertAt(row, 0);
            }

            // Primero configuro DisplayMember(Es la columna de la tabla en este caso el nombre de la asignatura) y ValueMember(Es la columna con el id de la asignatura)
            cmbMaterias.DisplayMember = "nombre";
            cmbMaterias.ValueMember = "id_asignatura";

            // Luego asigno el DataSource
            cmbMaterias.DataSource = dt;


        }

        private void MostrarAsistencias()
        {
            
            int? idAsignatura = null;

            if (cmbMaterias.SelectedValue != null &&
                cmbMaterias.SelectedValue != DBNull.Value &&
                !(cmbMaterias.SelectedValue is DataRowView))
            {
                idAsignatura = Convert.ToInt32(cmbMaterias.SelectedValue);
            }

            Asistencia asistencia = new Asistencia();
            var lista = asistencia.ObtenerPorEstudianteYAsignatura(idEstudiante, idAsignatura);

            dgvAsistencias.DataSource = lista;
        }


        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedIndex != -1)
            {
                MostrarAsistencias();
            }
        }

        private void frm_ConsultarAsistencia_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
