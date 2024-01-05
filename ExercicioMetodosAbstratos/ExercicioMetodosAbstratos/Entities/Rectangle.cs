using ExercicioMetodosAbstratos.Entities.Enums;

namespace ExercicioMetodosAbstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() 
        { 
        }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public sealed override double Area()
        {
            return Height * Width;
        }
    }
}
