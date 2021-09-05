﻿using System;
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
