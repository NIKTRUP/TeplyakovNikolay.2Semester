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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void hst_delete_Click(object sender, EventArgs e)
        {
            if(historyCollection.SelectedIndex != -1)
                historyCollection.Items.RemoveAt(historyCollection.SelectedIndex);
        }

        private void hst_clear_Click(object sender, EventArgs e)
        {
            if (historyCollection.Items.Count != 0)
                historyCollection.Items.Clear();
        }

        private void hst_Exit_Click(object sender, EventArgs e)
        {

            Close();
            
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void hst_transition_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Web>().Single().AddTabPages(historyCollection.Items[historyCollection.SelectedIndex].ToString());
        }

        private void historyCollection_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            Application.OpenForms.OfType<Web>().Single().AddTabPages(historyCollection.Items[historyCollection.SelectedIndex].ToString());
        }
    }
}
