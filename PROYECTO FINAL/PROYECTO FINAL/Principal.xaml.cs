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
using System.Windows.Shapes;

namespace PROYECTO_FINAL
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void inicio(object sender, RoutedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }
        private void registro(object sender, RoutedEventArgs e)
        {
            registro registro = new registro();
            registro.Show();
            this.Close();
        }
    }
}