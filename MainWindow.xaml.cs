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


// Dont use Margin!
// Start adding the other smoke grenade icons and pictures and see how they line up 

//Popup?
// Try using popups on mirage 
// Make a button to remove the popup, the main point of this is to have an iamge up to be able to see where to smoke obviously

// basically, have the popup appear on click/hover over, popup appears, along with back button.
// Hit the back button, and it removes both the popup and the back button

// The inferno GUC works for now, but I'd rather click the grenade icon then have a popup that stays and a back button

// Look clickactions

namespace CSGOWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    // Don't use NavigationService, that is only for pages
    // Need to figure out way to pass reference of current window into functions
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
