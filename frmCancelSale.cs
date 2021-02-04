using BlackBox.Bussiness;
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
    public partial class frmCancelSale : Form
    {
        private VentasManager vtasManager = new VentasManager(ConfigurationManager.ConnectionStrings["FBBCS"].ConnectionString);

        public frmCancelSale()
        {
            InitializeComponent();
        }

        private void frmCancelSale_Load(object sender, EventArgs e)
        {

        }
    }
}
