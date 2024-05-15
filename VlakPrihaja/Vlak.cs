using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VlakPrihaja
{
    public partial class VlakPrihaja : Form
    {
        public VlakPrihaja()
        {
            InitializeComponent();
            kvadrat1.BackColor = Color.White;
            kvadrat2.BackColor = Color.White;
        }

        private bool izmenjava = false;

        private void zacni_Click(object sender, EventArgs e)
        {
            timer.Start();
            izmenjava = false;
        }

        private void ustavi_Click(object sender, EventArgs e)
        {
            timer.Stop();
            kvadrat1.BackColor = Color.White;
            kvadrat2.BackColor = Color.White;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!izmenjava)
            {
                kvadrat1.BackColor = Color.Red;
                kvadrat2.BackColor = Color.White;
                izmenjava = true;
            }
            else
            {
                kvadrat2.BackColor = Color.Red;
                kvadrat1.BackColor = Color.White;
                izmenjava = false;
            }
        }
    }
}
