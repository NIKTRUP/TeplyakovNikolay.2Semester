using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Bookmarks : Form
    {
        public Bookmarks()
        {
            InitializeComponent();
            
        }

        private void bkm_delete_Click(object sender, EventArgs e)
        {
            if (bookmarksCollection.SelectedIndex != -1)
                bookmarksCollection.Items.RemoveAt(bookmarksCollection.SelectedIndex);
        }

        private void bkm_clear_Click(object sender, EventArgs e)
        {
            if (bookmarksCollection.Items.Count != 0)
                bookmarksCollection.Items.Clear();
        }

        private void bkm_exit_Click(object sender, EventArgs e) => Close();

        private void Bookmarks_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void bookmarksCollection_Click(object sender, EventArgs e)
        {
           
        }

        private void bkm_transition_Click(object sender, EventArgs e)
        {
            // берём выделенный элемент из коллекции и отправляем в W
            Application.OpenForms.OfType<Web>().Single().AddTabPages(bookmarksCollection.Items[bookmarksCollection.SelectedIndex].ToString());
        }

        private void bookmarksCollection_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.OpenForms.OfType<Web>().Single().AddTabPages(bookmarksCollection.Items[bookmarksCollection.SelectedIndex].ToString());
        }
    }
}
