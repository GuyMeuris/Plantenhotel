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

namespace Plantenhotel
{
    /// <summary>
    /// Interaction logic for Menukeuze.xaml
    /// </summary>
    public partial class Menukeuze : Page
    {
        public Menukeuze()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Recensies r = new Recensies(naam.Text, recens.Text);
            MessageBox.Show("Uw recensie is opgeslagen.");
            naam.Text = string.Empty;
            recens.Text = string.Empty;
        }
    }
}
