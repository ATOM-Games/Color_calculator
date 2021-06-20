using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colorito
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void opne_button_Click(object sender, EventArgs e)
        {
            if (OPD.ShowDialog() == DialogResult.OK) {
                this.Kartinka.Image = new Bitmap(OPD.FileName);
            } 
        }

        private void butook_Click(object sender, EventArgs e)
        {

            Color cvet = ((Bitmap)this.Kartinka.Image).GetPixel(int.Parse(X_X.Value + ""), int.Parse(Y_Y.Value + ""));
            this.RGBA_color_label.Text = "[ " + cvet.R + " " + cvet.G + " " + cvet.B + " " + cvet.A + " " + " ]";
            this.color_pipetka.BackColor = cvet;
        }
    }
}
