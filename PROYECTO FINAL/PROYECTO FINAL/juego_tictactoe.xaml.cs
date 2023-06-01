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
    /// Lógica de interacción para juego_tictactoe.xaml
    /// </summary>
    public partial class juego_tictactoe : Window
    {
        int turno;
        int puntoX, puntoO;

        public juego_tictactoe()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }

        private void Window_Loader(object sender, RoutedEventArgs e)
        {
            turno = 1;
        }

        private void ganar(String botonContenido)
        {
            if ((Boton01.Content == botonContenido && Boton02.Content == botonContenido && Boton03.Content == botonContenido)

                | (Boton01.Content == botonContenido & Boton04.Content == botonContenido & Boton07.Content == botonContenido)

                | (Boton01.Content == botonContenido & Boton05.Content == botonContenido & Boton09.Content == botonContenido)

                | (Boton02.Content == botonContenido & Boton05.Content == botonContenido & Boton08.Content == botonContenido)

                | (Boton03.Content == botonContenido & Boton06.Content == botonContenido & Boton09.Content == botonContenido)

                | (Boton04.Content == botonContenido & Boton05.Content == botonContenido & Boton06.Content == botonContenido)

                | (Boton07.Content == botonContenido & Boton08.Content == botonContenido & Boton09.Content == botonContenido)

                | (Boton03.Content == botonContenido & Boton05.Content == botonContenido & Boton07.Content == botonContenido))
            {
                if (botonContenido == "O")
                {
                    MessageBox.Show("¡Ha ganado el jugador O!");
                    PuntoO.Content = ++puntoO;
                }
                else if (botonContenido == "X")
                {
                    MessageBox.Show("¡Ha ganado el jugador X!");
                    PuntoX.Content = ++puntoX;
                }

                resetearBotones();

            }
            else
            {
                foreach (Button btn in Panel.Children)
                {
                    if (btn.IsEnabled == true)
                        return;
                }
                MessageBox.Show("¡Empate! Nadie gana hoy.");
                resetearBotones();
            }
        }
        private void resetearBotones()
        {
            foreach (Button btn in Panel.Children)
            {
                btn.IsEnabled = true;
                btn.Content = "";
            }
        }

        private void boton_jugar(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (turno == 1)
            {
                btn.Content = "O";
                Turno.Content = "Turno del jugador X";
            }
            else
            {
                btn.Content = "X";
                Turno.Content = "Turno del jugador O";
            }
            btn.IsEnabled = false;
            ganar(btn.Content.ToString());
            turno += 1;
            if (turno > 2)
                turno = 1;
        }

        private void boton_resetear(object sender, RoutedEventArgs e)
        {
            foreach (Button btn in Panel.Children)
            {
                btn.Content = "";
                btn.IsEnabled = true;
            }

            turno = 2;
        }

        private void Volver_a_menu(object sender, RoutedEventArgs e)
        {
            preview_tictactoe preview = new preview_tictactoe();
            preview.Show();
            this.Close();
        }
    }
}