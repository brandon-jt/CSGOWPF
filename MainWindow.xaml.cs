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
   
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click_toMirage(object sender, RoutedEventArgs e)
        { 
            mirageCUC _mirageCUC = new mirageCUC(Content);
            this.Content = _mirageCUC;
        }

        private void Button_Click_toInferno(object sender, RoutedEventArgs e)
        { 
            infernoCUC _infernoCUC = new infernoCUC(Content);
            this.Content = _infernoCUC;
        }

        private void Button_Click_toDust2(object sender, RoutedEventArgs e)
        {
            Dust2CUC dust2CUC = new Dust2CUC(Content);
            this.Content = dust2CUC;
        }

        private void Button_Click_toNuke(object sender, RoutedEventArgs e)
        {
            Nuke.NukeCUC nukeCUC = new Nuke.NukeCUC(Content);   // change the namespace to CSGOWFP in NukeCUC and add using CSGOWPF.Nuke
            this.Content = nukeCUC;                             //  to shorten the reference and remove the Nuke. reference
        }
        private void Button_Click_toAncient(object sender, RoutedEventArgs e)
        {
            Ancient.AncientCUC ancientCUC = new Ancient.AncientCUC(Content);
            this.Content = ancientCUC;
        }
        private void Button_Click_toVertigo(object sender, RoutedEventArgs e)
        {
            Vertigo.VertigoCUC vertigoCUC = new Vertigo.VertigoCUC(Content);
            this.Content = vertigoCUC;
        }
    }
}
