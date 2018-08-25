using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public static class Validate
    {
        public static bool IsNumber(string txt)
        {
            Regex objRegex = new Regex(@"^[0-9]*$");
            return objRegex.IsMatch(txt);
        }
    }
}
