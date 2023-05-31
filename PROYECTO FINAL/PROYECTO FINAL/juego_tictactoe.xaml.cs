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

        /*
        private void show_mensaje(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Cóooomo? ¿Que no sabes jugar al Tres en raya? ¿Quieres que te enseñe?", "Instrucciones del tres en raya", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Estas son las instrucciones tú: \n" +
                        "Es un juego de dos personas, el jugador X y el jugador O. \n" +
                        "Para ganar tienes que tener tres X o tres O en línea (horizontal, vertical o diagonal).\n" +
                        "Y ya, no hay más misterio, no te rayes y empieza a jugar, al final del día vas a entenderlo.", "Instrucciones del tres en raya");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Vale, vale, no hacía falta ser tan borde.", "Instrucciones del tres en raya");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("¿Okaaay? Tampoco quería enseñarte.", "Instrucciones del tres en raya");
                    break;
            }
        }
        */

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
                    //JugadorO.Content = ++puntoO;
                }
                else if (botonContenido == "X")
                {
                    MessageBox.Show("¡Ha ganado el jugador X!");
                    //JugadorX.Content = ++puntoX;
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
                //turnoJugador.Content = "X";
            }
            else
            {
                btn.Content = "X";
                //turnoJugador.Content = "O";
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

            //JugadorO.Content = 0;
            puntoO = 0;
            //JugadorX.Content = 0;
            puntoX = 0;
            turno = 2;
            //turnoJugador.Content = "X";
        }

        /* BOTONES PARA SALIR Y MINIMIZAR */
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