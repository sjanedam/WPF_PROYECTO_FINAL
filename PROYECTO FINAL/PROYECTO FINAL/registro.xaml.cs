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
    /// Lógica de interacción para registro.xaml
    /// </summary>
    public partial class registro : Window
    {
        public registro()
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

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void Registrarse(object sender, RoutedEventArgs e)
        {
            string user = usuario.Text.ToString();
            string contra = pass.Password.ToString();
            string conficontra = password.Password.ToString();

            if (contra.Equals(conficontra))
            {
                AdminDB admin = new AdminDB();

                if (admin.Insertar_usuario(user, contra))
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Las contraseñas deben de ser iguales", "Error al registrarse", MessageBoxButton.OK);
            }
        }
    }
}