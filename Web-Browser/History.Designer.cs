
namespace Web_Browser
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.historyHeader = new System.Windows.Forms.Panel();
            this.hst_delete = new System.Windows.Forms.Button();
            this.hst_clear = new System.Windows.Forms.Button();
            this.hst_exit = new System.Windows.Forms.Button();
            this.historyCollection = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hst_transition = new System.Windows.Forms.Button();
            this.historyHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyHeader
            // 
            this.historyHeader.Controls.Add(this.hst_transition);
            this.historyHeader.Controls.Add(this.hst_exit);
            this.historyHeader.Controls.Add(this.hst_clear);
            this.historyHeader.Controls.Add(this.hst_delete);
            this.historyHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.historyHeader.Location = new System.Drawing.Point(0, 0);
            this.historyHeader.Name = "historyHeader";
            this.historyHeader.Size = new System.Drawing.Size(554, 30);
            this.historyHeader.TabIndex = 0;
            // 
            // hst_delete
            // 
            this.hst_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.hst_delete.Location = new System.Drawing.Point(0, 0);
            this.hst_delete.Name = "hst_delete";
            this.hst_delete.Size = new System.Drawing.Size(75, 30);
            this.hst_delete.TabIndex = 0;
            this.hst_delete.Text = "Удалить";
            this.hst_delete.UseVisualStyleBackColor = true;
            this.hst_delete.Click += new System.EventHandler(this.hst_delete_Click);
            // 
            // hst_clear
            // 
            this.hst_clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.hst_clear.Location = new System.Drawing.Point(75, 0);
            this.hst_clear.Name = "hst_clear";
            this.hst_clear.Size = new System.Drawing.Size(75, 30);
            this.hst_clear.TabIndex = 1;
            this.hst_clear.Text = "Очистить";
            this.hst_clear.UseVisualStyleBackColor = true;
            this.hst_clear.Click += new System.EventHandler(this.hst_clear_Click);
            // 
            // hst_exit
            // 
            this.hst_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.hst_exit.Location = new System.Drawing.Point(150, 0);
            this.hst_exit.Name = "hst_exit";
            this.hst_exit.Size = new System.Drawing.Size(75, 30);
            this.hst_exit.TabIndex = 2;
            this.hst_exit.Text = "Закрыть";
            this.hst_exit.UseVisualStyleBackColor = true;
            this.hst_exit.Click += new System.EventHandler(this.hst_Exit_Click);
            // 
            // historyCollection
            // 
            this.historyCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyCollection.FormattingEnabled = true;
            this.historyCollection.Location = new System.Drawing.Point(0, 30);
            this.historyCollection.Name = "historyCollection";
            this.historyCollection.Size = new System.Drawing.Size(554, 291);
            this.historyCollection.TabIndex = 1;
            this.historyCollection.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.historyCollection_MouseDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(272, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 2;
            // 
            // hst_transition
            // 
            this.hst_transition.Dock = System.Windows.Forms.DockStyle.Left;
            this.hst_transition.Location = new System.Drawing.Point(225, 0);
            this.hst_transition.Name = "hst_transition";
            this.hst_transition.Size = new System.Drawing.Size(122, 30);
            this.hst_transition.TabIndex = 3;
            this.hst_transition.Text = "Переход по ссылке";
            this.hst_transition.UseVisualStyleBackColor = true;
            this.hst_transition.Click += new System.EventHandler(this.hst_transition_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.historyCollection);
            this.Controls.Add(this.historyHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.Text = "History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.History_FormClosing);
            this.historyHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel historyHeader;
        private System.Windows.Forms.Button hst_exit;
        private System.Windows.Forms.Button hst_clear;
        private System.Windows.Forms.Button hst_delete;
        public System.Windows.Forms.ListBox historyCollection;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button hst_transition;
    }
}