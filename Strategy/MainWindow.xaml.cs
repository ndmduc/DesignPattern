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

namespace Strategy
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
            this.GuiUC.DefineText = "In Strategy pattern, a class behavior or its algorithm can be changed at run time";

            StringBuilder stringBuilder = new StringBuilder();
            Context context = new Context(new OperationAdd());
            stringBuilder.Append(string.Format("10 + 5 = {0}", context.ExecuteStrategy(10, 5)) + "\n");

            context = new Context(new OperationSubstract());
            stringBuilder.Append(string.Format("5 - 3 = {0}", context.ExecuteStrategy(3, 5)) + "\n");

            context = new Context(new OperationMultiply());
            stringBuilder.Append(string.Format("10 * 5 = {0}", context.ExecuteStrategy(10, 5)) + "\n");

            this.GuiUC.TextBlockText = stringBuilder.ToString();
        }
    }
}
