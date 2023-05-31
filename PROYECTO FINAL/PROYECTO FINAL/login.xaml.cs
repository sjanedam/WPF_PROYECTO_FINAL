using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            AdminDB gestion = new AdminDB();

            String user = usuario.Text;
            String password = contra.Password.ToString();

            if (gestion.Comprobar_usuario(user, password))
            {
                MessageBox.Show("¡Usuario loggeado correctamente!", "Inicio de sesión", MessageBoxButton.OK);

                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void Registro(object sender, RoutedEventArgs e)
        {
            registro registro = new registro();
            registro.Show();
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
