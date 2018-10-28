

// STEP 3
namespace Factory
{
    /// <summary>
    /// The shape factory. Use getSharp method to get object of type sharp
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("Circle"))
            {
                return new Circle();
            }
            
            if (shapeType.Equals("Rectangle"))
            {
                return new Rectangle();
            }

            if (shapeType.Equals("Square"))
            {
                return new Square();
            }

            return null;
        }
    }
}
