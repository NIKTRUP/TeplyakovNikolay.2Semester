using System.IO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//sender - объект, инициировавший событие, и аргумент, хранящий информацию о событии (в данном случае EventArgs e).
namespace Web_Browser
{
    public partial class Web : Form
    {
        int tab_index = 0;
        History historyForm;
        Bookmarks bookmarksForm;
        string lastAdress;

        public Web()
        {
            InitializeComponent();
            historyForm = new History();
            bookmarksForm = new Bookmarks();
            bookmarksForm.bookmarksCollection.Items.Clear();
            historyForm.historyCollection.Items.Clear();
            ReadBookmarks();
            ReadHistory();
        }
        private void Web_Load(object sender, EventArgs e)
        {
            AddTabPages();
        }

        private void bt_addTab_Click(object sender, EventArgs e)
        {
            AddTabPages();
        }

        private void AddTabPages()
        {
            AddTabPages("https://yandex.ru");
        }
        public void AddTabPages(string url)
        {
            if (url != "")
            {
                // экземпляр объекта Веб-браузер
                WebBrowser web = new WebBrowser();
                // видимый
                web.Visible = true;
                // отображает все ошибуи
                web.ScriptErrorsSuppressed = true;
                // на полный экран
                web.Dock = DockStyle.Fill;
                // Title  самой веб страницы отображался в названии вкладки
                web.DocumentCompleted += TabPages_DocumentCompleted;
                // добавляем страницу
                tabControl.TabPages.Add("Новая вкладка");
                // выделяем вкладку с определённым индексом
                tabControl.SelectTab(tab_index);
                tabControl.SelectedTab.Controls.Add(web);
                web.Navigate(url);
                tab_index++;
            }
        }

            private void TabPages_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (((WebBrowser)sender).Url.ToString() != "about:blank")
            {

                tabControl.SelectedTab.Text = ((WebBrowser)tabControl.SelectedTab.Controls[0]).DocumentTitle;

                ADDtoDatabaseHistory();
                SaveHistory(((WebBrowser)sender).Url.ToString());// 
            }
        }

        private void SaveHistory(string nowOpen)
        {
            if (nowOpen != "")
            {
                try
                {
                    if (nowOpen != lastAdress)
                    {
                        historyForm.historyCollection.Items.Add(nowOpen);
                    }
                }
                catch
                {
                    historyForm.historyCollection.Items.Add(nowOpen);
                }
                lastAdress = nowOpen;
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (adressBar.Text != null)
            {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(adressBar.Text);
            }
        }

        private void adressBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(adressBar.Text);
            }
        }

        private void ADDtoDatabaseHistory()
        {
            Database databaseHistory = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `history`(`URL`) VALUES (@URl)", databaseHistory.getConnection());

            command.Parameters.Add("@URL", MySqlDbType.VarChar).Value = adressBar.Text;

            databaseHistory.openConnection();


            databaseHistory.closeConnection();
        }
        private void setBookmarks()
        {
            StreamWriter writer = new StreamWriter("Bookmarks.txt");           
            foreach (string bookm in bookmarksForm.bookmarksCollection.Items)
            {
                writer.Write(bookm+'\n');
            }          
            writer.Close();
            

        }
        private void ReadBookmarks()
        {
            // Объявляет объект , который читает файл 
            StreamReader readerBookmarks = new StreamReader("Bookmarks.txt");
            // чтение всего содержимого до конца 
            string fileString = readerBookmarks.ReadToEnd();
            // разбивает по строкам
            string[] fileData = fileString.Split('\n');
            for (int i = 0; i < fileData.Length; i++)
            {
                bookmarksForm.bookmarksCollection.Items.Add(fileData[i]);
            }
            readerBookmarks.Close();
        }
        private void setHistory()
        {
            StreamWriter writer = new StreamWriter("History.txt");
            foreach (string hist in historyForm.historyCollection.Items)
            {
                writer.Write(hist+'\n');
            }
            writer.Close();
        }
        private void ReadHistory()
        {
            // Объявляет объект , который читает файл 
            StreamReader readerHistory = new StreamReader("History.txt");
            // чтение всего содержимого до конца 
            string fileString = readerHistory.ReadToEnd();
            // разбивает по строкам
            string[] fileData = fileString.Split('\n');
            for (int i = 0; i < fileData.Length; i++)
            {
                historyForm.historyCollection.Items.Add(fileData[i]);
            }
            readerHistory.Close();
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoBack();
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoForward();
        }

        private void bt_reboot_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Refresh();
        }

        private void bt_removeTab_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 1)
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
                tab_index--;
            }
            else Application.Exit();
        }

        private void adressBar_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count == 0)
            {
                AddTabPages();
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Stop();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoHome();
        }

        private void bt_bookmark_Click_1(object sender, EventArgs e)
        {


            Database dbBookmark = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `bookmark`(`URLbookmark`) VALUES (@URLbookmark)", dbBookmark.getConnection());

            command.Parameters.Add("@URLbookmark", MySqlDbType.VarChar).Value = adressBar.Text;

            dbBookmark.openConnection();


            dbBookmark.closeConnection();
            bool flag = false;

            foreach (string item in bookmarksForm.bookmarksCollection.Items)
            {
                if (item == ((WebBrowser)tabControl.SelectedTab.Controls[0]).Url.ToString())
                    flag = true;     
            }
            if (!flag)
            bookmarksForm.bookmarksCollection.Items.Add(((WebBrowser)tabControl.SelectedTab.Controls[0]).Url.ToString());
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {

            historyForm.Visible = true;
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).ShowSaveAsDialog();
        }

        private void закладкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmarksForm.Visible = true;
        }

        private void Web_FormClosing(object sender, FormClosingEventArgs e)
        {
            setBookmarks();
            setHistory();
        }
    }
}
