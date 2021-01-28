using BlackBox.Bussiness;
using BlackBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    public partial class frmCortes : Form
    {
        UsersManager userM = new UsersManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);
        VentasManager vtaM = new VentasManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);

        public frmCortes()
        {
            InitializeComponent();
            PrepareForm();
        }

        private void PrepareForm()
        {
            Reset();
            LoadInitialData();
        }

        private void Reset()
        {
            cboReportes.SelectedIndex = -1;
            cboCajeros.SelectedIndex = -1;
            cmdEjecutarRep.Enabled = false;
            cmdCerrar.Visible = false;

            grdVentas.DataSource = null;
            
        }
        private void cmdEjecutarRep_Click(object sender, EventArgs e)
        {
            decimal ventaTotal = 0;

            if (cboReportes.Text == "Corte Z")
                grdCorteZ.Visible = true;
            else
                grdCorteZ.Visible = false;

            List<Venta> vtas;
            CorteZ cortez;
            switch (cboReportes.Text)
            {
                case "Ventas (Todas)":
                    vtas = vtaM.GetVentas(ref ventaTotal);
                    grdVentas.DataSource = vtas;
                    //lblTotalVentas.Text = cortez.VentaTotal.ToString("C");
                    break;
                case "Por Cajero (Corte)":
                    vtas = vtaM.GetVentasCajero(cboCajeros.Text.Trim(), ref ventaTotal);
                    grdVentas.DataSource = vtas;
                    //lblTotalVentas.Text = cortez.VentaTotal.ToString("C");
                    break;
                case "Ventas sin Corte":
                    vtas = vtaM.GetVentasSinCorte(ref ventaTotal);
                    grdVentas.DataSource = vtas;
                    //lblTotalVentas.Text = cortez.VentaTotal.ToString("C");
                    break;
                case "Corte Z":
                    cortez = vtaM.GetCorteZ();
                    grdCorteZ.DataSource = cortez.Productos;
                    ventaTotal = cortez.VentaTotal;
                    
                    break;
            }

            
            lblTotalVentas.Text = ventaTotal.ToString("C");


            if (cboReportes.Text.ToLower() == "por cajero (corte)" || cboReportes.Text.ToLower() == "corte z")
                cmdCerrar.Visible = true;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de Cerrar el Corte?", "Cerrar Corte", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if (cboReportes.Text.ToLower() == "por cajero (corte)")
                vtaM.CerrarCorteCajero(cboCajeros.Text, 1);

            if (cboReportes.Text.ToLower() == "corte z")
            {
                vtaM.DeleteVentas();
                // Crear JSON, Mandar el JSON por FTP
            }
                


        }

        private void cboCajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
           // User user = (User)cboCajeros.SelectedItem; // (User)sender;

            if (cboCajeros.SelectedIndex > 0)
                cmdEjecutarRep.Enabled = true;
        }

        private void cboReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCajeros.Enabled = false;
            cmdEjecutarRep.Enabled = false;
            cmdCerrar.Visible = false;

            if (string.IsNullOrEmpty(cboReportes.Text))
                return;

            if (cboReportes.Text == "Por Cajero (Corte)")
                cboCajeros.Enabled = true;
            else
                cmdEjecutarRep.Enabled = true;

            Reset();
            cboCajeros.Enabled = false;
            cmdEjecutarRep.Enabled = false;
            cmdCerrar.Visible = false;
            grdCorteZ.Visible = false;
            lblTotalVentas.Text = "";

        }

        private void LoadInitialData()
        {
            var colorEncabezado = Color.FromArgb(254, 159, 49); // 255, 148, 0
            var colorFondoGrid = Color.FromArgb(254, 200, 132);

            cboCajeros.Enabled = false;
            cmdEjecutarRep.Enabled = false;
            cmdCerrar.Visible = false;
            grdCorteZ.Visible = false;
            lblTotalVentas.Text = "";


            cboCajeros.Items.Clear();
            List<User> users = userM.GetUsersList();

            cboCajeros.Items.Add(new User { Id = 0, Nombre = "" });

            foreach (var itm in users)
            {
                if (itm.Status == "Activo")
                    cboCajeros.Items.Add(itm);
            }

            cboCajeros.DisplayMember = "Nombre";
            cboCajeros.ValueMember = "Id";

            //cboReportes

            AplicarFormato(grdVentas, colorEncabezado, colorFondoGrid);

            grdVentas.Columns[0].Width = 200;
            grdVentas.Columns[1].Width = 100;
            grdVentas.Columns[2].Width = 100;
            grdVentas.Columns[3].Width = 100;
            grdVentas.Columns[4].Width = 100;
            grdVentas.Columns[5].Width = 100;
            

            AplicarFormato(grdCorteZ, colorEncabezado, colorFondoGrid);

            grdCorteZ.Columns[0].Width = 400;
            grdCorteZ.Columns[1].Width = 150;
            grdCorteZ.Columns[2].Width = 150;

        }

        private void AplicarFormato(DataGridView grd, Color colorEncabezado, Color colorFondoGrid)
        {
            grd.ColumnHeadersDefaultCellStyle.BackColor = colorEncabezado;
            grd.EnableHeadersVisualStyles = false;
            grd.BackgroundColor = colorFondoGrid;

            grd.RowsDefaultCellStyle.BackColor = colorFondoGrid;
            grd.RowHeadersDefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grd.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorFondoGrid;
            //grd.ColumnHeadersDefaultCellStyle.Font = new Font(grd.Font.FontFamily.Name, 7, FontStyle.Regular);
            //grd.DefaultCellStyle.Font = new Font(grd.Font.FontFamily.Name, 7, FontStyle.Regular);
            grd.ColumnHeadersDefaultCellStyle.Font = new Font(grd.Font.FontFamily.Name, 8, FontStyle.Regular);
            grd.DefaultCellStyle.Font = new Font(grd.Font.FontFamily.Name, 7, FontStyle.Regular);
            grd.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);

            grd.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grd.RowTemplate.Height = 17;

            grd.ScrollBars = ScrollBars.None;
            grd.ReadOnly = true;
            grd.RowHeadersVisible = false;
            //grd.ColumnHeadersVisible = false;
            grd.DefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grd.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
            grd.GridColor = colorFondoGrid;
            //grd.AllowUserToResizeColumns = false;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grd.AllowUserToResizeRows = false;
            grd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grd.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            //grd.BorderStyle = BorderStyle.None;
        }

    }
}
