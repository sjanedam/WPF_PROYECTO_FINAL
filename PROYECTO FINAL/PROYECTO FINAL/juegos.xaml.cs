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
using System.Windows.Shapes;

namespace PROYECTO_FINAL
{
    /// <summary>
    /// Lógica de interacción para juegos.xaml
    /// </summary>
    public partial class juegos : Window
    {
        AdminDB admin = new AdminDB();
        List<String> juegosList = new List<String>();


        public juegos()
        {
            for (int i = 0 + 4; i < 8 + 4; i++)
            {
                juegosList.Add(admin.Nombres(i));
            }

            if (juegosList.Any())
            {
                InitializeComponent();
                MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
                MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;

                J1.Content = juegosList.ElementAt(0).ToString();
                J2.Content = juegosList.ElementAt(1).ToString();
                J3.Content = juegosList.ElementAt(2).ToString();
                J4.Content = juegosList.ElementAt(3).ToString();
                J5.Content = juegosList.ElementAt(4).ToString();
                J6.Content = juegosList.ElementAt(5).ToString();
                J7.Content = juegosList.ElementAt(6).ToString();
                J8.Content = juegosList.ElementAt(7).ToString();
            }
            else
            {
                InitializeComponent();
                MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
                MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            }
        }
        private void Preview_tictactoe(object sender, RoutedEventArgs e)
        {
            preview_tictactoe tictactoe = new preview_tictactoe();
            tictactoe.Show();
            this.Close();
        }

        private void Preview_wordle(object sender, RoutedEventArgs e)
        {
            preview_wordle wordle = new preview_wordle();
            wordle.Show();
            this.Close();
        }

        private void Preview_flappymew(object sender, RoutedEventArgs e)
        {
            preview_flappymew flappymew = new preview_flappymew();
            flappymew.Show();
            this.Close();
        }

        private void Volver_a_menu(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
