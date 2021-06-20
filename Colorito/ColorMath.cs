using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colorito
{
    class ColorMath
    {
        static public Colories Summ_method_1(Colories c1, Colories c2)
        {
            int r = (c1.R_c + c2.R_c > 255) ? 255 : c1.R_c + c2.R_c;
            int g = (c1.G_c + c2.G_c > 255) ? 255 : c1.G_c + c2.G_c;
            int b = (c1.B_c + c2.B_c > 255) ? 255 : c1.B_c + c2.B_c;
            int a = (c1.A_c + c2.A_c > 255) ? 255 : c1.A_c + c2.A_c;
            //-----
            return new Colories(r,g,b,a);
        }

        static public Colories Summ_method_2(Colories c1, Colories c2)
        {
            int r = (c1.R_c + c2.R_c)/2;
            int g = (c1.G_c + c2.G_c)/2;
            int b = (c1.B_c + c2.B_c)/2;
            int a = (c1.A_c + c2.A_c)/2;
            //-----
            return new Colories(r, g, b, a);
        }
        static public Colories Summ_method_3(Colories c1, Colories c2) {
            float aa = c2.A_c * 1f / 255f;
            float na = 1 - aa;

            int r = (int)(c1.R_c * na + c2.R_c * aa);
            int g = (int)(c1.G_c * na + c2.G_c * aa);
            int b = (int)(c1.B_c * na + c2.B_c * aa);
            return new Colories(r, g, b, 255);
        }
    }
}
