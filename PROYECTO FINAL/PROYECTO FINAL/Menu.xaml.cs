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
        List<String> datosMew = new List<string>();
        List<String> datosWord = new List<string>();
        List<String> datos3en = new List<string>();
        AdminDB admin = new AdminDB();

        public Menu()
        {
            datosMew = admin.Comprobar_juego("Tic Tac Toe", datos3en);
            datosMew = admin.Comprobar_juego("Wordle", datosWord);
            datosMew = admin.Comprobar_juego("Flappy Mew", datosMew);

            if (datos3en.Any() && datosWord.Any() && datosMew.Any())
            {
                InitializeComponent();

                tipo3en.Content = datos3en.ElementAt(3).ToString();
                tipoWord.Content = datosWord.ElementAt(3).ToString();
                tipoMew.Content = datosMew.ElementAt(3).ToString();

                nombre3en.Content = datos3en.ElementAt(0).ToString();
                nombreWord.Content = datosWord.ElementAt(0).ToString();
                nombreMew.Content = datosMew.ElementAt(0).ToString();
            }
            else
            {
                InitializeComponent();
            }
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

        private void Abrir_perfil(object sender, MouseButtonEventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();
            this.Close();
        }

        private void Abrir_juegos(object sender, MouseButtonEventArgs e)
        {
            juegos juegos = new juegos();
            juegos.Show();
            this.Close();
        }

        private void Abrir_favoritos(object sender, MouseButtonEventArgs e)
        {
            favoritos favoritos = new favoritos();
            favoritos.Show();
            this.Close();
        }

        private void Abrir_ajustes(object sender, MouseButtonEventArgs e)
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
