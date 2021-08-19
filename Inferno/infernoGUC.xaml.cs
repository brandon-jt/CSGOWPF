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


//https://stackoverflow.com/questions/361209/how-to-open-a-wpf-popup-when-another-control-is-clicked-using-xaml-markup-only
// Try the above 
// Also might need to try making a custom placement for the popup, where I denote it as custom in the xaml and set the properties in this file. 
// Ideally we would create a funciton that passes in the button that was clicked and it would grab whatever picture it corresponds to and
// display it.

// Look into clickactions!

namespace CSGOWPF.Inferno
{
    /// <summary>
    /// Interaction logic for infernoGUC.xaml
    /// </summary>
    public partial class infernoGUC : UserControl
    {
        object MainWindowContent;
        object CalloutContent;
        public infernoGUC(object content, object callContent)
        {
            InitializeComponent();
            MainWindowContent = content;
            CalloutContent = callContent;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = CalloutContent;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Content = MainWindowContent;
        }
    }
}
