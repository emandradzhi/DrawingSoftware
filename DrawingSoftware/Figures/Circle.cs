using DrawingSoftware.Interfaces;

namespace DrawingSoftware.Shapes
{
    public class Circle : OvalShape, IDraw
    {
        // To draw a circle we need a center point and raidus lentgth
        public Circle(Point center, double radius): base(center, radius)
        {

        }

        public void Draw()
        {
            System.Console.WriteLine("An circle has been drawn");
        }
    }
}
