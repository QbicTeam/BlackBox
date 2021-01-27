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
    public partial class frmMain : Form
    {
        User _currentUser;
        Form _entryForm;
        private string[] dias = { "Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sab" };

        public frmMain(User loggedUser)
        {
            this._currentUser = loggedUser;
            InitializeComponent();

            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            

            pnlInicio.Location = new Point(15, 96);
            pnlAdmon.Location = new Point(15, 96);
            pnlHorario.Location = new Point(15, 96);
            pnlMensajeria.Location = new Point(15, 96);

            pnlInicio.Height = 622;
            pnlInicio.Width = 958;

            pnlAdmon.Height = 622;
            pnlAdmon.Width = 958;

            pnlHorario.Height = 622;
            pnlHorario.Width = 958;

            pnlMensajeria.Height = 622;
            pnlMensajeria.Width = 958;

            cmdInicio.Location = new Point(22, 690);
            cmdAdmon.Location = new Point(257, 690);
            cmdHorario.Location = new Point(496, 690);
            cmdMensajeria.Location = new Point(738, 690);

            cmdEntrada.Image = imgEntrada.Image;
            cmdImprimir.Image = imgImprimir.Image;
            cmdDisponibilidad.Image = imgDisponibilidad.Image;
            cmdEmpleados.Image = imgEmpleados.Image;
            cmdHorarioV2.Image = imgHorario.Image;
            cmdResumen.Image = imgResumen.Image;
            cmdCompletar.Image = imgCompletar.Image;
            cmdOrdenes.Image = imgOrden.Image;
            cmdMensajeriaV2.Image = imgMensajeria.Image;

            //string[] dias = { "Dom", "Lun", "Mar", "Mie", "Jue", "Vie", "Sab" };
            //var diai = (int)DateTime.Today.DayOfWeek;
            //dia = dias[diai];

            var colorEncabezado = Color.FromArgb(254, 159, 49); // 255, 148, 0
            var colorFondoGrid = Color.FromArgb(254, 200, 132);

            // Definicion de Tamaños y formatos
            AplicarFormato(grdRelojMarcador, colorEncabezado, colorFondoGrid);
            grdRelojMarcador.Size = new Size(272, 88); // Con Headers 272, 115
            grdRelojMarcador.Location = new Point(17, 53); 
            //Con Headers Buena Point(17, 27); Libre Header Point(17, 53) Rows: 50, 27
            grdRelojMarcador.Columns[0].Width = 70;
            grdRelojMarcador.Columns[1].Width = 50;
            grdRelojMarcador.Columns[2].Width = 50;
            grdRelojMarcador.Columns[3].Width = 50;

            //AplicarFormato(grdEventos, colorEncabezado, colorFondoGrid);

            AplicarFormato(grdHorario, colorEncabezado, colorFondoGrid);
            grdHorario.Size = new Size(272, 90); // Con Headers 272, 115
            grdHorario.Location = new Point(17, 245); 
            // Con Headres Buena Point(17, 220); Libre Header 17, 246 Rows: 50, 220
            grdHorario.Columns[0].Width = 70;
            grdHorario.Columns[1].Width = 50;
            grdHorario.Columns[2].Width = 50;
            grdHorario.Columns[3].Width = 50;

            AplicarFormato(grdTrabajando, colorEncabezado, colorFondoGrid);
            grdTrabajando.Size = new Size(272, 140); // Con Headers 272, 164
            grdTrabajando.Location = new Point(17, 407); 
            // Con Headers Buena Point(17, 382); Libre Header 17, 406 Rows: 50, 382
            grdTrabajando.Columns[0].Width = 75;
            grdTrabajando.Columns[1].Width = 70;
            grdTrabajando.Columns[2].Width = 85;

            AplicarFormato(grdEventos, colorEncabezado, colorFondoGrid);
            grdEventos.Size = new Size(222, 152); // Con Headers 222, 177
            grdEventos.Location = new Point(417, 222); 
            // Con Headers Buena Point(417, 197); Libre Header 417, 222 Rows: 457, 197
            grdEventos.Columns[0].Width = 60;
            grdEventos.Columns[1].Width = 135;

            AplicarFormato(grdMensajeria, colorEncabezado, colorFondoGrid);
            grdMensajeria.Size = new Size(388, 97); // Con Headers 406, 122
            grdMensajeria.Location = new Point(417, 53); 
            //Con Headers Buena Point(417, 28); Libre Header 417, 53 Rows: 457, 28
            grdMensajeria.Columns[0].Width = 100;
            grdMensajeria.Columns[1].Width = 150;
            grdMensajeria.Columns[2].Width = 119;

            //grdMensajeria.ScrollBars = ScrollBars.Vertical; // Con Headers
            //grdMensajeria.DefaultCellStyle.Font = new Font(grdMensajeria.Font.FontFamily.Name, 7, FontStyle.Bold);
            grdMensajeria.DefaultCellStyle.Font = new Font(grdMensajeria.Font.FontFamily.Name, 8, FontStyle.Bold);
            grdMensajeria.RowTemplate.Height = 20;

            // Lectura de Datos.
            var json = File.ReadAllText("appSettings.json");
            var datos = JsonConvert.DeserializeObject<ObjBlackBox>(json);

            // lblName.Text = datos.Login.Cajero;
            lblName.Text = this._currentUser.Nombre;

            // Asignacion de Valores.
            grdRelojMarcador.DataSource = datos.Pantalla1.RelojMarcador;
            grdHorario.DataSource = datos.Pantalla1.Horario;
            grdTrabajando.DataSource = datos.Pantalla1.TrabajandoHoy;
            grdMensajeria.DataSource = datos.Pantalla1.Mesajeria;
            grdEventos.DataSource = datos.Pantalla1.Eventos;


            var it = datos.Pantalla1.TrabajandoHoy.Count();
            for (var i = 1; i <= it; i++)
            {
                var nCtrl = new PictureBox()
                {
                    Image = picBox.Image,
                    Size = picBox.Size,
                    Visible = true,
                    Location = new Point(grdTrabajando.Location.X + 5, grdTrabajando.Location.Y + 3 + (16 * (i - 1)))
                    // Location = new Point(grdTrabajando.Location.X + 5, grdTrabajando.Location.Y + 9 + (16 * i)) Con Headers
                    //Location = new Point(picBox.Location.X + 5, picBox.Location.Y + 9 + (16 * i))
                };
                panel1.Controls.Add(nCtrl);
                panel1.Controls.SetChildIndex(nCtrl, 1);
                nCtrl.BringToFront();
            }


        }

        public void ShowMain(Form entryForm, Form loginForm)
        {
            this._entryForm = entryForm;
            loginForm.Close();

            this.Show();
        }

        private void cmdShowPanel(object sender, EventArgs e)
        {
            HidePanels();
            Button btn = (Button)sender;

            if (btn.Name == "cmdInicio") pnlInicio.Show();
            if (btn.Name == "cmdAdmon") pnlAdmon.Show();
            if (btn.Name == "cmdHorario") pnlHorario.Show();
            if (btn.Name == "cmdMensajeria") pnlMensajeria.Show();
        }

        private void HidePanels()
        {

            pnlInicio.Hide();
            pnlAdmon.Hide();
            pnlHorario.Hide();
            pnlMensajeria.Hide();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this._entryForm.Close();
        }

        private void cmdEntrada_MouseEnter(object sender, EventArgs e)
        {
            cmdEntrada.Image = imgHEntrada.Image;
        }

        private void cmdEntrada_MouseLeave(object sender, EventArgs e)
        {
            cmdEntrada.Image = imgEntrada.Image;
        }

        private void cmdImprimir_MouseEnter(object sender, EventArgs e)
        {
            cmdImprimir.Image = imgHImprimir.Image;
        }

        private void cmdImprimir_MouseLeave(object sender, EventArgs e)
        {
            cmdImprimir.Image = imgImprimir.Image;
        }

        private void cmdDisponibilidad_MouseEnter(object sender, EventArgs e)
        {
            cmdDisponibilidad.Image = imgHDisponibilidad.Image;
        }

        private void cmdDisponibilidad_MouseLeave(object sender, EventArgs e)
        {
            cmdDisponibilidad.Image = imgDisponibilidad.Image;
        }

        private void cmdEmpleados_MouseEnter(object sender, EventArgs e)
        {
            cmdEmpleados.Image = imgHEmpleados.Image;
        }

        private void cmdEmpleados_MouseLeave(object sender, EventArgs e)
        {
            cmdEmpleados.Image = imgEmpleados.Image;
        }

        private void cmdHorarioV2_MouseEnter(object sender, EventArgs e)
        {
            cmdHorarioV2.Image = imgHHorario.Image;
        }

        private void cmdHorarioV2_MouseLeave(object sender, EventArgs e)
        {
            cmdHorarioV2.Image = imgHorario.Image;
        }

        private void cmdResumen_MouseEnter(object sender, EventArgs e)
        {
            cmdResumen.Image = imgHResumen.Image;
        }

        private void cmdResumen_MouseLeave(object sender, EventArgs e)
        {
            cmdResumen.Image = imgResumen.Image;
        }

        private void cmdCompletar_MouseEnter(object sender, EventArgs e)
        {
            cmdCompletar.Image = imgHCompletar.Image;
        }

        private void cmdCompletar_MouseLeave(object sender, EventArgs e)
        {
            cmdCompletar.Image = imgCompletar.Image;
        }

        private void cmdOrdenes_MouseEnter(object sender, EventArgs e)
        {
            cmdOrdenes.Image = imgHOrden.Image;
        }

        private void cmdOrdenes_MouseLeave(object sender, EventArgs e)
        {
            cmdOrdenes.Image = imgOrden.Image;
        }

        private void cmdMensajeriaV2_MouseEnter(object sender, EventArgs e)
        {
            cmdMensajeriaV2.Image = imgHMensajeria.Image;
        }

        private void cmdMensajeriaV2_MouseLeave(object sender, EventArgs e)
        {
            cmdMensajeriaV2.Image = imgMensajeria.Image;
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
            grd.ColumnHeadersVisible = false;
            grd.DefaultCellStyle.SelectionBackColor = colorFondoGrid;
            grd.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;            
            grd.GridColor = colorFondoGrid;
            //grd.AllowUserToResizeColumns = false;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grd.AllowUserToResizeRows = false;
            grd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grd.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            grd.BorderStyle = BorderStyle.None;
        }

        private void grdRelojMarcador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdRelojMarcador_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var diai = (int)DateTime.Today.DayOfWeek;
            var dia = dias[diai];

            lblHora.Text = dia + " " + DateTime.Now.ToString("hh:mm") + (DateTime.Now.Hour <= 12 ? "am" : "pm"); // "Lun 11:57 am";  spa-es ddd
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Console.WriteLine(grdMensajeria.Columns[Convert.ToInt32(cnmColumna.Value)].Width);
        //    lblValor.Text = grdMensajeria.Columns[Convert.ToInt32(cnmColumna.Value)].Width.ToString();
        //}

        private void cmdOrdenes_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(this._currentUser);
            menu.SetEntryForm(this._entryForm);
            menu.Show();
            this.Close();
        }

        private void cmdEmpleados_Click(object sender, EventArgs e)
        {
            if (this._currentUser.Puesto == "Administrador")
            {
                frmAdminUsers adminUsers = new frmAdminUsers();
                adminUsers.ShowDialog();

            }
        }

        private void cmdResumen_Click(object sender, EventArgs e)
        {
            if (this._currentUser.Puesto == "Administrador")
            {
                frmCortes cortes = new frmCortes();
                cortes.ShowDialog();

            }
        }
    }
}
