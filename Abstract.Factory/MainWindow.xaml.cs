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

namespace Abstract.Factory
{
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
            this.GuiUC.DefineText = "Abstract Factory patterns work around a super-factory which creates other factories. This factory is also called as factory of factories.";

            var shapeStr = string.Empty;
            // get shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

            //get an object of shape Circle
            var shape1 = shapeFactory.getShap("CIRCLE");
            shapeStr += shape1.Draw() + "\n";

            //get an object of shape Rectange
            var shape2 = shapeFactory.getShap("RECTANGLE");
            shapeStr += shape2.Draw() + "\n";

            //get an object of shape Square
            var shape3 = shapeFactory.getShap("SQUARE");
            shapeStr += shape3.Draw() + "\n";


            var colorStr = string.Empty;
            // get color factory
            AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

            // get an object of color Red
            var color1 = colorFactory.getColor("RED");
            colorStr += color1.Fill() + "\n";

            // get an object of color Green
            var color2 = colorFactory.getColor("GREEN");
            colorStr += color2.Fill() + "\n";

            // get an object of color Blue
            var color3 = colorFactory.getColor("BLUE");
            colorStr += color3.Fill() + "\n";

            this.GuiUC.TextBlockText = shapeStr + colorStr;
        }
    }
}
