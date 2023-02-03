using Course.Entities.Enums;

namespace Course.Entities
{
    class Rectangle : Shape // Vai herdar da classe Shape
    {
        public double Width { get; set; } // Propiedades do triangulo
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}