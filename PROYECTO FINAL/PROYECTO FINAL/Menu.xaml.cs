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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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

        private void Abrir_perfil(object sender, RoutedEventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Close();
        }

        private void Abrir_juegos(object sender, RoutedEventArgs e)
        {
            juegos juegos = new juegos();
            juegos.Show();
            this.Close();
        }

        private void Abrir_favoritos(object sender, RoutedEventArgs e)
        {
            favoritos favoritos = new favoritos();
            favoritos.Show();
            this.Close();
        }

        private void Abrir_ajustes(object sender, RoutedEventArgs e)
        {
            ajustes ajustes = new ajustes();
            ajustes.Show();
            this.Close();
        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (menu_boton.IsChecked == true)
            {
                perfil_tooltip.Visibility = Visibility.Collapsed;
                juegos_tooltip.Visibility = Visibility.Collapsed;
                favoritos_tooltip.Visibility = Visibility.Collapsed;
                ajustes_tooltip.Visibility = Visibility.Collapsed;
            }
            else
            {
                perfil_tooltip.Visibility = Visibility.Visible;
                juegos_tooltip.Visibility = Visibility.Visible;
                favoritos_tooltip.Visibility = Visibility.Visible;
                ajustes_tooltip.Visibility = Visibility.Visible;
            }
        }

        private void Menu_boton_no_clickado(object sender, RoutedEventArgs e)
        {
            //.Opacity = 1;
        }

        private void Menu_boton_clickado(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 0.3;
        }
    }
}
