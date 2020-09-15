namespace WindowsForms_Reader
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_File = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GoOverBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloceQuotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunBack = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.bookmarkToolStripMenuItem,
            this.quotesToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(756, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_File,
            this.closeFileToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "&File";
            // 
            // Open_File
            // 
            this.Open_File.Name = "Open_File";
            this.Open_File.Size = new System.Drawing.Size(124, 22);
            this.Open_File.Text = "&Open File";
            this.Open_File.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.closeFileToolStripMenuItem.Text = "&Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBookmarkToolStripMenuItem,
            this.GoOverBookmarkToolStripMenuItem});
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bookmarkToolStripMenuItem.Text = "&Bookmark";
            // 
            // createBookmarkToolStripMenuItem
            // 
            this.createBookmarkToolStripMenuItem.Name = "createBookmarkToolStripMenuItem";
            this.createBookmarkToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createBookmarkToolStripMenuItem.Text = "&Create Bookmark";
            this.createBookmarkToolStripMenuItem.Click += new System.EventHandler(this.createBookmarkToolStripMenuItem_Click);
            // 
            // GoOverBookmarkToolStripMenuItem
            // 
            this.GoOverBookmarkToolStripMenuItem.Name = "GoOverBookmarkToolStripMenuItem";
            this.GoOverBookmarkToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.GoOverBookmarkToolStripMenuItem.Text = "&Go over Bookmark";
            this.GoOverBookmarkToolStripMenuItem.Click += new System.EventHandler(this.GoOverBookmarkToolStripMenuItem_Click);
            // 
            // quotesToolStripMenuItem
            // 
            this.quotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuotesToolStripMenuItem,
            this.watchQuotesToolStripMenuItem,
            this.cloceQuotesToolStripMenuItem});
            this.quotesToolStripMenuItem.Name = "quotesToolStripMenuItem";
            this.quotesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.quotesToolStripMenuItem.Text = "&Quotes";
            // 
            // createQuotesToolStripMenuItem
            // 
            this.createQuotesToolStripMenuItem.Name = "createQuotesToolStripMenuItem";
            this.createQuotesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.createQuotesToolStripMenuItem.Text = "&Create quotes";
            this.createQuotesToolStripMenuItem.Click += new System.EventHandler(this.createQuotesToolStripMenuItem_Click);
            // 
            // watchQuotesToolStripMenuItem
            // 
            this.watchQuotesToolStripMenuItem.Name = "watchQuotesToolStripMenuItem";
            this.watchQuotesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.watchQuotesToolStripMenuItem.Text = "&Watch quotes";
            this.watchQuotesToolStripMenuItem.Click += new System.EventHandler(this.watchQuotesToolStripMenuItem_Click);
            // 
            // cloceQuotesToolStripMenuItem
            // 
            this.cloceQuotesToolStripMenuItem.Name = "cloceQuotesToolStripMenuItem";
            this.cloceQuotesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cloceQuotesToolStripMenuItem.Text = "&Close quotes";
            this.cloceQuotesToolStripMenuItem.Click += new System.EventHandler(this.cloceQuotesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchTextToolStripMenuItem,
            this.searchPageToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // searchTextToolStripMenuItem
            // 
            this.searchTextToolStripMenuItem.Name = "searchTextToolStripMenuItem";
            this.searchTextToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.searchTextToolStripMenuItem.Text = "&Search Text";
            this.searchTextToolStripMenuItem.Click += new System.EventHandler(this.searchTextToolStripMenuItem_Click);
            // 
            // searchPageToolStripMenuItem
            // 
            this.searchPageToolStripMenuItem.Name = "searchPageToolStripMenuItem";
            this.searchPageToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.searchPageToolStripMenuItem.Text = "&Search Page";
            this.searchPageToolStripMenuItem.Click += new System.EventHandler(this.searchPageToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "&Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.textColorToolStripMenuItem.Text = "&Text color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(100, 27);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(525, 501);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunBack
            // 
            this.bunBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunBack.Location = new System.Drawing.Point(557, 0);
            this.bunBack.Name = "bunBack";
            this.bunBack.Size = new System.Drawing.Size(26, 23);
            this.bunBack.TabIndex = 2;
            this.bunBack.Text = "<";
            this.bunBack.UseVisualStyleBackColor = true;
            this.bunBack.Click += new System.EventHandler(this.bunBack_Click);
            // 
            // bunNext
            // 
            this.bunNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunNext.Location = new System.Drawing.Point(679, 0);
            this.bunNext.Name = "bunNext";
            this.bunNext.Size = new System.Drawing.Size(29, 23);
            this.bunNext.TabIndex = 2;
            this.bunNext.Text = ">";
            this.bunNext.UseVisualStyleBackColor = true;
            this.bunNext.Click += new System.EventHandler(this.bunNext_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Page:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(756, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunNext);
            this.Controls.Add(this.bunBack);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Reader";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Open_File;
        private System.Windows.Forms.Button bunBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bunNext;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GoOverBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQuotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchQuotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloceQuotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
    }
}

