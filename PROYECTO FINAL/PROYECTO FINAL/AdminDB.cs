using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PROYECTO_FINAL
{
    class AdminDB
    {
        public List<User> Generar_usuarios()
        {
            /* Conexión con la BBDD */
            MySqlConnection conn = null;
            MySqlCommand comando = null;
            MySqlDataReader reader = null;

            List<User> listaUsuarios = new List<User>();

            try
            {
                String consulta = "Select * FROM usuario;";

                conn = new MySqlConnection("Server=localhost; Database=profi_bbdd; UID=wpf_sjod; Password = 123456789;");
                comando = new MySqlCommand(consulta, conn);

                conn.Open();
                reader = comando.ExecuteReader();

                int id_contador = 1;

                while (reader.Read())
                {
                    listaUsuarios.Add(new User(id_contador, reader.GetString("usuario"), reader.GetString("contra")));
                    id_contador++;
                }
                reader.Close();
                conn.Close();

                return listaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listaUsuarios;
            }
        }
    }
}
