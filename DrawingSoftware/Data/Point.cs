namespace DrawingSoftware
{
    public class Point
    {
        //If we work with all of the coordinats, we shall use a Point wich countains a X and Y coordinats
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        
        public double X { get; private set; }
        public double Y { get; private set; }
    }
}
