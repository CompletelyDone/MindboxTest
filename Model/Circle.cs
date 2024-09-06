namespace Model
{
    public class Circle : Shape
    {
        public Circle(double radius) { Radius = radius; }
        public double Radius { get; }

        public override double GetPerimetr()
        {
            return 2 * Radius * Math.PI;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
