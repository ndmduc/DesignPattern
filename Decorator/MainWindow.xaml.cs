using System.Windows;

namespace Decorator
{
    using System.Text;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Height = 950;
            this.Width = 925;
            this.GuiUC.DefineText = "Decorator pattern allows a user to add new functionality to an existing object without altering its structure. This pattern creates a decorator class which wraps the original class and provides additional functionality keeping class methods signature intact.";

            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(new Circle());

            IShape redRectangle = new RedShapeDecorator(new Rectangle());

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Circle with normal border" + "\n");
            stringBuilder.Append(circle.Draw());

            stringBuilder.Append("Circle with red border" + "\n");
            stringBuilder.Append(redCircle.Draw());

            stringBuilder.Append("Rectangle with red border" + "\n");
            stringBuilder.Append(redRectangle.Draw());

            this.GuiUC.TextBlockText = stringBuilder.ToString();

            this.GuiUC.TextBlockConsequence = @"Applicability
 To add responsibilities to individual objects dynamically and transparently, that is, without affecting other objects for responsibilities that can be withdrawn
 When extension by sub-classing is impractical. Sometimes a large number of independent extensions are possible and would produce an explosion of subclasses to support every combination. Or a class definition may be hidden or otherwise unavailable for sub-classing
 Consequences
 More flexibility than static inheritance
• Provides a more flexible way to add responsibilities to objects than can be had with static (multiple) inheritance. With decorators responsibilities can be added and removed at runtime simply by attaching and detaching them
 Avoids feature-laden classes high up in the hierarchy
• Offers a pay-as-you-go approach to adding responsibilities. Instead of trying to support all foreseeable features in a complex, customizable class, you can define a simple class and add functionality incrementally with Decorator objects. Functionality can be composed from simple pieces. As a result, an application needn't pay for features it doesn't use
 A decorator and its component aren't identical
• Acts as a transparent enclosure. But from an object identity point of view, a decorated component is not identical to the component itself. Hence you shouldn't rely on object identity when you use decorators
 Lots of little objects
• A design that uses Decorator often results in systems composed of lots of little objects that all look alike. The objects differ only in the way they are interconnected, not in their class or in the value of their variables. Although these systems are easy to customize by those who understand them, they can be hard to learn and debug";
        }
    }
}
