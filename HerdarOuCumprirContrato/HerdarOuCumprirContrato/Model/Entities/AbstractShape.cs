using HerdarOuCumprirContrato.Model.Enums;

namespace HerdarOuCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
