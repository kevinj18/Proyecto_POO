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

namespace Aplicacion_software_academico
{
    public partial class frm_SolicitudRevisioncs : Form
    {

        cConexion conexion = new cConexion();
        public frm_SolicitudRevisioncs()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores del formulario
                int idEstudiante = int.Parse(txtIdEstudiante.Text);
                int idAsignatura = int.Parse(txtIdAsignatura.Text);
                string tipo = cmbTipo.SelectedItem.ToString();
                string descripcion = txtDescripcion.Text;

                // Query de inserción
                string query = @"insert into solicitud 
                        (id_estudiante, id_asignatura, tipo, descripcion) 
                        values (@idEstudiante, @idAsignatura, @tipo, @descripcion)";

                using (SqlCommand comando = new SqlCommand(query, conexion.AbrirConexion()))
                {
                    comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                    comando.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                    comando.Parameters.AddWithValue("@tipo", tipo);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);

                    int filas = comando.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Solicitud creada exitosamente. Quedó en estado pendiente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la solicitud.");
                    }
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void frm_SolicitudRevisioncs_Load(object sender, EventArgs e)
        {
            
            cmbTipo.Items.Clear();

            
            cmbTipo.Items.Add("Revision Nota");
            cmbTipo.Items.Add("Revision Asistencia");

            
            cmbTipo.SelectedIndex = 0;
        }
    }
}
