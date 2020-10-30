using BlackBox.Model;
using Newtonsoft.Json;
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

namespace BlackBox
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var colorEncabezado = Color.FromArgb(254, 159, 49); // 255, 148, 0
            var colorFondoGrid = Color.FromArgb(254, 200, 132);

            // Definicion de Tamaños y formatos
            AplicarFormato(grdRelojMarcador, colorEncabezado, colorFondoGrid);

            grdRelojMarcador.Columns[0].Width = 55;
            grdRelojMarcador.Columns[1].Width = 55;
            grdRelojMarcador.Columns[2].Width = 55;
            grdRelojMarcador.Columns[3].Width = 55;

            AplicarFormato(grdEventos, colorEncabezado, colorFondoGrid);

            AplicarFormato(grdHorario, colorEncabezado, colorFondoGrid);
            AplicarFormato(grdTrabajando, colorEncabezado, colorFondoGrid);
            AplicarFormato(grdEventos, colorEncabezado, colorFondoGrid);
            AplicarFormato(grdMensajeria, colorEncabezado, colorFondoGrid);
            grdMensajeria.DefaultCellStyle.Font = new Font(grdMensajeria.Font.FontFamily.Name, 7, FontStyle.Bold);
            

            // Lectura de Datos.
            var json = File.ReadAllText("appSettings.json");
            var datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);


            // Asignacion de Valores.
            grdRelojMarcador.DataSource = datos.Pantalla1.RelojMarcador;
            grdHorario.DataSource = datos.Pantalla1.Horario;
            grdTrabajando.DataSource = datos.Pantalla1.TrabajandoHoy;
            grdMensajeria.DataSource = datos.Pantalla1.Mesajeria;
            grdEventos.DataSource = datos.Pantalla1.Eventos;

            var it = datos.Pantalla1.TrabajandoHoy.Count();
            for (var i = 1; i <= it; i++)
            {
                this.Controls.Add(
                    new PictureBox() {
                        Image = picBox.Image,
                        Size = picBox.Size,
                        Visible = true,
                        Location = new Point(picBox.Location.X, picBox.Location.Y + (14 * i))
                });
                //PictureBox p1 = new PictureBox();
                //p1.Image = picBox.Image;
                //p1.Size = picBox.Size;
                //p1.Visible = true;
                //p1.Location = new Point(picBox.Location.X + 20, picBox.Location.Y + 20);
                // this.Controls.Add(p1);
            }



        }

        private void AplicarFormato(DataGridView grd, Color colorEncabezado, Color colorFondoGrid)
        {
            grd.ColumnHeadersDefaultCellStyle.BackColor = colorEncabezado;
            grd.EnableHeadersVisualStyles = false;
            grd.BackgroundColor = colorFondoGrid;

            grd.RowsDefaultCellStyle.BackColor = colorFondoGrid;
            grd.RowHeadersDefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grd.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grd.ColumnHeadersDefaultCellStyle.Font = new Font(grd.Font.FontFamily.Name, 7,FontStyle.Regular);
            grd.DefaultCellStyle.Font = new Font(grd.Font.FontFamily.Name, 7, FontStyle.Regular);

            grd.ScrollBars = ScrollBars.None;
            grd.ReadOnly = true;
            grd.RowHeadersVisible = false;
            grd.DefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grd.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            grd.GridColor = colorFondoGrid;
            grd.AllowUserToResizeColumns = false;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grd.AllowUserToResizeRows = false;
            grd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grd.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
        }
    }
}
