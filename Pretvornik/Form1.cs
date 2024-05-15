using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pretvornik
{
    public partial class Pretvornik : Form
    {
        public Pretvornik()
        {
            InitializeComponent();
        }

        private bool programsko = false;

        private void pretvori_Click(object sender, EventArgs e)
        {
            double faktorCmToFt = 0.0328084; // Pretvorba cm v ft
            double faktorFtToCm = 30.48; // Pretvorba ft v cm
            if (vnosFt.Text == "" && vnosInch.Text == "")
            {
                if (vnosCm.Text == "") throw new ArgumentException();
                // Pretvorba iz cm v ft in inch
                double cm = double.Parse(vnosCm.Text);
                double ft = cm * faktorCmToFt;
                double inch = (ft - Math.Floor(ft)) * 12;

                vnosFt.Text = Math.Floor(ft).ToString();
                vnosInch.Text = inch.ToString("0.##");
            }
            else
            {
                // Pretvorba iz ft in inch v cm
                double ft = double.Parse(vnosFt.Text);
                double inch = double.Parse(vnosInch.Text);
                double cm = ft * faktorFtToCm + inch * 2.54;

                vnosCm.Text = cm.ToString("0.##");
            }
        }

        private void vnosCm_TextChanged(object sender, EventArgs e)
        {
            if (!programsko)
            {
                programsko = true;
                vnosFt.Text = string.Empty;
                vnosInch.Text = string.Empty;
                programsko = false;
            }
        }

        private void vnosFt_TextChanged(object sender, EventArgs e)
        {
            if (!programsko)
            {
                programsko = true;
                vnosCm.Text = string.Empty;
                programsko = false;
            }
        }

        private void vnosInch_TextChanged(object sender, EventArgs e)
        {
            if (!programsko)
            {
                programsko = true;
                vnosCm.Text = string.Empty;
                programsko = false;
            }
        }
    }
}
