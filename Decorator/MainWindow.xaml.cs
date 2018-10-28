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

            this.Height = 650;
            this.Width = 725;
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
        }
    }
}
