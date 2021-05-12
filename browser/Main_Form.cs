using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using MySqlConnector;
using EasyTabs;
using CefSharp.WinForms;
using System.Windows.Forms;
using System.IO;

namespace browser
{

    public partial class Main_Form : Form
    {


        protected TitleBarTabs ParentTabs
        { // вызов вкладок
            get
            {
                return (ParentForm as TitleBarTabs);
            }

        }
        public ChromiumWebBrowser chromeBrowser; // объявление компонентов, переменных
        private string currentPath;
        public MySqlConnection myConnection;
        public double width, height;
        public Main_Form()
        {
            InitializeComponent();// инициализация компонентов
            this.TopMost = true;
            this.Update();
            InitializeChromium(); // инициализация браузера

            toolStrip2.ImageScalingSize = new Size(30, 30); // задаем размер иконок в тулбаре
            width = this.ClientSize.Width;
            height = this.ClientSize.Height;

            currentPath = Directory.GetCurrentDirectory().ToString(); //объявляем корневую директорию

            //вызов функций
            toolStrip2.SizeChanged += ToolStrip2_SizeChanged;
            this.SizeChanged += Form1_SizeChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
            chromeBrowser.AddressChanged += ChromeBrowser_AddressChanged;
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            textUrl.Click += TextUrl_Click;
            textUrl.KeyUp += TextUrl_KeyUp;

            profile_Process();

            //проверка наличия файла истории
            if (!File.Exists(currentPath + @"\history.txt"))
            {
                File.Create(currentPath + @"\history.txt");

            }


        }

        private void profile_Process()
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
            myConnection = new MySqlConnection(mysqlCSB.ConnectionString);

        }
        // функция изменения статуса загрузки браузера
        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
                write_history(chromeBrowser.Address.ToString());

        }
        //обработка клика по URL
        private void TextUrl_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textUrl.Text))
            {
                textUrl.SelectionStart = 0;
                textUrl.SelectionLength = textUrl.Text.Length;
            }
        }

        //обработка изменения размера URL
        private void ToolStrip2_SizeChanged(object sender, EventArgs e)
        {
            int size = buBack.Width + buForward.Width + buRefresh.Width + buSearch.Width + buSettings.Width + buProfile.Width;
            textUrl.Width = toolStrip2.Width - size;
        }

        //обработка нажатия на enter
        private void TextUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(textUrl.Text);

        }

        //загрузка URL или поискового запроса
        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {

                chromeBrowser.Load(url);

            }
            else
            {
                chromeBrowser.Load("https://www.google.com/search?q=" + url);

            }
        }


        // изменение заголовка 
        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = e.Title);

        }

        //изменение адресной строки в зависимости от того, где находится пользователь
        private void ChromeBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => textUrl.Text = e.Address);


        }

        //изменение размеров формы
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            toolStrip2.Width = this.Width;
            //chromeBrowser.Size = pContainer.Size;
            //this.Invalidate();

        }

        //начальные параметры загрузки браузера
        public void InitializeChromium()
        {

            textUrl.Text = "https://www.google.com";
            chromeBrowser = new ChromiumWebBrowser(textUrl.Text);

            chromeBrowser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(chromeBrowser);


        }

        //обработка перезагрузки страницы
        private void buRefresh_Click(object sender, EventArgs e)
        {
            chromeBrowser.Refresh();
        }

        //обработка нажатия на поиск
        private void buSearch_Click(object sender, EventArgs e)
        {
            LoadUrl(textUrl.Text);


        }

        // запись истории
        private void write_history(string url)
        {

            if (laVhod.Text == "Вход не выполнен")
            {
                using (StreamWriter sw = new StreamWriter(currentPath + @"\history.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(url);
                    sw.Close();
                }
            }
            if (laVhod.Text == "Вы вошли в систему как: ") {
                using (StreamWriter sw = new StreamWriter(currentPath + $@"\history{laUser.Text}.txt", true, System.Text.Encoding.Default))
                {

                    sw.WriteLine(url);
                    sw.Close();
                    myConnection.Open();
                    MySqlCommand myCommand = new MySqlCommand("INSERT INTO "+laUser.Text+"(" + laUser.Text + ") VALUES ('" + url + "');", myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
            }

        }

        //обработка открытия файла
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Office Files|*.pdf;*.txt;*.html";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textUrl.Text = dialog.FileName;
                chromeBrowser.Load(textUrl.Text);
            }


            write_history(textUrl.Text);
        }

        //обработка нажатия кнопки Назад
        private void buBack_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        //обработка нажатия кнопки Вперед
        private void buForward_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        //обработка нажатия на Профиль пользователя
        private void buProfile_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2(laVhod, laUser); 
           
            frm.Show();
        }
    }
}


