using CSGOWPF.Ancient;
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

namespace CSGOWPF.Ancient
{
    /// <summary>
    /// Interaction logic for AncientCUC.xaml
    /// </summary>
    public partial class AncientCUC : UserControl
    {
        object MainWindowContent;

        public AncientCUC(object content)
        {
            InitializeComponent();
            MainWindowContent = content;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = MainWindowContent;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AncientGUC _AncientGUC = new AncientGUC(MainWindowContent, this.Content);
            this.Content = _AncientGUC;
        }
    }
}

