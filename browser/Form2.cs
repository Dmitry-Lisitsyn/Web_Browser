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
        //конструктор
        public Form2()
        {
            InitializeComponent();// инициализация компонентов
        }
        //кнопка регистрации
        private void but_reg_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            //доменное имя
            mysqlCSB.Server = "menelai.ddns.net";
            //логин от сервера mySql
            mysqlCSB.UserID = "menelai";
            //пароль
            mysqlCSB.Password = "123";
            //кодировка символов
            mysqlCSB.CharacterSet = "utf8";
            //порт
            mysqlCSB.Port = 3333;
            //имя базы данных
            mysqlCSB.Database = "Browser";
            //создание подключения
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);





            try
            {
                //открытие подключения
                myConnection.Open();

                //внесение данных в БД
                MySqlCommand myCommand = new MySqlCommand("INSERT INTO Users(login,pass) VALUES ('" + box_log.Text + "','" + box_pass.Text + "');", myConnection);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь зарегестрирован!");
                //закрытие подлючения
                myConnection.Close();
            }
            //при наличии ошибки выводим ее
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

            }
        }
        //обработка Sign Up
        private void but_vhod_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
            //доменное имя
            mysqlCSB.Server = "menelai.ddns.net";
            //логин от сервера mySql
            mysqlCSB.UserID = "menelai";
            //пароль
            mysqlCSB.Password = "123";
            //кодировка символов
            mysqlCSB.CharacterSet = "utf8";
            //порт
            mysqlCSB.Port = 3333;
            //имя базы данных
            mysqlCSB.Database = "Browser";
            //создание подключения
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);





            try
            {
                //открытие подключения
                myConnection.Open();

                //проверка наличия логина и пароля в БД
                MySqlCommand myCommand = new MySqlCommand("SELECT COUNT(*)  FROM Users WHERE login='" + log_vhod.Text + "' AND pass='" + pass_vhod.Text + "'", myConnection);
                myCommand.ExecuteNonQuery();

                var result = Int32.Parse(myCommand.ExecuteScalar().ToString());
                //если вход выполнен
                if (result > 0)
                {
                    MessageBox.Show("Выполнен вход в систему!");
                }
                //если введенные данные пользователя не соответсвуют данным в БД
                else
                {
                    MessageBox.Show("Пользователь не найден, проверьте правильность данных");
                }
                //закрытие подключения
                myConnection.Close();
            }
            //при наличии ошибки выводим ее
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                //
            }
        }
    }
}
