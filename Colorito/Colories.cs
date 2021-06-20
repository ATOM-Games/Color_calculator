using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Colorito
{
    public class Colories
    {
        public int R_c, G_c, B_c, A_c;

        public Colories() { }
        public Colories(int r, int g, int b, int a)
        {
            this.SetColories(r,g,b,a);
        }
        public void SetColories(int r, int g, int b, int a)
        {
            this.R_c = r;
            this.G_c = g;
            this.B_c = b;
            this.A_c = a;
        }

        public Color get_color() {
            return Color.FromArgb(A_c, R_c, G_c, B_c);
        }
        public override string ToString()
        {
            return "[ " + this.R_c + " " + this.G_c + " " + this.B_c + " " + this.A_c + " " + " ]";
        }
    }
}
