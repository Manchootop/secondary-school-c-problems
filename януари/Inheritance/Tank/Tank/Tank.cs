namespace Tank
{
    class Tank
    {
        private double radius;
        private double height;

        public Tank(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public double Radius { get { return radius; } set { radius = value < 0 ? value : value; } }
        public double Height { get { return height; } set { height = value < 0 ? value : value; } }

        public override string ToString()
        {
            return $"The radius of the tank is: {Radius} and the height is: {Height}.";
        }
    }
}