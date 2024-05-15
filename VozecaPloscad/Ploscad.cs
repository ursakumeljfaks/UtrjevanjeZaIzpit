using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VozecaPloscad
{
    public partial class VozecaPloscad : Form
    {
        public VozecaPloscad()
        {
            InitializeComponent();
        }

        private int premik = 10;
        private bool premikanjeDesno = true;

        private void ploscad_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                ploscad.Text = "Gibanje";
            }
            else
            {
                timer.Start();
                ploscad.Text = "Ustavi";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (premikanjeDesno)
            {
                if ((ploscad.Location.X - ploscad.Size.Width) < 300)
                {
                    ploscad.Location = new Point(ploscad.Location.X + premik, ploscad.Location.Y);
                }
                else
                {
                    premikanjeDesno = false;
                }
            }
            else
            {
                if (ploscad.Location.X > premik)
                {
                    ploscad.Location = new Point(ploscad.Location.X - premik, ploscad.Location.Y);
                }
                else
                {
                    premikanjeDesno = true;
                }
            }
        }
    }
}
