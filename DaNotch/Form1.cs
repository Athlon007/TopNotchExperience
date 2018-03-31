using System.Drawing;
using System.Windows.Forms;

namespace DaNotch
{
    public partial class Form1 : Form
    {
        int notchWidth = 113;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            TransparencyKey = Color.DimGray;
            notchRight.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            this.TopMost = true;
            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);

            UpdateNotch();
        }

        void Form1_MouseWheel(object sender, MouseEventArgs e)
	    {
            if (e.Delta > 0)
                notchWidth += 10;
            else
                notchWidth -= 10;

            if (notchWidth < 100) notchWidth = 100;

            UpdateNotch();
	    }

        void UpdateNotch()
        {
            notchLeft.Location = new Point(0, 0);
            notchMiddle.Location = new Point(notchLeft.Width, 0);
            notchMiddle.Width = notchWidth;
            notchRight.Location = new Point(notchMiddle.Location.X + notchMiddle.Width, 0);
            this.Width = notchLeft.Width * 2 + notchMiddle.Width;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, 0);
        }
    }
}
