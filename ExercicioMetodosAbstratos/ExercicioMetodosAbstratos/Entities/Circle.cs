using ExercicioMetodosAbstratos.Entities.Enums;
using System;

namespace ExercicioMetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() 
        { 
        }

        public Circle(Color color, double radius) : base(color) 
        {
            Radius = radius;
        }

        public override double Area()
        {
            double pi = Math.PI;
            return pi * Math.Pow(Radius, 2);
        }
    }
}
