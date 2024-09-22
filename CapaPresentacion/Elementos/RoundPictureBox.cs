using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CapaPresentacion
{
    class RoundPictureBox : PictureBox
    {
        public RoundPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (GraphicsPath grpath = new GraphicsPath())
            {
                grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(grpath);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Para bordes suaves
            base.OnPaint(pe);
        }
    }
}
