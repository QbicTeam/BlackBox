﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox
{
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        public bool PaySale()
        {
            bool result = false;

            this.ShowDialog();

            result = true;

            return result;
        }
    }
}
