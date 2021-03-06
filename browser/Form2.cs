using CefSharp.WinForms;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browser
{
    public partial class Form2 : Form
    {
        public bool select_itembox=false;
        public static readonly string Empty;
        //private ToolStrip tool_form1;//конструктор
        public ToolStripLabel laVhod1=new ToolStripLabel("Вход");
        public ToolStripLabel laUser1 = new ToolStripLabel("Вход");
        public ToolStripButton exit1 = new ToolStripButton();
        public string currentPath;
        ListBox list123 = new ListBox();
        public Form2(ToolStripLabel vhod, ToolStripLabel user, ToolStripButton exit,ListBox list2)
        {
            laVhod1 = vhod;
            laUser1 = user;
            exit1 = exit;
            list123 = list2;
            currentPath = Directory.GetCurrentDirectory().ToString(); //объявляем корневую директорию
            InitializeComponent();// инициализация компонентов
        }
        public Form2()
        {
          
            InitializeComponent();// инициализация компонентов
        }
        //кнопка регистрации
        private void but_reg_Click(object sender, EventArgs e)
        {
           
            if (box_pass.Text != pass_accept.Text)
            {
                MessageBox.Show("Введенные пароли не совпадают");
                return;
            }
            if ((select_itembox==false))
            {

                MessageBox.Show("Вы не выбрали контрольный вопрос");
                
                return;
            }
            if (questi_answer.Text.ToString().Length==0)
            {
                //MessageBox.Show(questi_answer.Text);
                MessageBox.Show("Проверьте ответ на контрольный вопрос");
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
                MySqlCommand myCommand = new MySqlCommand("INSERT INTO Users(login,pass,id_answer,answer) VALUES ('" + box_log.Text + "','" + box_pass.Text + "','" + questi.SelectedIndex + "','" + questi_answer.Text + "');", myConnection);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь зарегистрирован!");
                MySqlCommand myCommand1 = new MySqlCommand("CREATE TABLE "+box_log.Text+" ("+box_log.Text+" VARCHAR(10000));", myConnection);
                myCommand1.ExecuteNonQuery();
                //закрытие подлючения
                myConnection.Close();
            }
            //при наличии ошибки выводим ее
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            this.Close();
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
                    laVhod1.Text = "Вы вошли в систему как: ";
                    laUser1.Text = log_vhod.Text;
                    exit1.Visible = true;
                    MySqlCommand myCommand_any = new MySqlCommand("SELECT *  FROM "+log_vhod.Text+"", myConnection);
                    MySqlDataReader reader = myCommand_any.ExecuteReader();
                    StreamWriter write = new StreamWriter(currentPath+ $@"\history{log_vhod.Text}.txt");
                    while (reader.Read()) {
                        write.Write("{0}", reader[0]);
                        write.WriteLine();
                    }
                    write.Close();
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
            }
            
            this.Close();
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

        private void questi_SelectedIndexChanged(object sender, EventArgs e)
        {
            select_itembox = true;
            label7.Visible = true;
            questi_answer.Visible = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            select_itembox = false;
            label7.Visible = false;
            questi_answer.Visible = false;
        }

        private void butt_forgot_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
