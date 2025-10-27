using ExcelDataReader;
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
    public partial class frm_AsignarEst : Form
    {
        cConexion conexion = new cConexion();
        public frm_AsignarEst()
        {
            InitializeComponent();
        }

        private void frm_AsignarEst_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de Excel (*.xlsx;*.xls)|*.xlsx;*.xls",
                Title = "Seleccionar archivo con asignaciones"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                try
                {
                    using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet result = reader.AsDataSet();
                        DataTable tabla = result.Tables[0];

                        int registrosInsertados = 0;
                        cConexion conexion = new cConexion();

                        for (int i = 1; i < tabla.Rows.Count; i++) // Saltar encabezado
                        {
                            try
                            {
                                int idEstudiante = Convert.ToInt32(tabla.Rows[i][0]);
                                int idAsignatura = Convert.ToInt32(tabla.Rows[i][1]);

                                string query = "INSERT INTO Estudiante_Asignatura (id_estudiante, id_asignatura) VALUES (@idEstudiante, @idAsignatura)";
                                using (SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion()))
                                {
                                    cmd.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                                    cmd.Parameters.AddWithValue("@idAsignatura", idAsignatura);
                                    cmd.ExecuteNonQuery();
                                    registrosInsertados++;
                                }
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 2627) // Duplicado
                                    continue;
                            }
                            catch { }
                        }

                        conexion.CerrarConexion();
                        MessageBox.Show($"Se asignaron {registrosInsertados} estudiantes correctamente.");

                        // Mostrar en el DataGridView
                        CargarAsignacionesEnGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al importar: " + ex.Message);
                }
            }
        }
        private DataTable LeerExcelAsignaciones(string rutaArchivo)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    return dataSet.Tables[0];
                }
            }
        }
        private void CargarAsignacionesEnGrid()
        {
            try
            {
                cConexion conexion = new cConexion();

                string query = @"
            SELECT 
                e.id_estudiante AS [ID Estudiante],
                uE.nombre AS [Estudiante],
                a.id_asignatura AS [ID Asignatura],
                a.nombre AS [Materia],
                uP.nombre AS [Profesor]
            FROM Estudiante_Asignatura ea
            INNER JOIN Estudiante e ON ea.id_estudiante = e.id_estudiante
            INNER JOIN Usuario uE ON e.id_usuario = uE.id_usuario
            INNER JOIN Asignatura a ON ea.id_asignatura = a.id_asignatura
            INNER JOIN Profesor p ON a.id_profesor = p.id_profesor
            INNER JOIN Usuario uP ON p.id_usuario = uP.id_usuario
            ORDER BY uE.nombre;";

                SqlDataAdapter da = new SqlDataAdapter(query, conexion.AbrirConexion());
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.CerrarConexion();

                dgvAsignaciones.DataSource = dt;
                dgvAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAsignaciones.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las asignaciones: " + ex.Message);
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
        int nWidthEllipse, int nHeightEllipse);
        private void AplicarEstilos()
        {
            // --- FONDO GENERAL ---
            this.BackColor = Color.FromArgb(244, 246, 249); // Gris azulado muy claro

            // --- PANEL SUPERIOR (ENCABEZADO) ---
            panel1.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 15, 15));

            // --- BOTÓN GUARDAR ---
            btnCargar.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            btnCargar.ForeColor = Color.White;
            btnCargar.FlatStyle = FlatStyle.Flat;
            btnCargar.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnCargar.FlatAppearance.BorderSize = 0;

            // Hover y Click
            btnCargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235); // Hover
            btnCargar.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216); // Click

            // Bordes redondeados
            btnCargar.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnCargar.Width, btnCargar.Height, 15, 15)
            );
        }

        private void dgvInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
