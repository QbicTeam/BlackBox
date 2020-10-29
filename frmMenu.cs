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
            var colorEncabezado = Color.FromArgb(255, 148, 0);
            var colorFondoGrid = Color.FromArgb(254, 200, 132);


            grdRelojMarcador.ColumnHeadersDefaultCellStyle.BackColor = colorEncabezado;
            grdRelojMarcador.EnableHeadersVisualStyles = false;
            grdRelojMarcador.BackgroundColor = colorFondoGrid;

            grdRelojMarcador.RowsDefaultCellStyle.BackColor = colorFondoGrid;
            grdRelojMarcador.RowHeadersDefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grdRelojMarcador.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorFondoGrid;
            
            grdRelojMarcador.ScrollBars = ScrollBars.None;
            grdRelojMarcador.ReadOnly = true;
            grdRelojMarcador.RowHeadersVisible = false;
            grdRelojMarcador.DefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grdRelojMarcador.GridColor = colorFondoGrid;


            var json = File.ReadAllText("appSettings.json");
            var datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);

            //var blRelojMarcador = new BindingList<RelojMarcador>(datos.Pantalla1.RelojMarcador);
            //var sRelojMarcador = new BindingSource(blRelojMarcador, null);
            //grdRelojMarcador.DataSource = sRelojMarcador;
            //grdRelojMarcador.data;

            grdRelojMarcador.DataSource = datos.Pantalla1.RelojMarcador;
            grdTest.DataSource = datos.Pantalla1.Eventos;
        }


        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

    }
}
