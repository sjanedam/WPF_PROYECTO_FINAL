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

using System.Windows.Threading;

namespace PROYECTO_FINAL
{
    /// <summary>
    /// Lógica de interacción para juego_flappy.xaml
    /// </summary>
    public partial class juego_flappy : Window
    {
        DispatcherTimer timerJuego = new DispatcherTimer();

        double score;
        int gravedad = 8;
        bool gameOver;
        Rect MewHitBox;
        Rect SueloHitBox;

        public juego_flappy()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;

            timerJuego.Tick += MainEventTimer;
            timerJuego.Interval = TimeSpan.FromMilliseconds(20);
            EmpezarJuego();
        }

        private void MainEventTimer(object sender, EventArgs e)
        {
            Puntuacion.Content = score;
            MewHitBox = new Rect(Canvas.GetLeft(Mew), Canvas.GetTop(Mew), Mew.Width, Mew.Height);
            SueloHitBox = new Rect(Canvas.GetLeft(Suelo), Canvas.GetTop(Suelo), Suelo.Width, Suelo.Height);

            Canvas.SetTop(Mew, Canvas.GetTop(Mew) + gravedad);

            if (Canvas.GetTop(Mew) < -10 || MewHitBox.IntersectsWith(SueloHitBox))
            {
                TerminarJuego();
            }

            foreach (var x in Pantalla.Children.OfType<Image>())
            {
                if ((string)x.Tag == "Obs1" ||
                    (string)x.Tag == "Obs2" ||
                    (string)x.Tag == "Obs3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < -100)
                    {
                        Canvas.SetLeft(x, 850);
                        score += .5;
                    }

                    Rect obsHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (MewHitBox.IntersectsWith(obsHitBox))
                    {
                        TerminarJuego();
                    }
                }

                if ((string)x.Tag == "Nube")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);
                    if (Canvas.GetLeft(x) < -1500)
                    {
                        Canvas.SetLeft(x, 920);
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                Mew.RenderTransform = new RotateTransform(20, Mew.Width / 2, Mew.Height / 2);
                gravedad = -8;
            }

            if (e.Key == Key.R && gameOver == true)
            {
                EmpezarJuego();
            }

            if (e.Key == Key.R)
            {
                EmpezarJuego();
            }

        }

        private void KeyIsuP(object sender, KeyEventArgs e)
        {
            Mew.RenderTransform = new RotateTransform(-5, Mew.Width / 2, Mew.Height / 2);
            gravedad = 8;
        }

        private void EmpezarJuego()
        {
            Pantalla.Focus();

            int temporizador = 300;
            score = 0;
            gameOver = false;
            Canvas.SetTop(Mew, 275);

            foreach (var x in Pantalla.Children.OfType<Image>())
            {
                if ((string)x.Tag == "Obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                if ((string)x.Tag == "Obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                if ((string)x.Tag == "Obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }
                if ((string)x.Tag == "Nube")
                {
                    Canvas.SetLeft(x, 300 + temporizador);
                }

                timerJuego.Start();
            }
        }

        private void TerminarJuego()
        {
            timerJuego.Stop();
            gameOver = true;
            MessageBox.Show("Pulsa R para empezar de nuevo", "Game Over");
        }

        private void Volver_a_menu(object sender, RoutedEventArgs e)
        {
            preview_flappymew preview = new preview_flappymew();
            preview.Show();
            this.Close();
        }
    }
}
