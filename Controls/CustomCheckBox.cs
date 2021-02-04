﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBox.Controls
{
    public class CustomCheckBox: CheckBox
    {
        public override bool AutoSize
        {
            set { base.AutoSize = false; }
            get { return base.AutoSize; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.Height = 100;
            this.Width = 200;
            int squareSide = 80;

            Rectangle rect = new Rectangle(new Point(0, 1), new Size(squareSide, squareSide));

            ControlPaint.DrawCheckBox(e.Graphics, rect, this.Checked ? ButtonState.Checked : ButtonState.Normal);
        }
    }
}
