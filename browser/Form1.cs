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
using System.Xml.Linq;

namespace browser
{

    public partial class Form1 : Form
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
        private bool writeFlag = true;
        public MySqlConnection myConnection;

        

        FmAutofill fmAutofill = new FmAutofill();

        public Form1()
        {
            InitializeComponent();// инициализация компонентов
            this.TopMost = true;
            this.Update();
            InitializeChromium(); // инициализация браузера

            toolStrip2.ImageScalingSize = new Size(30, 30); // задаем размер иконок в тулбаре

            currentPath = Directory.GetCurrentDirectory().ToString(); //объявляем корневую директорию
            //вызов функций
            toolStrip2.SizeChanged += ToolStrip2_SizeChanged;
            this.SizeChanged += Form1_SizeChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
            chromeBrowser.AddressChanged += ChromeBrowser_AddressChanged;
            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            textUrl.Click += TextUrl_Click;
            textUrl.KeyUp += TextUrl_KeyUp;

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
            //проверка наличия файла истории
            if (!File.Exists(currentPath + @"\history.txt"))
            {
                File.Create(currentPath + @"\history.txt");

            } 
			this.KeyDown += Form1_KeyPress;
            chromeBrowser.LoadingStateChanged += OnLoadingStateChanged;
			chromeBrowser.KeyDown += ChromeBrowser_KeyDown;
        }

		private void ChromeBrowser_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.F5)
            {
                chromeBrowser.Reload(true);
            }
        }

		private void Form1_KeyPress(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.F5)
			{
                chromeBrowser.Reload(true);
            }

        }


        //массив эвентов, которые вызываются на поле для в вода 
        string[] arrEvents = { "pointerover", "mousedown", "change", "focus", "blur", "input", "focusout", "click", "xhMeHaDAa", "hXEVLyyNg", "touchend" };
        //string[] arrEvents = { "focus" };

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

        //основная функция
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
                    //chromeBrowser.ExecuteScriptAsync("document.querySelector('button.sc-1bm65b4-1.khrZHe').click()");


                    for (int i = 0; i < Params.Length; i++)
                    {
                        for (int k = 0; k < Params[i].Length; k++)
                        {
                            //chromeBrowser.ExecuteScriptAsync("document.querySelector('input[id=" + Params[i][k] + "]').value = '" + dataToPaste[i] + "';");
                            for (int j = 0; j < arrEvents.Length; j++)
                            {
                                chromeBrowser.ExecuteScriptAsyncWhenPageLoaded("document.querySelector('input[id=" + Params[i][k] + "]').dispatchEvent(new Event('" + arrEvents[j] + "', {bubbles: true})); ");
                                chromeBrowser.ExecuteScriptAsyncWhenPageLoaded("document.querySelector('input[id=" + Params[i][k] + "]').value = '" + dataToPaste[i] + "';");
                            }


                            /*for (int j = 0; j < arrEvents.Length; j++)
                            {
                                chromeBrowser.ExecuteScriptAsyncWhenPageLoaded("document.querySelector('input[id=" + Params[i][k] + "]').dispatchEvent(new Event('" + arrEvents[j] + "', {bubbles: true})); ");
                            }*/


                        }
                    }
                }
                /*

                chromeBrowser.ExecuteScriptAsync("document.querySelector('li.delivery-tabs.tabs-title').click();" +
                    "" +
                    "document.querySelector('button[id=shop160]').click()");
                chromeBrowser.ExecuteScriptAsync("document.querySelector('label[for=korz_payment_tupe3] div').click();");

                */


                /*
                chromeBrowser.ExecuteScriptAsync("document.querySelector('select[data - fieldvalidtemplate = location_region]').value = '184'");
                for (int j = 0; j < arrEvents.Length; j++) { 
                    chromeBrowser.ExecuteScriptAsync("document.querySelector('select[data-fieldvalidtemplate=location_region] option[value='184']').dispatchEvent(new Event('blur'));");
                } 
                chromeBrowser.ExecuteScriptAsync("document.querySelector('select[data - fieldvalidtemplate = location_region]').value = '184'");
                */

                /*
                chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + arrNames[0] + "]').value = '"+ name +"';");
				for (int j = 0; j < arrEvents.Length; j++)
				{
                    chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + arrNames[0] + "]').dispatchEvent(new Event('"+ arrEvents[j] +"', {bubbles: true})); ");
                }
                chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + arrNames[0] + "]').value = '" + name + "';");



                chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + arrSurnames[0] + "]').value = '"+ surname + "';");
				for (int j = 0; j < arrEvents.Length; j++)
				{
                    chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + arrSurnames[0] + "]').dispatchEvent(new Event('"+ arrEvents[j] +"', {bubbles: true})); ");
                }
                chromeBrowser.ExecuteScriptAsync("document.querySelector('input[name=" + arrSurnames[0] + "]').value = '" + surname + "';");

                */




                /*
                chromeBrowser.ExecuteScriptAsync(
                
                "document.querySelector('input[name=firstName]').value = 'Имяепта'; " +
                "document.querySelector('input[name=firstName]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=firstName]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=firstName]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=firstName]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=firstName]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=firstName]').value = 'Имяепта'; " +

                "document.querySelector('input[name=address1]').value = 'address 123'; " + 
                "document.querySelector('input[name=address1]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=address1]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=address1]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=address1]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=address1]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=address1]').value = 'address 123'; " +

                "document.querySelector('input[name=lastName]').value = 'Фамилияда'; " +
                "document.querySelector('input[name=lastName]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=lastName]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=lastName]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=lastName]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=lastName]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=lastName]').value = 'Фамилияда'; " +

                "document.querySelector('input[name=city]').value = 'Москва'; " +
                "document.querySelector('input[name=city]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=city]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=city]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=city]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=city]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=city]').value = 'Москва'; " +


                "document.querySelector('input[name=zipcode]').value = '105043'; " +
                "document.querySelector('input[name=zipcode]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=zipcode]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=zipcode]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=zipcode]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=zipcode]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=zipcode]').value = '105043'; " +


                "document.querySelector('input[name=houseNumber]').value = '9/26'; " +
                "document.querySelector('input[name=houseNumber]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=houseNumber]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=houseNumber]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=houseNumber]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=houseNumber]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=houseNumber]').value = '9/26'; " +


                "document.querySelector('input[name=phoneNumber]').value = '+7(910)262-07-99'; " +
                "document.querySelector('input[name=phoneNumber]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=phoneNumber]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=phoneNumber]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=phoneNumber]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=phoneNumber]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=phoneNumber]').value = '+7(910)262-07-99'; " +

                "document.querySelector('input[name=emailAddress]').value = 'stassir99@gmail.com'; " +
                "document.querySelector('input[name=emailAddress]').dispatchEvent(new Event('change', {bubbles: true})); " +
                "document.querySelector('input[name=emailAddress]').dispatchEvent(new Event('blur', {bubbles: true}));" +
                "document.querySelector('input[name=emailAddress]').dispatchEvent(new Event('focus', {bubbles: true})); " +
                "document.querySelector('input[name=emailAddress]').dispatchEvent(new Event('input', {bubbles: true})); " +
                "document.querySelector('input[name=emailAddress]').dispatchEvent(new Event('focusout', {bubbles: true})); " +
                "document.querySelector('input[name=emailAddress]').value = 'stassir99@gmail.com'; " 

                
                );*/
            }
        }

      //  void autodispatch ()

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
                //var doc = XDocument.Load(url);

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
            string startUrl =
             //"https://www.adidas.ru/krossovki-lite-racer-rbn-2.0/FY8188.html";
            "https://kotofoto.ru/shop/uid_407681_videokarta_pny_tesla_t4_16gb_tcst4matx_pb.html";
            //"https://launches.endclothing.com/product/yeezy-500-gx3605";
            textUrl.Text = startUrl;
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

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
            
        }

		private void button1ToolStripMenuItem_Click(object sender, EventArgs e)
		{

            fmAutofill.ShowDialog();
            
            

        }

        private void button2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            chromeBrowser.ShowDevTools();
        }
	}
}


