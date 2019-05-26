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

namespace Observer
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
            this.GuiUC.DefineText = "Adapter pattern works as a bridge between two incompatible interfaces.";

            Subject subject = new Subject();
            var binary = new BinaryObserver(subject);
            var octal = new OctalObserver(subject);

            subject.SetState(15);

            subject.SetState(200);
        }
    }
}
