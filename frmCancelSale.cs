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
    public partial class frmCancelSale : Form
    {
        public frmCancelSale()
        {
            InitializeComponent();
        }

        private void frmCancelSale_Load(object sender, EventArgs e)
        {
            checkBox1.Appearance = Appearance.Button;
            checkBox1.Font = new Font("Microsoft Sans Serif", 16);
            checkBox1.AutoSize = false;
            checkBox1.Size = new Size(100, 100);
        }
    }
}
