using browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySqlConnector;
using System;

namespace unittest_lyubimov
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Class_Tests();
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
            var exp = true;
            
            MySqlConnection myConnection = new MySqlConnection(mysqlCSB.ConnectionString);
            var res = test.connection(myConnection);
            
            Assert.AreEqual(res, exp);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            var login = "menelai";
            var passs = "123";
            var test = new Class_Tests();


            var exp = true;
            var res = test.password_login(login, passs);

            Assert.AreEqual(res, exp);

        }
    }
}
