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
            this.GuiUC.DefineText = "Bridge is used when we need to decouple an abstraction from its implementation so that the two can vary independently. avoid a permanent binding between an abstraction and its implementation. This might be the case, for example, when the implementation must be selected or switched at run - time";

            Shape redCircle = new Circle(10, 10, 10, new RedCircle());
            var redDrawed = redCircle.Draw();

            Shape greenCircle = new Circle(10, 10, 10, new GreenCircle());
            var greenDrawed = greenCircle.Draw();

            var result = redDrawed + "\n" + greenDrawed;
            this.GuiUC.TextBlockText = result;

            this.GuiUC.TextBlockConsequence = @" Decoupling interface and implementation
• An implementation is not bound permanently to an interface. The implementation of an abstraction can be configured at run-time. It's even possible for an object to change its implementation at run-time
• Decoupling Abstraction and Implementor also eliminates compile-time dependencies on the implementation. Changing an implementation class doesn't require recompiling the Abstraction class and its clients. This property is essential when you must ensure binary compatibility between different versions of a class library
 Improved extensibility
• You can extend the Abstraction and Implementor hierarchies independently
 Hiding implementation details from clients
• You can shield clients from implementation details, like the sharing of Implementor objects and the accompanying reference count mechanism (if any)";
        }
    }
}
