using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Aplicacion_software_academico.TablasSQL;

namespace Aplicacion_software_academico
{
    public partial class frm_RegistrarUsuario : Form
    {
        //private readonly TablasSQL tablasSQL = new TablasSQL();
        public frm_RegistrarUsuario()

        {

            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        TablasSQL.Usuario usuarioCrear = new TablasSQL.Usuario();

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir diálogo para seleccionar archivo Excel
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos Excel|*.xlsx;*.xls";
                ofd.Title = "Seleccionar archivo de usuarios";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = ofd.FileName;
                    List<Usuario> usuarios = LeerUsuariosDesdeExcel(rutaArchivo);

                    // Aquí puedes mostrar los datos en un DataGridView (opcional)
                    dataGridView1.DataSource = usuarios;

                    // Registrar en base de datos
                    foreach (var u in usuarios)
                    {
                        Console.WriteLine($"Registrando: {u.Nombre} ({u.Rol})");
                        string resultado = TablasSQL.Usuario.registrarUsuario(
                            u.Nombre,
                            u.Correo,
                            u.Contrasena,
                            u.Rol,
                            u.Semestre,
                            u.FechaIngreso,
                            u.Especialidad,
                            u.FechaContratacion,
                            u.Cargo
                        );

                        Console.WriteLine(resultado);
                    }

                    MessageBox.Show("Usuarios cargados y registrados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Usuario> LeerUsuariosDesdeExcel(string rutaArchivo)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            var listaUsuarios = new List<Usuario>();

            using (var stream = File.Open(rutaArchivo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var config = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true // Usa la primera fila como encabezado
                        }
                    };

                    var dataSet = reader.AsDataSet(config);
                    var tabla = dataSet.Tables[0]; // Primera hoja

                    foreach (DataRow row in tabla.Rows)
                    {
                        listaUsuarios.Add(new Usuario
                        {
                            Nombre = row["nombre"].ToString(),
                            Correo = row["correo"].ToString(),
                            Contrasena = row["contrasena"].ToString(),
                            Rol = row["rol"].ToString(),
                            Semestre = row["semestre"].ToString(),
                            FechaIngreso = DateTime.TryParse(row["fecha_ingreso"]?.ToString(), out DateTime fi) ? fi : (DateTime?)null,
                            Especialidad = row["especialidad"].ToString(),
                            FechaContratacion = DateTime.TryParse(row["fecha_contratacion"]?.ToString(), out DateTime fc) ? fc : (DateTime?)null,
                            Cargo = row["cargo"].ToString()
                        });
                    }
                }
            }

            return listaUsuarios;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            btnImportar.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            btnImportar.ForeColor = Color.White;
            btnImportar.FlatStyle = FlatStyle.Flat;
            btnImportar.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnImportar.FlatAppearance.BorderSize = 0;

            // Hover y Click
            btnImportar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235); // Hover
            btnImportar.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216); // Click

            // Bordes redondeados
            btnImportar.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnImportar.Width, btnImportar.Height, 15, 15)
            );
        }
        private void frm_RegistrarUsuario_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
        }
    }
}
