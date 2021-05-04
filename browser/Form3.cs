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
    public partial class Form3 : Form
    {
        public bool select_itembox = false;
        public Form3()
        {
            InitializeComponent();
        }
        private void box_log_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
        private void butt_voss_Click(object sender, EventArgs e)
        {
            if ((select_itembox == false))
            {

                MessageBox.Show("Вы не выбрали конрольный вопрос");

                return;
            }
            if (questi_answer.Text.ToString().Length == 0)
            {
                //MessageBox.Show(questi_answer.Text);
                MessageBox.Show("Проверьте ответ на контрольный вопрос");
                return;
            }
            if (log_voss.Text.ToString().Length == 0)
            {
                //MessageBox.Show(questi_answer.Text);
                MessageBox.Show("Проверьте введенный логин");
                return;
            }
            if (pass_voss.Text.ToString().Length == 0)
            {
                //MessageBox.Show(questi_answer.Text);
                MessageBox.Show("Проверьте введенный пароль");
                return;
            }
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
                MySqlCommand myCommand = new MySqlCommand("SELECT COUNT(*)  FROM Users WHERE login='" + log_voss.Text + "' AND id_answer='" + questi.SelectedIndex + "'AND answer='" + questi_answer.Text + "'", myConnection);
                // MySqlCommand myCommand = new MySqlCommand("INSERT INTO Users(login,pass,id_answer,answer) VALUES ('" + box_log.Text + "','" + box_pass.Text + "','" + questi.SelectedIndex + "','" + questi_answer.te + "');", myConnection);
                myCommand.ExecuteNonQuery();
                var result = Int32.Parse(myCommand.ExecuteScalar().ToString());
                //если вход выполнен
                if (result > 0)
                {
                    MessageBox.Show("Пользователь найден!");
                    MySqlCommand myCommand1 = new MySqlCommand("UPDATE Users SET pass='" + pass_voss.Text + "' WHERE login='" + log_voss.Text + "';", myConnection);
                    myCommand1.ExecuteNonQuery();

                    MessageBox.Show("Пароль изменен");
                    //закрытие подлючения
                    //myConnection.Close();
                   
                }
                else {
                    return;
                }

               
                //закрытие подлючения
                myConnection.Close();
            }
            //при наличии ошибки выводим ее
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

     

        private void but_reg_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void box_pass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void questi_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_itembox = true;
        }
    }
}
