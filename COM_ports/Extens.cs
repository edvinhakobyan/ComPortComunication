using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_ports
{
    public static class Extens
    {
        public static Size Div(this Size size, int div)
        {
            return new Size(size.Height / div, size.Width / div);
        }
    }
}
