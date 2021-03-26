
namespace Web_Browser
{
    partial class Bookmarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookmarks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookmarksCollection = new System.Windows.Forms.ListBox();
            this.bkm_delete = new System.Windows.Forms.Button();
            this.bkm_clear = new System.Windows.Forms.Button();
            this.bkm_exit = new System.Windows.Forms.Button();
            this.bkm_transition = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bkm_transition);
            this.panel1.Controls.Add(this.bkm_exit);
            this.panel1.Controls.Add(this.bkm_clear);
            this.panel1.Controls.Add(this.bkm_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 30);
            this.panel1.TabIndex = 0;
            // 
            // bookmarksCollection
            // 
            this.bookmarksCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarksCollection.FormattingEnabled = true;
            this.bookmarksCollection.Location = new System.Drawing.Point(0, 30);
            this.bookmarksCollection.Name = "bookmarksCollection";
            this.bookmarksCollection.Size = new System.Drawing.Size(554, 291);
            this.bookmarksCollection.TabIndex = 1;
            this.bookmarksCollection.Click += new System.EventHandler(this.bookmarksCollection_Click);
            this.bookmarksCollection.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bookmarksCollection_MouseDoubleClick);
            // 
            // bkm_delete
            // 
            this.bkm_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.bkm_delete.Location = new System.Drawing.Point(0, 0);
            this.bkm_delete.Name = "bkm_delete";
            this.bkm_delete.Size = new System.Drawing.Size(75, 30);
            this.bkm_delete.TabIndex = 0;
            this.bkm_delete.Text = "Удалить";
            this.bkm_delete.UseVisualStyleBackColor = true;
            this.bkm_delete.Click += new System.EventHandler(this.bkm_delete_Click);
            // 
            // bkm_clear
            // 
            this.bkm_clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.bkm_clear.Location = new System.Drawing.Point(75, 0);
            this.bkm_clear.Name = "bkm_clear";
            this.bkm_clear.Size = new System.Drawing.Size(75, 30);
            this.bkm_clear.TabIndex = 1;
            this.bkm_clear.Text = "Очистить";
            this.bkm_clear.UseVisualStyleBackColor = true;
            this.bkm_clear.Click += new System.EventHandler(this.bkm_clear_Click);
            // 
            // bkm_exit
            // 
            this.bkm_exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.bkm_exit.Location = new System.Drawing.Point(150, 0);
            this.bkm_exit.Name = "bkm_exit";
            this.bkm_exit.Size = new System.Drawing.Size(75, 30);
            this.bkm_exit.TabIndex = 2;
            this.bkm_exit.Text = "Закрыть";
            this.bkm_exit.UseVisualStyleBackColor = true;
            this.bkm_exit.Click += new System.EventHandler(this.bkm_exit_Click);
            // 
            // bkm_transition
            // 
            this.bkm_transition.Dock = System.Windows.Forms.DockStyle.Left;
            this.bkm_transition.Location = new System.Drawing.Point(225, 0);
            this.bkm_transition.Name = "bkm_transition";
            this.bkm_transition.Size = new System.Drawing.Size(135, 30);
            this.bkm_transition.TabIndex = 3;
            this.bkm_transition.Text = "Переход по ссылке";
            this.bkm_transition.UseVisualStyleBackColor = true;
            this.bkm_transition.Click += new System.EventHandler(this.bkm_transition_Click);
            // 
            // Bookmarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 321);
            this.Controls.Add(this.bookmarksCollection);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bookmarks";
            this.Text = "Bookmarks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bookmarks_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListBox bookmarksCollection;
        private System.Windows.Forms.Button bkm_exit;
        private System.Windows.Forms.Button bkm_clear;
        private System.Windows.Forms.Button bkm_delete;
        private System.Windows.Forms.Button bkm_transition;
    }
}