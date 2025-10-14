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
    public partial class frm_ResponderSolicitudes : Form
    {
        public frm_ResponderSolicitudes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
            panel2.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 15, 15));

            // --- DATAGRIDVIEW SOLICITUDES ---
            dgvSolicitudes.BackgroundColor = Color.White;
            dgvSolicitudes.BorderStyle = BorderStyle.None;
            dgvSolicitudes.EnableHeadersVisualStyles = false;

            // ENCABEZADOS
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 144, 226); // Azul pastel
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSolicitudes.ColumnHeadersHeight = 35;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // CELDAS
            dgvSolicitudes.DefaultCellStyle.BackColor = Color.White;
            dgvSolicitudes.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Gris oscuro
            dgvSolicitudes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvSolicitudes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 228, 255); // Azul claro selección
            dgvSolicitudes.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSolicitudes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // FILAS ALTERNADAS
            dgvSolicitudes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 252); // Gris-azulado suave

            // LÍNEAS Y DETALLES
            dgvSolicitudes.GridColor = Color.FromArgb(230, 235, 240); // Líneas tenues
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- BOTÓN APROBAR ---
            btnAprobar.BackColor = Color.FromArgb(46, 125, 50); // Verde principal
            btnAprobar.ForeColor = Color.White;
            btnAprobar.FlatStyle = FlatStyle.Flat;
            btnAprobar.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnAprobar.FlatAppearance.BorderSize = 0;
            btnAprobar.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60); // Hover verde más vivo
            btnAprobar.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);  // Click verde más oscuro
            btnAprobar.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnAprobar.Width, btnAprobar.Height, 15, 15)
            );

            // --- BOTÓN RECHAZAR ---
            btnRechazar.BackColor = Color.FromArgb(220, 53, 69); // Rojo principal
            btnRechazar.ForeColor = Color.White;
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.Font = new Font("Segoe UI Semibold", 11, FontStyle.Italic);
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51); // Hover rojo más vivo
            btnRechazar.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 20, 40); // Click rojo más oscuro
            btnRechazar.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, btnRechazar.Width, btnRechazar.Height, 15, 15)
            );
        }



        private void frm_ResponderSolicitudes_Load(object sender, EventArgs e)
        {
            AplicarEstilos();
            Solicitud solicitud = new Solicitud();
            dgvSolicitudes.DataSource = solicitud.ObtenerSolicitudesPendientes();

            // Ocultar columnas
            if (dgvSolicitudes.Columns.Contains("id_solicitud"))
            {
                dgvSolicitudes.Columns["id_solicitud"].Visible = false;
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow != null)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["id_solicitud"].Value);

                Solicitud solicitud = new Solicitud();
                solicitud.MarcarSolicitud(idSolicitud, "Aprobada");

                MessageBox.Show("La solicitud fue aprobada.");

                dgvSolicitudes.DataSource = solicitud.ObtenerSolicitudesPendientes();
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.CurrentRow != null)
            {
                int idSolicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["id_solicitud"].Value);

                Solicitud solicitud = new Solicitud();
                solicitud.MarcarSolicitud(idSolicitud, "Rechazada");

                MessageBox.Show("La solicitud fue rechazada.");

                dgvSolicitudes.DataSource = solicitud.ObtenerSolicitudesPendientes();
            }
        }
    }
}
