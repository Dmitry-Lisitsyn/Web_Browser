using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MySqlConnector;

namespace browser
{
    public class Class_Tests
    {
        public bool IspageCorrect(string str)
        {
            if (str == "https://www.google.com")
                return true;
            else
                return false;
        }

        public bool IsSizeMax(double width, double height)
        {
            if (width == 1920 && height == 997)
                return true;
            else
                return false;

        }
        public bool connection(MySqlConnection myConnection)
        {
            try
            {
                myConnection.Open();

            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool password_login(string log, string pass)
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
            myConnection.Open();

            //проверка наличия логина и пароля в БД
            MySqlCommand myCommand = new MySqlCommand("SELECT COUNT(*)  FROM Users WHERE login='" + log + "' AND pass='" + pass + "'", myConnection);
            myCommand.ExecuteNonQuery();

            var result = Int32.Parse(myCommand.ExecuteScalar().ToString());
            //если вход выполнен
            if (result > 0)
            {

                return true;
            }

            return false;
        }
    }
}
