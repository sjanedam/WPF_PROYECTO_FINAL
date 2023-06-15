using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;

namespace PROYECTO_FINAL
{
    /// <summary>
    /// Lógica de interacción para juego_wordle.xaml
    /// </summary>
    public partial class juego_wordle : Window
    {
        static String[] palabras = {"Bash", "HTML", "Chat", "Ruby", "Perl",
                                    "Rust", "From", "Void", "XAML", "JSON",
                                    "True", "Back", "ASIR", "Code", "Disk",
                                    "File", "Page", "Icon", "Item", "Link",
                                    "Menu", "Save", "Spam", "User", "Byte",
                                    "Mail", "Main", "Args", "Atom", "Bits",
                                    "Read", "DHCP", "FAQS", "HDMI", "Head",
                                    "JPEG", "Unix", "ODBC", "VLAN", "SOAP"};

        int turno;
        int puntuacion;

        static String palabra;

        public juego_wordle()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;

            palabra = MixWords();
           // MessageBox.Show(palabra);
            turno = 0;
            int puntuacion = 0;
            Puntos.Content = puntuacion;
        }

        private void Volver_a_menu(object sender, RoutedEventArgs e)
        {
            preview_wordle preview = new preview_wordle();
            preview.Show();
            this.Close();
        }
        private void boton_jugar(object sender, RoutedEventArgs e)
        {
            turno++;
            String input = guess.Text.ToString();

            // caracteres de la palabra que se intenta averiguar
            char letra1 = input[0];
            char letra2 = input[1];
            char letra3 = input[2];
            char letra4 = input[input.Length - 1];

            // caracteres de la palabra que hay que adivinar
            char let1 = palabra[0];
            char let2 = palabra[1];
            char let3 = palabra[2];
            char let4 = palabra[palabra.Length - 1];

            // Checar que la palabra sean solo letras
            bool resultado = Regex.IsMatch(input, @"^[a-zA-Z]+$");

            // Mensaje de error por si tiene menos o más de 4 letras la palabra
            // O si el no forma parte del patrón
            if (input.Length > 4 || input.Length <4 || resultado == false)
            {
                MessageBox.Show("No se puede jugar, la palabra que tienes que introducir tiene que tener 4 letras y que no tenga número ni caracteres especiales");
                guess.Clear();
            }
            else
            {
                switch (turno)
                {
                    case 1:
                        fila1(input);
                        break;
                    case 2:
                        fila2(input);
                        break;
                    case 3:
                        fila3(input);
                        break;
                    case 4:
                        fila4(input);
                        MessageBox.Show("Ya no tienes mas oportunidades para adivinar esta palabra. Se reseteará y se generará una nueva palabra automáticamente");
                        turno = 0;
                        Resetear();
                        palabra = MixWords();
                        break;
                }
            }
        }

        public void fila1(String input)
        {
            // caracteres de la palabra que se intenta averiguar
            char letra1 = input[0];
            char letra2 = input[1];
            char letra3 = input[2];
            char letra4 = input[input.Length - 1];

            // caracteres de la palabra que hay que adivinar
            char let1 = palabra[0];
            char let2 = palabra[1];
            char let3 = palabra[2];
            char let4 = palabra[palabra.Length - 1];


            if (input.Equals(palabra, StringComparison.OrdinalIgnoreCase))
            {
                Boton01.Content = letra1.ToString();
                Boton01.Background = Brushes.Green;

                Boton02.Content = letra2.ToString();
                Boton02.Background = Brushes.Green;

                Boton03.Content = letra3.ToString();
                Boton03.Background = Brushes.Green;

                Boton04.Content = letra4.ToString();
                Boton04.Background = Brushes.Green;

                MessageBox.Show("Has ganado!");
                Resetear();
                turno = 0;
                puntuacion += 5;
                Puntos.Content = puntuacion;
                palabra = MixWords();
            }
            else
            {
                String comp1 = palabra[0].ToString();
                String comp2 = palabra[1].ToString();
                String comp3 = palabra[2].ToString();
                String comp4 = palabra[3].ToString();

                // BOTON 1
                if (let1.Equals(letra1))
                {
                    Boton01.Content = letra1.ToString();
                    Boton01.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra1))
                {
                    Boton01.Content = letra1.ToString();
                    Boton01.Background = Brushes.Yellow;
                }
                else
                {
                    Boton01.Content = letra1.ToString();
                    Boton01.Background = Brushes.Gray;
                }

                // BOTON 2
                if (let2.Equals(letra2))
                {
                    Boton02.Content = letra2.ToString();
                    Boton02.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra2))
                {
                    Boton02.Content = letra2.ToString();
                    Boton02.Background = Brushes.Yellow;
                }
                else
                {
                    Boton02.Content = letra2.ToString();
                    Boton02.Background = Brushes.Gray;
                }

                // BOTON 3
                if (let3.Equals(letra3))
                {
                    Boton03.Content = letra3.ToString();
                    Boton03.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra3))
                {
                    Boton03.Content = letra3.ToString();
                    Boton03.Background = Brushes.Yellow;
                }
                else
                {
                    Boton03.Content = letra3.ToString();
                    Boton03.Background = Brushes.Gray;
                }

                // BOTON 4
                if (let4.Equals(letra4))
                {
                    Boton04.Content = letra4.ToString();
                    Boton04.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra4))
                {
                    Boton04.Content = letra4.ToString();
                    Boton04.Background = Brushes.Yellow;
                }
                else
                {
                    Boton04.Content = letra4.ToString();
                    Boton04.Background = Brushes.Gray;
                }
            }
        }

        public void fila2(String input)
        {
            String comp1 = palabra[0].ToString();
            String comp2 = palabra[1].ToString();
            String comp3 = palabra[2].ToString();
            String comp4 = palabra[3].ToString();

            // caracteres de la palabra que se intenta averiguar
            char letra1 = input[0];
            char letra2 = input[1];
            char letra3 = input[2];
            char letra4 = input[input.Length - 1];

            // caracteres de la palabra que hay que adivinar
            char let1 = palabra[0];
            char let2 = palabra[1];
            char let3 = palabra[2];
            char let4 = palabra[palabra.Length - 1];


            if (input.Equals(palabra, StringComparison.OrdinalIgnoreCase))
            {
                Boton05.Content = letra1.ToString();
                Boton05.Background = Brushes.Green;

                Boton06.Content = letra2.ToString();
                Boton06.Background = Brushes.Green;

                Boton07.Content = letra3.ToString();
                Boton07.Background = Brushes.Green;

                Boton08.Content = letra4.ToString();
                Boton08.Background = Brushes.Green;

                MessageBox.Show("Has ganado!");
                Resetear();
                turno = 0;
                puntuacion += 5;
                Puntos.Content = puntuacion;
                palabra = MixWords();
            }
            else
            {
                // BOTON 1
                if (let1.Equals(letra1))
                {
                    Boton05.Content = letra1.ToString();
                    Boton05.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra1))
                {
                    Boton05.Content = letra1.ToString();
                    Boton05.Background = Brushes.Yellow;
                }
                else
                {
                    Boton05.Content = letra1.ToString();
                    Boton05.Background = Brushes.Gray;
                }


                // BOTON 2
                if (let2.Equals(letra2))
                {
                    Boton06.Content = letra2.ToString();
                    Boton06.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra2))
                {
                    Boton06.Content = letra2.ToString();
                    Boton06.Background = Brushes.Yellow;
                }
                else
                {
                    Boton06.Content = letra2.ToString();
                    Boton06.Background = Brushes.Gray;
                }

                // BOTON 3
                if (let3.Equals(letra3))
                {
                    Boton07.Content = letra3.ToString();
                    Boton07.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra3))
                {
                    Boton07.Content = letra3.ToString();
                    Boton07.Background = Brushes.Yellow;
                }
                else
                {
                    Boton07.Content = letra3.ToString();
                    Boton07.Background = Brushes.Gray;
                }

                // BOTON 4
                if (let4.Equals(letra4))
                {
                    Boton08.Content = letra4.ToString();
                    Boton08.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra4))
                {
                    Boton08.Content = letra4.ToString();
                    Boton08.Background = Brushes.Yellow;
                }
                else
                {
                    Boton08.Content = letra4.ToString();
                    Boton08.Background = Brushes.Gray;
                }
            }
        }
        public void fila3(String input)
        {
            String comp1 = palabra[0].ToString();
            String comp2 = palabra[1].ToString();
            String comp3 = palabra[2].ToString();
            String comp4 = palabra[3].ToString();

            // caracteres de la palabra que se intenta averiguar
            char letra1 = input[0];
            char letra2 = input[1];
            char letra3 = input[2];
            char letra4 = input[input.Length - 1];

            // caracteres de la palabra que hay que adivinar
            char let1 = palabra[0];
            char let2 = palabra[1];
            char let3 = palabra[2];
            char let4 = palabra[palabra.Length - 1];


            if (input.Equals(palabra, StringComparison.OrdinalIgnoreCase))
            {
                Boton09.Content = letra1.ToString();
                Boton09.Background = Brushes.Green;

                Boton10.Content = letra2.ToString();
                Boton10.Background = Brushes.Green;

                Boton11.Content = letra3.ToString();
                Boton11.Background = Brushes.Green;

                Boton12.Content = letra4.ToString();
                Boton12.Background = Brushes.Green;

                MessageBox.Show("Has ganado!");
                Resetear();
                turno = 0;
                puntuacion += 5;
                Puntos.Content = puntuacion;
                palabra = MixWords();
            }
            else
            {
                // BOTON 1
                if (let1.Equals(letra1))
                {
                    Boton09.Content = letra1.ToString();
                    Boton09.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra1))
                {
                    Boton09.Content = letra1.ToString();
                    Boton09.Background = Brushes.Yellow;
                }
                else
                {
                    Boton09.Content = letra1.ToString();
                    Boton09.Background = Brushes.Gray;
                }


                // BOTON 2
                if (let2.Equals(letra2))
                {
                    Boton10.Content = letra2.ToString();
                    Boton10.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra2))
                {
                    Boton10.Content = letra2.ToString();
                    Boton10.Background = Brushes.Yellow;
                }
                else
                {
                    Boton10.Content = letra2.ToString();
                    Boton10.Background = Brushes.Gray;
                }

                // BOTON 3
                if (let3.Equals(letra3))
                {
                    Boton11.Content = letra3.ToString();
                    Boton11.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra3))
                {
                    Boton11.Content = letra3.ToString();
                    Boton11.Background = Brushes.Yellow;
                }
                else
                {
                    Boton11.Content = letra3.ToString();
                    Boton11.Background = Brushes.Gray;
                }

                // BOTON 4
                if (let4.Equals(letra4))
                {
                    Boton12.Content = letra4.ToString();
                    Boton12.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra4))
                {
                    Boton12.Content = letra4.ToString();
                    Boton12.Background = Brushes.Yellow;
                }
                else
                {
                    Boton12.Content = letra4.ToString();
                    Boton12.Background = Brushes.Gray;
                }
            }
        }

        public void fila4(String input)
        {
            String comp1 = palabra[0].ToString();
            String comp2 = palabra[1].ToString();
            String comp3 = palabra[2].ToString();
            String comp4 = palabra[3].ToString();

            // caracteres de la palabra que se intenta averiguar
            char letra1 = input[0];
            char letra2 = input[1];
            char letra3 = input[2];
            char letra4 = input[input.Length - 1];

            // caracteres de la palabra que hay que adivinar
            char let1 = palabra[0];
            char let2 = palabra[1];
            char let3 = palabra[2];
            char let4 = palabra[palabra.Length - 1];


            if (input.Equals(palabra, StringComparison.OrdinalIgnoreCase))
            {
                Boton13.Content = letra1.ToString();
                Boton13.Background = Brushes.Green;

                Boton14.Content = letra2.ToString();
                Boton14.Background = Brushes.Green;

                Boton15.Content = letra3.ToString();
                Boton15.Background = Brushes.Green;

                Boton16.Content = letra4.ToString();
                Boton16.Background = Brushes.Green;

                MessageBox.Show("Has ganado!");
                Resetear();
                turno = 0;
                puntuacion += 5;
                Puntos.Content = puntuacion;
                palabra = MixWords();

            }
            else
            {
                // BOTON 1
                if (let1.Equals(letra1))
                {
                    Boton13.Content = letra1.ToString();
                    Boton13.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra1))
                {
                    Boton13.Content = letra1.ToString();
                    Boton13.Background = Brushes.Yellow;
                }
                else
                {
                    Boton13.Content = letra1.ToString();
                    Boton13.Background = Brushes.Gray;
                }


                // BOTON 2
                if (let2.Equals(letra2))
                {
                    Boton14.Content = letra2.ToString();
                    Boton14.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra2))
                {
                    Boton14.Content = letra2.ToString();
                    Boton14.Background = Brushes.Yellow;
                }
                else
                {
                    Boton14.Content = letra2.ToString();
                    Boton14.Background = Brushes.Gray;
                }

                // BOTON 3
                if (let3.Equals(letra3))
                {
                    Boton15.Content = letra3.ToString();
                    Boton15.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra3))
                {
                    Boton15.Content = letra3.ToString();
                    Boton15.Background = Brushes.Yellow;
                }
                else
                {
                    Boton15.Content = letra3.ToString();
                    Boton15.Background = Brushes.Gray;
                }

                // BOTON 4
                if (let4.Equals(letra4))
                {
                    Boton16.Content = letra4.ToString();
                    Boton16.Background = Brushes.Green;
                }
                else if (palabra.Contains(letra4))
                {
                    Boton16.Content = letra4.ToString();
                    Boton16.Background = Brushes.Yellow;
                }
                else
                {
                    Boton16.Content = letra4.ToString();
                    Boton16.Background = Brushes.Gray;
                }
            }
        }
        private String MixWords ()
        {
            var random = new Random();
            int posicion = random.Next(0, palabras.Length-1);
            String palabra_del_dia = palabras[posicion];

            return palabra_del_dia;
        }

        // Cuando ganes o pierdas, bloquear
        private void Resetear()
        {
            foreach (Button btn in Panel.Children)
            {
                btn.Content = "";
                btn.Background = Brushes.Orange;
                btn.IsEnabled = true;
            }

            AdminDB admin = new AdminDB();
            int id = admin.id("Wordle");
            admin.Insertar_puntos(puntuacion, id, 8);

        }
    }
}
