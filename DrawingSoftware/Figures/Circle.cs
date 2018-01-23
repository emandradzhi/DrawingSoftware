using DrawingSoftware.Interfaces;

namespace DrawingSoftware.Shapes
{
    public class Circle : Elipse
    {
        // To draw a circle we need a center point and raidus lentgth
        public Circle(Point center, double radius): base(center, radius)
        {

        }

        public override void CalculateSurfacAarea()
        {
            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
