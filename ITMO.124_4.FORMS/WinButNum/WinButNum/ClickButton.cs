﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinButNum
{
    class ClickButton:System.Windows.Forms.Button
    {
        int mClicks;
        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            System.Drawing.Graphics g = pevent.Graphics;
            System.Drawing.SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);
            g.DrawString(Clicks.ToString(), this.Font, SystemBrushes.ControlText, this.Width - stringsize.Width - 3, this.Height - stringsize.Height - 3);

        }
    }

}
