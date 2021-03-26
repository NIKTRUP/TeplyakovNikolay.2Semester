
namespace Web_Browser
{
    partial class Web
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Web));
            this.Header = new System.Windows.Forms.ToolStrip();
            this.bt_back = new System.Windows.Forms.ToolStripButton();
            this.bt_next = new System.Windows.Forms.ToolStripButton();
            this.bt_reboot = new System.Windows.Forms.ToolStripButton();
            this.bt_stop = new System.Windows.Forms.ToolStripButton();
            this.adressBar = new System.Windows.Forms.ToolStripTextBox();
            this.bt_bookmark = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bt_search = new System.Windows.Forms.ToolStripButton();
            this.bt_home = new System.Windows.Forms.ToolStripButton();
            this.bt_addTab = new System.Windows.Forms.ToolStripButton();
            this.bt_removeTab = new System.Windows.Forms.ToolStripButton();
            this.bt_download = new System.Windows.Forms.ToolStripButton();
            this.bt_menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.закладкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_back,
            this.bt_next,
            this.bt_reboot,
            this.bt_stop,
            this.adressBar,
            this.bt_bookmark,
            this.toolStripSeparator1,
            this.bt_search,
            this.bt_home,
            this.bt_addTab,
            this.bt_removeTab,
            this.bt_download,
            this.bt_menu});
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(884, 25);
            this.Header.TabIndex = 0;
            this.Header.Text = "toolStrip1";
            // 
            // bt_back
            // 
            this.bt_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_back.Image = ((System.Drawing.Image)(resources.GetObject("bt_back.Image")));
            this.bt_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(23, 22);
            this.bt_back.Text = "toolStripButton1";
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_next
            // 
            this.bt_next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_next.Image = ((System.Drawing.Image)(resources.GetObject("bt_next.Image")));
            this.bt_next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(23, 22);
            this.bt_next.Text = "toolStripButton2";
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_reboot
            // 
            this.bt_reboot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_reboot.Image = ((System.Drawing.Image)(resources.GetObject("bt_reboot.Image")));
            this.bt_reboot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_reboot.Name = "bt_reboot";
            this.bt_reboot.Size = new System.Drawing.Size(23, 22);
            this.bt_reboot.Text = "toolStripButton3";
            this.bt_reboot.Click += new System.EventHandler(this.bt_reboot_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_stop.Image = ((System.Drawing.Image)(resources.GetObject("bt_stop.Image")));
            this.bt_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(23, 22);
            this.bt_stop.Text = "toolStripButton2";
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // adressBar
            // 
            this.adressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adressBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adressBar.Name = "adressBar";
            this.adressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adressBar.Size = new System.Drawing.Size(600, 25);
            this.adressBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.adressBar_KeyUp);
            this.adressBar.Click += new System.EventHandler(this.adressBar_Click);
            // 
            // bt_bookmark
            // 
            this.bt_bookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_bookmark.Image = ((System.Drawing.Image)(resources.GetObject("bt_bookmark.Image")));
            this.bt_bookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_bookmark.Name = "bt_bookmark";
            this.bt_bookmark.Size = new System.Drawing.Size(23, 22);
            this.bt_bookmark.Text = "toolStripButton4";
            this.bt_bookmark.Click += new System.EventHandler(this.bt_bookmark_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bt_search
            // 
            this.bt_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(23, 22);
            this.bt_search.Text = "toolStripButton5";
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_home
            // 
            this.bt_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_home.Image = ((System.Drawing.Image)(resources.GetObject("bt_home.Image")));
            this.bt_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(23, 22);
            this.bt_home.Text = "toolStripButton2";
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_addTab
            // 
            this.bt_addTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_addTab.Image = ((System.Drawing.Image)(resources.GetObject("bt_addTab.Image")));
            this.bt_addTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_addTab.Name = "bt_addTab";
            this.bt_addTab.Size = new System.Drawing.Size(23, 22);
            this.bt_addTab.Text = "toolStripButton6";
            this.bt_addTab.Click += new System.EventHandler(this.bt_addTab_Click);
            // 
            // bt_removeTab
            // 
            this.bt_removeTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_removeTab.Image = ((System.Drawing.Image)(resources.GetObject("bt_removeTab.Image")));
            this.bt_removeTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_removeTab.Name = "bt_removeTab";
            this.bt_removeTab.Size = new System.Drawing.Size(23, 22);
            this.bt_removeTab.Text = "toolStripButton1";
            this.bt_removeTab.Click += new System.EventHandler(this.bt_removeTab_Click);
            // 
            // bt_download
            // 
            this.bt_download.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_download.Image = ((System.Drawing.Image)(resources.GetObject("bt_download.Image")));
            this.bt_download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(23, 22);
            this.bt_download.Text = "toolStripButton2";
            this.bt_download.Click += new System.EventHandler(this.bt_download_Click);
            // 
            // bt_menu
            // 
            this.bt_menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закладкиToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.bt_menu.Image = ((System.Drawing.Image)(resources.GetObject("bt_menu.Image")));
            this.bt_menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_menu.Name = "bt_menu";
            this.bt_menu.Size = new System.Drawing.Size(29, 20);
            this.bt_menu.Text = "toolStripDropDownButton1";
            // 
            // закладкиToolStripMenuItem
            // 
            this.закладкиToolStripMenuItem.Name = "закладкиToolStripMenuItem";
            this.закладкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закладкиToolStripMenuItem.Text = "Закладки";
            this.закладкиToolStripMenuItem.Click += new System.EventHandler(this.закладкиToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 466);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Web";
            this.Text = "Web";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Web_FormClosing);
            this.Load += new System.EventHandler(this.Web_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Header;
        private System.Windows.Forms.ToolStripButton bt_back;
        private System.Windows.Forms.ToolStripButton bt_next;
        private System.Windows.Forms.ToolStripButton bt_reboot;
        private System.Windows.Forms.ToolStripTextBox adressBar;
        private System.Windows.Forms.ToolStripButton bt_bookmark;
        private System.Windows.Forms.ToolStripButton bt_search;
        private System.Windows.Forms.ToolStripButton bt_addTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton bt_menu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripButton bt_removeTab;
        private System.Windows.Forms.ToolStripButton bt_stop;
        private System.Windows.Forms.ToolStripButton bt_home;
        private System.Windows.Forms.ToolStripMenuItem закладкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bt_download;
    }
}

