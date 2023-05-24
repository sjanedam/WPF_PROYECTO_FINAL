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
    /// Lógica de interacción para preview_tictactoe.xaml
    /// </summary>
    public partial class preview_tictactoe : Window
    {
        List<String> datos = new List<string>();
        AdminDB admin = new AdminDB();

        public preview_tictactoe()
        {
            datos = admin.Comprobar_juego("Tic Tac Toe", datos);

            if (datos.Any())
            {
                String nom = datos.ElementAt(0).ToString();
                String desc = datos.ElementAt(1).ToString();
                String dif = datos.ElementAt(2).ToString();
                String tipo = datos.ElementAt(3).ToString();

                InitializeComponent();

                Nombre.Content = nom.ToString();
                Descripcion.Text = desc.ToString();
                Dificultad.Content = dif.ToString();
                Tipo.Content = tipo.ToString();
            }
            else
            {
                InitializeComponent();
            }
        }
        public void Jugar_tictactoe(object sender, RoutedEventArgs e)
        {
            juego_flappy flappy = new juego_flappy();
            flappy.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
