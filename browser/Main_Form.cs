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

        FmAutofill fmAutofill = new FmAutofill();


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
            try
            {
                listBox1.Items.AddRange(File.ReadAllLines("history.txt"));
            }
            catch { 
            
            }
            //вызов функций
            toolStrip2.SizeChanged += ToolStrip2_SizeChanged;
            this.SizeChanged += Form1_SizeChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
            chromeBrowser.AddressChanged += ChromeBrowser_AddressChanged;
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            textUrl.Click += TextUrl_Click;
            textUrl.KeyUp += TextUrl_KeyUp;

            chromeBrowser.LoadingStateChanged += OnLoadingStateChanged;

            profile_Process();

            //проверка наличия файла истории
            if (!File.Exists(currentPath + @"\history.txt"))
            {
                File.Create(currentPath + @"\history.txt");
            }
        }

        //массив эвентов, которые вызываются на поле для ввода 
        string[] arrEvents = { "pointerover", "mousedown", "change", "focus", "blur", "input", "focusout", "click", "xhMeHaDAa", "hXEVLyyNg", "touchend" };

        //массив id полей для ввода данных, которые при совпадении срабатывают для заполнения 
        string[][] Params = new string[][]
        {
                        new string[] { "firstName", "fname", "ORDER_PROP_1", "korz_imy"},
                        new string[] { "lastName", "lname"},
                        new string[] { "address1", "ORDER_PROP_7"},
                        new string[] { "city"},
                        new string[] { "zipcode"},
                        new string[] { "houseNumber" },
                        new string[] { "phoneNumber", "ORDER_PROP_3", "korz_tel"},
                        new string[] { "emailAddress", "email", "ORDER_PROP_2", "korz_mail" },
                        new string[] { "password" }
        };

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                if (fmAutofill.afAdidas)
                {
                    //данные, которые будут заполняться 
                    string[] dataToPaste =
                    {"Станислав Сиротинин", "Сиротинин", "г Москва, ул Парковая 7-я, д 9/26",
                        "Москва", "105043", "9/26", "+7(910)262-07-51", "stassir99@gmail.com", "pass123"};

                    //вызываемый на странице скрипт
                    for (int i = 0; i < Params.Length; i++)
                    {
                        for (int k = 0; k < Params[i].Length; k++)
                        {
                            //пытаемся вставить данные в поле для ввода
                            chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + Params[i][k] + "]').value = '" + dataToPaste[i] + "';");
                            for (int j = 0; j < arrEvents.Length; j++)
                            {
                                //вызываем метод dispatchEvent с типом эвентов из массива для того, чтобы сайт подумал, что мы ввели данные, а не изменили value
                                chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + Params[i][k] + "]').dispatchEvent(new Event('" + arrEvents[j] + "', {bubbles: true})); ");
                            }
                            //пытаемся еще раз вставить данные в поле для ввода
                            chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + Params[i][k] + "]').value = '" + dataToPaste[i] + "';");
                        }
                    }
                    //прожатие кнопок на adidas 
                    chromeBrowser.ExecuteScriptAsync("document.querySelector('input[data-auto-id=explicit-consent-checkbox]').click()");
                    chromeBrowser.ExecuteScriptAsync("document.querySelector('button[data-auto-id=review-and-pay-button]').click();");
                    chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=confirm_reg_policy]').click();");

                }

                //не работает 
                if (fmAutofill.afEnd)
                {
                    string[] dataToPaste =
                    {"Stanislav", "Sirotinin", "г Москва, ул Парковая 7-я, д 9/26",
                        "Москва", "105043", "9/26", "+7(910)262-07-51", "govno123mail3@mail.ru", "pass123"};

                    chromeBrowser.ExecuteScriptAsync("document.querySelector('button.sc-1bm65b4-1.khrZHe').click()");

                    for (int i = 0; i < Params.Length; i++)
                    {
                        for (int k = 0; k < Params[i].Length; k++)
                        {         
                            for (int j = 0; j < arrEvents.Length; j++)
                            {
                                chromeBrowser.ExecuteScriptAsyncWhenPageLoaded("document.querySelector('input[id=" + Params[i][k] + "]').dispatchEvent(new Event('" + arrEvents[j] + "', {bubbles: true})); ");
                                chromeBrowser.ExecuteScriptAsyncWhenPageLoaded("document.querySelector('input[id=" + Params[i][k] + "]').value = '" + dataToPaste[i] + "';");
                            }

                        }
                    }
                }
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
            chromeBrowser.Reload(true);
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
                try
                {
                    using (StreamWriter sw = new StreamWriter(currentPath + @"\history.txt", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(url);
                        sw.Close();

                    }
                    
                    string s = File.ReadAllLines(@"history.txt").Last();
                    System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                    listBox1.Items.Add(s.ToString());
                }
                catch { 
                
                }
            }
          
            if (laVhod.Text == "Вы вошли в систему как: ") {
               
                    using (StreamWriter sw = new StreamWriter(currentPath + $@"\history{laUser.Text}.txt", true, System.Text.Encoding.Default))
                    {
                        buExit.Visible = true;
                        sw.WriteLine(url);

                        sw.Close();

                        myConnection.Open();
                        MySqlCommand myCommand = new MySqlCommand("INSERT INTO " + laUser.Text + "(" + laUser.Text + ") VALUES ('" + url + "');", myConnection);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                    }
                    System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                    string s = File.ReadAllLines($@"history{laUser.Text}.txt").Last();
                    listBox1.Items.Add(s.ToString());
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

        private void laVhod_Click(object sender, EventArgs e)
        {

        }

        private void buExit_Click(object sender, EventArgs e)
        {
            laVhod.Text = "Вход не выполнен";
            buExit.Visible = false;
            laUser.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            if (laVhod.Text == "Вход не выполнен")
            {
                FileStream fs = File.Open("history.txt", FileMode.Open, FileAccess.ReadWrite);
                fs.SetLength(0);
                fs.Close();
            }
            if (laVhod.Text == "Вы вошли в систему как: ")
            {
                FileStream fs = File.Open(currentPath + $@"\history{laUser.Text}.txt", FileMode.Open, FileAccess.ReadWrite);
                fs.SetLength(0);
                fs.Close();

            }
        }


		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
            fmAutofill.ShowDialog();
        }

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
            chromeBrowser.ShowDevTools();
        }

        private void hist_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                hist.Text = "Скрыть историю";
                groupBox1.Visible = true;
                listBox1.Visible = true;
                button1.Visible = true;
            }
            else
            {
                hist.Text = "Показать историю";
                groupBox1.Visible = false;
                listBox1.Visible = false;
                button1.Visible = false;
            }

        }


        //обработка нажатия на Профиль пользователя
        private void buProfile_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2(laVhod, laUser,buExit,listBox1); 
           
            frm.Show();
        }
    }
}


