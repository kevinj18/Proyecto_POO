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

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
    int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
    int nWidthEllipse, int nHeightEllipse);

        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.FromArgb(244, 246, 249); // #F4F6F9 - gris azulado muy claro

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel1.BackColor = Color.FromArgb(74, 144, 226); // #4A90E2 - azul pastel
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // --- EFECTO HOVER EN BOTÓN CREAR ---
            btnCrear.MouseEnter += (s, e) => btnCrear.BackColor = Color.FromArgb(60, 130, 210); // azul un poco más fuerte
            btnCrear.MouseLeave += (s, e) => btnCrear.BackColor = Color.FromArgb(74, 144, 226); // vuelve al pastel

            // --- LABELS ---
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.Font = new Font("Segoe UI Semibold", 10);
                    lbl.ForeColor = Color.FromArgb(44, 62, 80); // #2C3E50 gris oscuro elegante
                }
            }

            // --- TEXTBOXES ---
            TextBox[] textBoxes = { txtIdEstudiante, txtIdAsignatura };
            foreach (TextBox txt in textBoxes)
            {
                txt.Font = new Font("Segoe UI", 10);
                txt.BackColor = Color.White;
                txt.ForeColor = Color.FromArgb(44, 62, 80);
                txt.BorderStyle = BorderStyle.FixedSingle;
            }

            // --- COMBOBOX (Tipo) ---
            cmbTipo.Font = new Font("Segoe UI", 10);
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.BackColor = Color.White;
            cmbTipo.ForeColor = Color.FromArgb(44, 62, 80);
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- TEXTAREA (Descripción) ---
            txtDescripcion.Font = new Font("Segoe UI", 10);
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(44, 62, 80);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Multiline = true;

            // --- BOTÓN CREAR ---
            btnCrear.BackColor = Color.FromArgb(74, 144, 226); // azul pastel principal
            btnCrear.ForeColor = Color.White;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.Height = 38;
            btnCrear.Width = 110;
            btnCrear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCrear.Width, btnCrear.Height, 10, 10)); // Bordes curvos suaves
        }


        private void frm_SolicitudRevisioncs_Load(object sender, EventArgs e)
        {
            
            cmbTipo.Items.Clear();

            
            cmbTipo.Items.Add("Revision Nota");
            cmbTipo.Items.Add("Revision Asistencia");

            
            cmbTipo.SelectedIndex = 0;
            AplicarEstilos();
        }
    }
}
