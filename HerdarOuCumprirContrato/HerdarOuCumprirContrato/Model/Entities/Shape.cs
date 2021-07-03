using HerdarOuCumprirContrato.Model.Enums;

namespace HerdarOuCumprirContrato.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
