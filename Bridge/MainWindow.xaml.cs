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

namespace Bridge
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
            this.GuiUC.DefineText = "Bridge is used when we need to decouple an abstraction from its implementation so that the two can vary independently.";

            Shape redCircle = new Circle(10, 10, 10, new RedCircle());
            var redDrawed = redCircle.Draw();

            Shape greenCircle = new Circle(10, 10, 10, new GreenCircle());
            var greenDrawed = greenCircle.Draw();

            var result = redDrawed + "\n" + greenDrawed;
            this.GuiUC.TextBlockText = result;
        }
    }
}
