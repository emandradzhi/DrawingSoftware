using DrawingSoftware.Interfaces;

namespace DrawingSoftware.Shapes
{
    public class Circle : OvalShape, IDraw
    {
        public Circle(Point center, double radius) 
                            : base(center, radius)
        {
         
        }

        public void Draw()
        {
            
            System.Console.WriteLine(((_center.x - _radius)+_center.y +"A Circle has been drawn"));
        }
    }
}
