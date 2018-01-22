using DrawingSoftware.Interfaces;

namespace DrawingSoftware.Shapes
{
    public class Circle : OvalShape, IDraw
    {
        public Circle(double x, double y, double radius) : base(x, y, radius)
        {
            
        }

        public void Draw()
        {
            System.Console.WriteLine("A Circle has been drawn");
        }
    }
}
