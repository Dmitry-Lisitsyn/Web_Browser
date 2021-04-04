using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void but_reg_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "menelai.ddns.net";

            mysqlCSB.UserID = "menelai";
            mysqlCSB.Password = "123";
            mysqlCSB.CharacterSet = "utf8";
            mysqlCSB.Port = 3333;
            mysqlCSB.Database = "Browser";
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);





            try
            {
                myConnection.Open();

                
                MySqlCommand myCommand = new MySqlCommand("INSERT INTO Users(login,pass) VALUES ('"+ box_log.Text +"','"+ box_pass.Text +"');", myConnection);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь зарегестрирован!");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                //
            }
        }

        private void but_vhod_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "menelai.ddns.net";

            mysqlCSB.UserID = "menelai";
            mysqlCSB.Password = "123";
            mysqlCSB.CharacterSet = "utf8";
            mysqlCSB.Port = 3333;
            mysqlCSB.Database = "Browser";
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);





            try
            {
                myConnection.Open();


                MySqlCommand myCommand = new MySqlCommand("SELECT COUNT(*)  FROM Users WHERE login='" + log_vhod.Text+"' AND pass='"+pass_vhod.Text+"'", myConnection);
                myCommand.ExecuteNonQuery();
                //MessageBox.Show(myCommand.ExecuteScalar().ToString());
                var result = Int32.Parse(myCommand.ExecuteScalar().ToString());
                if ( result> 0) {
                    MessageBox.Show("Выполнен вход в систему!");
                }
                else {
                    MessageBox.Show("Пользователь не найден, проверьте правильность данных");
                }
                //MessageBox.Show("Пользователь зарегестрирован!");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                //
            }
        }
    }
}
