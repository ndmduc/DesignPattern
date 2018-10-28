
// STEP 4

namespace Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape)
            : base(decoratedShape)
        {
        }

        public override string Draw()
        {
            return this.decoratedShape.Draw() + "---" + this.SetRedBorder(this.decoratedShape) + "\n";
        }

        private string SetRedBorder(IShape decoratedShape)
        {
            return "Border Color: Red";
        }
    }
}
