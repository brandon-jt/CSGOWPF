using CSGOWPF.Mirage;
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




namespace CSGOWPF
{
    /// <summary>
    /// Interaction logic for mirageUC.xaml
    /// </summary>
    public partial class mirageCUC : UserControl
    {
        object MainWindowContent;
        public mirageCUC(object content)
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
            mirageGUC _mirageGUC = new mirageGUC(MainWindowContent, this.Content);
            this.Content = _mirageGUC;
        }
    }
}
