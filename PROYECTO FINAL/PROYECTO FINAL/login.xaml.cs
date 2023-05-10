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

using Console = System.Console;
using Microsoft.Data.Odbc;

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

        private void iniciar(object sender, EventArgs e)
        {

        }

        static void Main(string[] args)
        {
            try
            {
                //Connection string for Connector/ODBC 3.51
                string MyConString = "DRIVER={MySQL ODBC 3.51 Driver};" +
                  "SERVER=localhost;" +
                  "DATABASE=profi_bbdd;" +
                  "UID=wpf_sjod;" +
                  "PASSWORD=123456789;" +
                  "OPTION=3";

                //Connect to MySQL using Connector/ODBC
                OdbcConnection MyConnection = new OdbcConnection(MyConString);
                MyConnection.Open();

                Console.WriteLine("\n !!! success, connected successfully !!!\n");

                //Display connection information
                Console.WriteLine("Connection Information:");
                Console.WriteLine("\tConnection String:" +
                                  MyConnection.ConnectionString);
                Console.WriteLine("\tConnection Timeout:" +
                                  MyConnection.ConnectionTimeout);
                Console.WriteLine("\tDatabase:" +
                                  MyConnection.Database);
                Console.WriteLine("\tDataSource:" +
                                  MyConnection.DataSource);
                Console.WriteLine("\tDriver:" +
                                  MyConnection.Driver);
                Console.WriteLine("\tServerVersion:" +
                                  MyConnection.ServerVersion);

                //Create a sample table
                OdbcCommand MyCommand =
                  new OdbcCommand("DROP TABLE IF EXISTS my_odbc_net",
                                  MyConnection);
                MyCommand.ExecuteNonQuery();
                MyCommand.CommandText =
                  "CREATE TABLE my_odbc_net(id int, name varchar(20), idb bigint)";
                MyCommand.ExecuteNonQuery();

                //Insert
                MyCommand.CommandText =
                  "INSERT INTO my_odbc_net VALUES(10,'venu', 300)";
                Console.WriteLine("INSERT, Total rows affected:" +
                                  MyCommand.ExecuteNonQuery()); ;

                //Insert
                MyCommand.CommandText =
                  "INSERT INTO my_odbc_net VALUES(20,'mysql',400)";
                Console.WriteLine("INSERT, Total rows affected:" +
                                  MyCommand.ExecuteNonQuery());

                //Insert
                MyCommand.CommandText =
                  "INSERT INTO my_odbc_net VALUES(20,'mysql',500)";
                Console.WriteLine("INSERT, Total rows affected:" +
                                  MyCommand.ExecuteNonQuery());

                //Update
                MyCommand.CommandText =
                  "UPDATE my_odbc_net SET id=999 WHERE id=20";
                Console.WriteLine("Update, Total rows affected:" +
                                  MyCommand.ExecuteNonQuery());

                //COUNT(*)
                MyCommand.CommandText =
                  "SELECT COUNT(*) as TRows FROM my_odbc_net";
                Console.WriteLine("Total Rows:" +
                                  MyCommand.ExecuteScalar());

                //Fetch
                MyCommand.CommandText = "SELECT * FROM my_odbc_net";
                OdbcDataReader MyDataReader;
                MyDataReader = MyCommand.ExecuteReader();
                while (MyDataReader.Read())
                {
                    if (string.Compare(MyConnection.Driver, "myodbc3.dll") == 0)
                    {
                        //Supported only by Connector/ODBC 3.51
                        Console.WriteLine("Data:" + MyDataReader.GetInt32(0) + " " +
                                          MyDataReader.GetString(1) + " " +
                                          MyDataReader.GetInt64(2));
                    }
                    else
                    {
                        //BIGINTs not supported by Connector/ODBC
                        Console.WriteLine("Data:" + MyDataReader.GetInt32(0) + " " +
                                          MyDataReader.GetString(1) + " " +
                                          MyDataReader.GetInt32(2));
                    }
                }

                //Close all resources
                MyDataReader.Close();
                MyConnection.Close();
            }
            catch (OdbcException MyOdbcException) //Catch any ODBC exception ..
            {
                for (int i = 0; i < MyOdbcException.Errors.Count; i++)
                {
                    Console.Write("ERROR #" + i + "\n" +
                                  "Message: " +
                                  MyOdbcException.Errors[i].Message + "\n" +
                                  "Native: " +
                                  MyOdbcException.Errors[i].NativeError.ToString() + "\n" +
                                  "Source: " +
                                  MyOdbcException.Errors[i].Source + "\n" +
                                  "SQL: " +
                                  MyOdbcException.Errors[i].SQLState + "\n");
                }
            }
        }
    }
}
