using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public static class Extensions
    {
        public static double GetArea(this Figure figure)
        {
            return figure.GetArea();
        }
    }
}
