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

namespace Adapter
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

            AudioPlayer audioPlayer = new AudioPlayer();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(audioPlayer.play("mp3", "beyond the horizon.mp3") + "\n");
            stringBuilder.Append(audioPlayer.play("mp4", "alone.mp4") + "\n");
            stringBuilder.Append(audioPlayer.play("vlc", "far far away.vlc") + "\n");
            stringBuilder.Append(audioPlayer.play("avi", "mind me.avi") + "\n");

            this.GuiUC.TextBlockText = stringBuilder.ToString();

            this.GuiUC.TextBlockConsequence = @" Class adapter
• Adapts Adaptee to Target by committing to a concrete Adapter class. As a consequence, a class adapter won't work when we want to adapt a class and all its subclasses
• Lets Adapter override some of Adaptee's behavior, since Adapter is a subclass of Adaptee 
• Introduces only one object, and no additional pointer indirection is needed to get to the adaptee
 Object adapter
• Lets a single Adapter work with many Adaptees – that is, the Adaptee itself and all of its subclasses (if any). The Adapter can also add functionality to all Adaptees at once
• Makes it harder to override Adaptee behavior. It will require subclassing Adaptee and making Adapter refer to the subclass rather than the Adaptee itself";
        }
    }
}
