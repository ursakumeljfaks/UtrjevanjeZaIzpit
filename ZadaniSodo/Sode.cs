using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadaniSodo
{
    public partial class ZadaniSodo : Form
    {
        public ZadaniSodo()
        {
            InitializeComponent();
            timer.Start();
        }

        private int tocke = 0;
        private int stevilo = 0;
        private int stKlikov = 0;
        private void gumbStevilo_Click(object sender, EventArgs e)
        {
            if (int.Parse(gumbStevilo.Text) % 2 == 0) tocke++;
            dosezeneTocke.Text = $"Število doseženih točk: {tocke.ToString()}";
            stKlikov++;
            steviloKlikov.Text = $"Število klikov na gumb: {stKlikov.ToString()}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            stevilo++;
            gumbStevilo.Text = stevilo.ToString();
        }
    }
}
