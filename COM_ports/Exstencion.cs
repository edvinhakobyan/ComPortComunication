using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace COM_ports
{
    public static class Exstencion
    {
        public static string GetPort(this string name)
        {
            return new string(name.SkipWhile(t => t != '(').Skip(1).TakeWhile(t => t != ')').ToArray());
        }
    }
}
