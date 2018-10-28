using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Factory
{
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
            this.GuiUC.DefineText = "In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.";

            StringBuilder stringBuilder = new StringBuilder();

            ShapeFactory shapeFactory = new ShapeFactory();

            // get an object of Circle and call its draw method.
            Factory.IShape shape1 = shapeFactory.GetShape("Circle");

            // call draw method of Circle
            stringBuilder.Append(shape1.Draw() + "\n");

            // get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.GetShape("Rectangle");

            // call draw method of Rectangle
            stringBuilder.Append(shape2.Draw() + "\n");

            // get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.GetShape("Square");

            // call draw method of circle
            stringBuilder.Append(shape3.Draw() + "\n");

            this.GuiUC.TextBlockText = stringBuilder.ToString();
        }
    }
}
