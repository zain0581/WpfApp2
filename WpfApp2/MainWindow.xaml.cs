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
using WpfApp2.ViewModels;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            EmployeeViewModel VM = new EmployeeViewModel();
            this.DataContext = VM;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            double my = 12.33;
            int myint;
            myint = (int)my;
            Console.WriteLine(myint);  
            string name = myint .ToString();
        }
    }
}
