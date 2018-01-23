using DrawingSoftware.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingSoftware.Shapes
{
    public abstract class Elipse : OvalShape,IDraw
    {
        //To draw an elipse we need a center point with X and Y and a radius point with X and Y

        public Elipse(Point x, double fociA, double fociB,double distance) : base(x,fociA,fociB,distance)
        {
            
        }
        public Elipse(Point center, double radius) : base(center,radius)
        {

        }

        public void Draw()
        {
            Console.WriteLine("An elipse has been drawn");
        }
    }
}
