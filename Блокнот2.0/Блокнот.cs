using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Блокнот2._0
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;
        }
        public Notepad(string fileName) // Открытие программы документом
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    notebox.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    notebox.Select(0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        bool tbChange = false;
        string docPath = "";
        private void notebox_TextChanged(object sender, EventArgs e)
        {
            tbChange = true;
            TextWork.StatusAnalize(ref notebox, ref statusLinesCount, ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);
            TextWork.mEditEnableds(ref notebox, ref mEditCopy, ref mEditCut, ref mEditDel, ref mEditFind, ref mEditGo);
        }
        
        private void Notepad_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            notebox.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusStripVisible == true)
            { mViewStatusStrip.CheckState = CheckState.Checked; }
            else
            { mViewStatusStrip.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.textTransfer == true)
            { mFormatTransfer.CheckState = CheckState.Checked; }
            else
            { mFormatTransfer.CheckState = CheckState.Unchecked; }
        }
        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textTransfer = notebox.WordWrap;
            Properties.Settings.Default.textFont = notebox.Font;
            Properties.Settings.Default.statusStripVisible = statusStrip.Visible;
            Properties.Settings.Default.Save();

            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        //Файлы
        private void mFileNew_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWorks.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWorks.CreateFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWorks.CreateFile(ref notebox, ref tbChange, ref docPath);
                }
            }
            else
            {
                FileWorks.CreateFile(ref notebox, ref tbChange, ref docPath);
            }
        }// Создать
        private void mFileOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWorks.SaveFile(ref notebox, ref tbChange, ref docPath);
                        FileWorks.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        FileWorks.SaveAsFile(ref notebox, ref tbChange, ref docPath);
                        FileWorks.OpenFile(ref notebox, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    FileWorks.OpenFile(ref notebox, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                FileWorks.OpenFile(ref notebox, ref tbChange, ref docPath);
            }
        }//Открыть
        private void mFileSave_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                FileWorks.SaveFile(ref notebox, ref tbChange, ref docPath);
            }
            else
            {
                FileWorks.SaveAsFile(ref notebox, ref tbChange, ref docPath);
            }
        }//Сохранить...
        private void mFileSaveAs_Click(object sender, EventArgs e)
        {
            FileWorks.SaveAsFile(ref notebox, ref tbChange, ref docPath);
        }//Созранить Как...
        private void mFilePageParam_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
            }
        }//Параметры страницы печати
        private void mFilePrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }//Печать
        private void mFileExit_Click(object sender, EventArgs e) => Application.Exit();//Выход
        
        
        //Правка
        private void mEditCancel_Click(object sender, EventArgs e) => notebox.Undo();//Отменить
        private void mEditCut_Click(object sender, EventArgs e)//Вырезать
        {
            if (notebox.SelectionLength > 0)
                notebox.Cut(); 
        }
        private void mEditCopy_Click(object sender, EventArgs e)//Копировать
        {
            if (notebox.SelectionLength > 0)
                notebox.Copy(); 
        }
        private void mEditPaste_Click(object sender, EventArgs e) => notebox.Paste(); // Вставить
        private void mEditClear_Click(object sender, EventArgs e)// Удалить
        {
            if (notebox.SelectionLength > 0)
                notebox.SelectedText = "";
        }
        private void mEditFind_Click(object sender, EventArgs e)// Найти и заменить
        {
            SearchForm findText = new SearchForm();
            findText.Owner = this;
            findText.Show();
        }
        private void mEditGo_Click(object sender, EventArgs e)//Перейти
        {
            GoToForm gotoform = new GoToForm();
            gotoform.Owner = this;
            gotoform.tbLineNum.Minimum = 0;
            gotoform.tbLineNum.Maximum = notebox.Lines.Count();
            gotoform.ShowDialog();
        }
        private void mEditSelectAll_Click(object sender, EventArgs e) => notebox.SelectAll();// Выделить всё
        private void mEditTime_Click(object sender, EventArgs e)//Время и Дата
        {
            notebox.AppendText(DateTime.Now.ToShortTimeString() + "  " + DateTime.Now.ToShortDateString());
        }
        private void mEditYourData_Click(object sender, EventArgs e)//Твои Данныйе
        {
            notebox.AppendText("ХА-ХА)) , Твоё железо зовут: " + Environment.MachineName + Environment.NewLine +"А тебя, вероятно ;D : " + Environment.UserName + Environment.NewLine +"Приятного дня =)");
        }
        //Формат
        private void mFormatFont_Click(object sender, EventArgs e)//Шрифт
        {
            fontDialog.Font = notebox.Font;
            DialogResult = fontDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                notebox.Font = fontDialog.Font;
            }
        }
        private void mFormatTransfer_Click(object sender, EventArgs e)//Перенос по словам
        {
            if (mFormatTransfer.CheckState == CheckState.Checked)
            {
                notebox.WordWrap = true;
                notebox.ScrollBars = ScrollBars.Vertical;
                mEditGo.Enabled = false;
                statusLab1.Visible = false;
                statusLinesCount.Visible = false;
            }
            else
            {
                notebox.WordWrap = false;
                notebox.ScrollBars = ScrollBars.Both;
                mEditGo.Enabled = true;
                statusLab1.Visible = true;
                statusLinesCount.Visible = true;
            }
        }
        //Вид
        private void mViewStatusStrip_Click(object sender, EventArgs e)//Строка состояния
        {
            if (mViewStatusStrip.CheckState == CheckState.Checked)
            {
                statusStrip.Visible = true;
            }
            else
            {
                statusStrip.Visible = false;
            }
        }
        //Справка
        private void mHelpAboutProgram_Click(object sender, EventArgs e)//О программе
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
