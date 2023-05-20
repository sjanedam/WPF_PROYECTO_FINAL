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
        }

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            AdminDB gestion = new AdminDB();

            String user = usuario.Text;
            String password = contra.Password.ToString();

            List<User> listaUsuarios = gestion.Generar_usuarios();

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (user.Equals(listaUsuarios.ElementAt(i).nombre_usuario)
                    && password.Equals(listaUsuarios.ElementAt(i).contra)) {

                    MessageBox.Show("Usuario y contraseña correctas.", "Inicio de sesión correcto.", MessageBoxButton.OK);
                    
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectas, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                    usuario.Clear();
                    contra.Clear();
                }
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
