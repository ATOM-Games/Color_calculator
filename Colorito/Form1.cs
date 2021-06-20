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
    public partial class Form1 : Form
    {
        public Colories col_1, col_2;

        public Form1()
        {
            InitializeComponent();
            this.col_1 = new Colories();
            this.col_2 = new Colories();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            col_1.SetColories(int.Parse(this.R_1.Value + ""), int.Parse(this.G_1.Value + ""), int.Parse(this.B_1.Value + ""), int.Parse(this.A_1.Value + ""));
            col_2.SetColories(int.Parse(this.R_2.Value + ""), int.Parse(this.G_2.Value + ""), int.Parse(this.B_2.Value + ""), int.Parse(this.A_2.Value + ""));
            this.color_1.BackColor = col_1.get_color();
            this.color_2.BackColor = col_2.get_color();
            this.Back.BackColor = col_1.get_color();
            this.Front.BackColor = col_2.get_color();
            //--------res_1
            Colories res_1 = ColorMath.Summ_method_1(col_1, col_2);
            this.res_1.BackColor = res_1.get_color();
            this.rgba_res_1.Text = res_1.ToString();
            //--------res_2
            Colories res_2 = ColorMath.Summ_method_2(col_1, col_2);
            this.res_2.BackColor = res_2.get_color();
            this.rgba_res_2.Text = res_2.ToString();
            //--------res_3
            Colories res_3 = ColorMath.Summ_method_3(col_1, col_2);
            this.res_3.BackColor = res_3.get_color();
            this.rgba_res_3.Text = res_3.ToString();




        }
    }
}
