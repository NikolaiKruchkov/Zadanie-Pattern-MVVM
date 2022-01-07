using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_MVVM.Models
{
    static class Okr
    {
        public static double RaschetDlina(double a) => 2 * Math.PI * a;
        public static double RaschetPloshad(double a) => Math.PI * Math.Pow(a, 2);
    }
}
