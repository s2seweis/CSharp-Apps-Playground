﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Constructor for initialize
        public MainWindow()
        {
            // Initializes all the components of a user interface defined in the XAML representation
            InitializeComponent();

            // create an instance of an object <= OOP



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ckick Me!");
        }
    }
}