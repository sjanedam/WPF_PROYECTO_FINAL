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
        static MySqlConnection conn = new MySqlConnection();
        static String servidor = "Server = localhost;";
        static String bbdd = "Database = profi_bbdd;";
        static String usuario = "UID = wpf_sjod;";
        static String password = "Password = 123456789;";
        String conexion = servidor + bbdd + usuario + password;
        static MySqlCommand comando = new MySqlCommand();
        static MySqlDataAdapter adaptador = new MySqlDataAdapter();
        MySqlDataReader reader;

        // Conectamos con la bbdd
        public MySqlConnection Conectar()
        {
            try
            {
                conn.ConnectionString = conexion;
                conn.Open();      
                return conn;
            }
            catch (Exception)
            {
                return conn;
                throw;
            }
        }
        // Desconectamos de la bbdd
        public void Desconectar()
        {
            conn.Close();
        }

        // Comprobar en la bbdd
        public Boolean Comprobar_usuario(String user, String password)
        {
            conn = null;
            comando = null;
            reader = null;

            try
            {
                string sql = "SELECT * FROM usuario where usuario = '" + user + "' AND contra = '" + password + "';";

                conn = new MySqlConnection(conexion);
                comando = new MySqlCommand(sql, conn);

                conn.Open();

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    String a = reader.HasRows.ToString();
                    MessageBox.Show(a);

                    reader.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña no existen.");

                    reader.Close();
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Insertamos en la bbdd
        public Boolean Insertar_usuario(String user, String password)
        {
            conn = null;
            comando = null;
            reader = null;

            try
            {
                string sql = "INSERT INTO usuario(usuario, contra) VALUES ('" + user + "', '" + password + "');";

                conn = new MySqlConnection(conexion);
                comando = new MySqlCommand(sql, conn);

                conn.Open();

                reader = comando.ExecuteReader();
                MessageBox.Show("¡Se ha registrado correctamente!", "Registro de usuario");

                reader.Close();
                conn.Close();
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Comprobar juego
        public List<String> Comprobar_juego(String nombre, List<string> datos)
        {
            conn = null;
            comando = null;
            reader = null;

            try
            {
                string sql = "SELECT * FROM juego where nombre = '" + nombre + "';";

                conn = new MySqlConnection(conexion);
                comando = new MySqlCommand(sql, conn);

                conn.Open();

                reader = comando.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    datos.Add(reader.GetString("nombre"));
                    datos.Add(reader.GetString("descripcion"));
                    datos.Add(reader.GetString("dificultad"));
                    datos.Add(reader.GetString("tipo"));

                    reader.Close();
                    conn.Close();
                    return datos;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    return datos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return datos;
            }
        }

        // Comprobar juego
        public String Nombres(int id)
        {
            conn = null;
            comando = null;
            reader = null;
            String nombre = "";

            try
            {
                string sql = "SELECT nombre FROM juego WHERE id = " + id + ";";

                conn = new MySqlConnection(conexion);
                comando = new MySqlCommand(sql, conn);

                conn.Open();

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nombre = reader.GetString("nombre");
                        return nombre;
                    }

                    reader.Close();
                    conn.Close();
                    return nombre;
                }
                else {
                    return nombre;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return nombre;
            }
        }

    }
}
