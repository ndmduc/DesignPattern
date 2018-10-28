using System.Windows.Controls;
using System.Xaml;

namespace WindowsTemplate
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for Gui.xaml
    /// </summary>
    public partial class Gui : UserControl
    {
        /// <summary>
        /// The image source property.
        /// </summary>
        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
            "ImageSource",
            typeof(System.Windows.Media.ImageSource),
            typeof(Gui),
            null);

        /// <summary>
        /// The text block text property.
        /// </summary>
        public static readonly DependencyProperty TextBlockTextProperty = DependencyProperty.Register(
            "TextBlockText",
            typeof(string),
            typeof(Gui),
            null);

        /// <summary>
        /// The text block define property.
        /// </summary>
        public static readonly DependencyProperty TextBlockDefineProperty = DependencyProperty.Register(
            "DefineText",
            typeof(string),
            typeof(Gui),
            null);

        /// <summary>
        /// The text block consequence property.
        /// </summary>
        public static readonly DependencyProperty TextBlockConsequenceProperty = DependencyProperty.Register(
            "TextBlockConsequence",
            typeof(string),
            typeof(Gui),
            null);

        /// <summary>
        /// Gets or sets the image source.
        /// </summary>
        public object ImageSource
        {
            get { return GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        /// <summary>
        /// Gets or sets the text block text.
        /// </summary>
        public string TextBlockText
        {
            get { return (string)GetValue(TextBlockTextProperty); }
            set { SetValue(TextBlockTextProperty, value); }
        }

        /// <summary>
        /// Gets or sets the define text.
        /// </summary>
        public string DefineText
        {
            get { return (string)GetValue(TextBlockDefineProperty); }
            set { SetValue(TextBlockDefineProperty, value); }
        }

        public string TextBlockConsequence
        {
            get
            {
                return (string)GetValue(TextBlockConsequenceProperty);
            }
            set { SetValue(TextBlockConsequenceProperty, value); }
        }

        public Gui()
        {
            InitializeComponent();
        }
    }
}
