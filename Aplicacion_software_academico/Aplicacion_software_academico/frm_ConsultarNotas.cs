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
    public partial class frm_ConsultarNotas : Form
    {
        cConexion conexion = new cConexion();

        public frm_ConsultarNotas()
        {
            InitializeComponent();
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedIndex != -1)
            {
                MostrarNotas();
            }
        }

        private void CargarMaterias()
        {
            SqlCommand comando = new SqlCommand("SELECT id_asignatura, nombre FROM Asignatura", conexion.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Insertar opción "Todas"
            DataRow row = dt.NewRow();
            row["id_asignatura"] = DBNull.Value;
            row["nombre"] = "Todas";
            dt.Rows.InsertAt(row, 0);

            // Primero configuro DisplayMember(Es la columna de la tabla en este caso el nombre de la asignatura) y ValueMember(Es la columna con el id de la asignatura)
            cmbMaterias.DisplayMember = "nombre";
            cmbMaterias.ValueMember = "id_asignatura";

            // Luego asigno el DataSource
            cmbMaterias.DataSource = dt;

            
        }

        private void MostrarNotas()
        {
            int idEstudiante = new Estudiante().ObtenerIdEstudiantePorCorreo(SesionActual.Correo);
            int? idAsignatura = null;

            if (cmbMaterias.SelectedValue != null &&
                cmbMaterias.SelectedValue != DBNull.Value &&
                !(cmbMaterias.SelectedValue is DataRowView))
            {
                idAsignatura = Convert.ToInt32(cmbMaterias.SelectedValue);
            }

            Calificacion calificacion = new Calificacion();
            var lista = calificacion.ObtenerPorEstudianteYAsignatura(idEstudiante, idAsignatura);

            dgvNotas.DataSource = lista;
            
        }

        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarNotas();
        }

        private void frm_ConsultarNotas_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
