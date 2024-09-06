namespace Model
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            if (!IsValid(a, b, c)) throw new ArgumentException();
            SideA = a; SideB = b; SideC = c;
        }
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRectangular()
        {
            double twoSides = Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
            double lastSide = Math.Pow(SideC, 2);

            return twoSides == lastSide;
        }
        public override double GetArea()
        {
            double p = GetPerimetr() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double GetPerimetr()
        {
            return SideA + SideB + SideC;
        }
        private bool IsValid(double a, double b, double c)
        {
            if (a <= 0 && b <= 0 && c <= 0) return false;
            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}