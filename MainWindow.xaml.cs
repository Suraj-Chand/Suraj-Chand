﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BTMS1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Image_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main ss = new main();
            ss.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();

            main ss = new main();

            ss.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            usernametxtbox.Clear();
            passwordtxtbox.Clear(); 
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            sendCode ss = new sendCode();
            ss.Show();
        }
    }
}
