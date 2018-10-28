using System.Windows;

namespace Singleton
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

            this.GuiUC.DefineText = "A class of which only a single instance can exist";
            // Illegal constructor because the constructor mark as private.
            // SingleObject singleObject = new SingleObject();

            SingleObject singleObject = SingleObject.GetInstance();

            this.GuiUC.TextBlockText = singleObject.ShowMessage();
            this.GuiUC.TextBlockConsequence = @"    Singleton objects are stored in Heap, but static objects are stored in stack.
    We can clone(if the designer did not disallow it) the singleton object, but we can not clone the static class object .
    Singleton classes follow the OOP(object oriented principles), static classes do not.
    We can implement an interface with a Singleton class, but a class's static methods (or e.g. a C# static class) cannot.";
        }
    }
}
