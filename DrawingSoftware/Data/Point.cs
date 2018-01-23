using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware
{
    public abstract class Point
    {
        //If we work with all of the coordinats, we shal use a Point wich countains a X and Y coordinats

        public double x { get; set; }
        public double y { get; set; }
    }
}
