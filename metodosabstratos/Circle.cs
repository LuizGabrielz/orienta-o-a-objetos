using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Circle : Shape // Herdar de Shape também
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        { // Color vem da classe Shape e Radius da classe Circles
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}