using Course.Entities.Enums;

namespace Course.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; } //Atributo cor e essa cor é uma enumeração

        public Shape(Color color) // Obriga a colocar uma cor que está na enumeração
        {                         // Se colocasse o consultor padrão, que é o consultor sem argumnto ai não precisava colcoar "Color"
            Color = color;
        }

        public abstract double Area(); // Declaramos que essa operação é abstrata
    }
}