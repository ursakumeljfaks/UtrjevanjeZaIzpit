using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odstevalnik
{
    public partial class Odstevalnik : Form
    {
        public Odstevalnik()
        {
            InitializeComponent();
        }

        private int stevilo = 9;

        private void ponastavi_Click(object sender, EventArgs e)
        {
            if (ponastavi.Enabled)
            {
                stevilo = 9;
                steviloPrikaz.Text = stevilo.ToString();
            }
            
            
        }

        private void ustavi_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ponastavi.Enabled = true;
        }

        private void zacni_Click(object sender, EventArgs e)
        {
            timer.Start();
            ponastavi.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (stevilo == 0)
            {
                stevilo = 0;
                steviloPrikaz.Text = stevilo.ToString();
                zacni.Enabled = false;
                ponastavi.Enabled = true;
            }
            else
            {
                stevilo--;
                steviloPrikaz.Text = stevilo.ToString();
            }
        }
    }
}
