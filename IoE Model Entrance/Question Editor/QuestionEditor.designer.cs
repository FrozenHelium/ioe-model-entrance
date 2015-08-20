namespace Question_Editor
{
    partial class QuestionEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionEditor));
            this.pnl_holder = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.lbl_qn1 = new System.Windows.Forms.Label();
            this.rtb_question1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiona1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionb1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionc1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiond1 = new System.Windows.Forms.RichTextBox();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_insertPassage = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tbtn_bold = new System.Windows.Forms.ToolStripButton();
            this.tbtn_italic = new System.Windows.Forms.ToolStripButton();
            this.tbtn_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtn_super = new System.Windows.Forms.ToolStripButton();
            this.tbtn_sub = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtn_incr = new System.Windows.Forms.ToolStripButton();
            this.tbtn_decr = new System.Windows.Forms.ToolStripButton();
            this.pnl_holder.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_holder
            // 
            this.pnl_holder.AutoScroll = true;
            this.pnl_holder.Controls.Add(this.btn_remove);
            this.pnl_holder.Controls.Add(this.btn_insert);
            this.pnl_holder.Controls.Add(this.btn_paste);
            this.pnl_holder.Controls.Add(this.lbl_qn1);
            this.pnl_holder.Controls.Add(this.rtb_question1);
            this.pnl_holder.Controls.Add(this.rtb_optiona1);
            this.pnl_holder.Controls.Add(this.rtb_optionb1);
            this.pnl_holder.Controls.Add(this.rtb_optionc1);
            this.pnl_holder.Controls.Add(this.rtb_optiond1);
            this.pnl_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_holder.Location = new System.Drawing.Point(0, 49);
            this.pnl_holder.Name = "pnl_holder";
            this.pnl_holder.Size = new System.Drawing.Size(900, 401);
            this.pnl_holder.TabIndex = 0;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_remove.Image = global::Question_Editor.Properties.Resources.file_delete;
            this.btn_remove.Location = new System.Drawing.Point(810, 145);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(48, 48);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Tag = "0";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_insert.Image = global::Question_Editor.Properties.Resources.file_add;
            this.btn_insert.Location = new System.Drawing.Point(810, 80);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(48, 48);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Tag = "0";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // btn_paste
            // 
            this.btn_paste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_paste.Image = global::Question_Editor.Properties.Resources.paste;
            this.btn_paste.Location = new System.Drawing.Point(810, 15);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(48, 48);
            this.btn_paste.TabIndex = 1;
            this.btn_paste.Tag = "0";
            this.btn_paste.UseVisualStyleBackColor = true;
            // 
            // lbl_qn1
            // 
            this.lbl_qn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_qn1.AutoSize = true;
            this.lbl_qn1.Location = new System.Drawing.Point(50, 15);
            this.lbl_qn1.Name = "lbl_qn1";
            this.lbl_qn1.Size = new System.Drawing.Size(16, 13);
            this.lbl_qn1.TabIndex = 0;
            this.lbl_qn1.Text = "1.";
            // 
            // rtb_question1
            // 
            this.rtb_question1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_question1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_question1.Location = new System.Drawing.Point(100, 15);
            this.rtb_question1.Name = "rtb_question1";
            this.rtb_question1.Size = new System.Drawing.Size(700, 150);
            this.rtb_question1.TabIndex = 0;
            this.rtb_question1.Tag = "qn0";
            this.rtb_question1.Text = "";
            // 
            // rtb_optiona1
            // 
            this.rtb_optiona1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optiona1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optiona1.Location = new System.Drawing.Point(100, 180);
            this.rtb_optiona1.Name = "rtb_optiona1";
            this.rtb_optiona1.Size = new System.Drawing.Size(340, 50);
            this.rtb_optiona1.TabIndex = 0;
            this.rtb_optiona1.Tag = "oa0";
            this.rtb_optiona1.Text = "";
            // 
            // rtb_optionb1
            // 
            this.rtb_optionb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optionb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optionb1.Location = new System.Drawing.Point(460, 180);
            this.rtb_optionb1.Name = "rtb_optionb1";
            this.rtb_optionb1.Size = new System.Drawing.Size(340, 50);
            this.rtb_optionb1.TabIndex = 0;
            this.rtb_optionb1.Tag = "ob0";
            this.rtb_optionb1.Text = "";
            // 
            // rtb_optionc1
            // 
            this.rtb_optionc1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optionc1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optionc1.Location = new System.Drawing.Point(100, 240);
            this.rtb_optionc1.Name = "rtb_optionc1";
            this.rtb_optionc1.Size = new System.Drawing.Size(340, 50);
            this.rtb_optionc1.TabIndex = 0;
            this.rtb_optionc1.Tag = "oc0";
            this.rtb_optionc1.Text = "";
            // 
            // rtb_optiond1
            // 
            this.rtb_optiond1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optiond1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optiond1.Location = new System.Drawing.Point(460, 240);
            this.rtb_optiond1.Name = "rtb_optiond1";
            this.rtb_optiond1.Size = new System.Drawing.Size(340, 50);
            this.rtb_optiond1.TabIndex = 0;
            this.rtb_optiond1.Tag = "od0";
            this.rtb_optiond1.Text = "";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.LightGray;
            this.pnl_bottom.Controls.Add(this.btn_insertPassage);
            this.pnl_bottom.Controls.Add(this.btn_prev);
            this.pnl_bottom.Controls.Add(this.btn_next);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 450);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(900, 50);
            this.pnl_bottom.TabIndex = 1;
            // 
            // btn_insertPassage
            // 
            this.btn_insertPassage.Location = new System.Drawing.Point(37, 10);
            this.btn_insertPassage.Name = "btn_insertPassage";
            this.btn_insertPassage.Size = new System.Drawing.Size(126, 29);
            this.btn_insertPassage.TabIndex = 2;
            this.btn_insertPassage.Text = "Insert passage ...";
            this.btn_insertPassage.UseVisualStyleBackColor = true;
            this.btn_insertPassage.Click += new System.EventHandler(this.btn_insertPassage_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prev.Location = new System.Drawing.Point(620, 10);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(100, 30);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "← Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Location = new System.Drawing.Point(750, 10);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(100, 30);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next →";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "qset";
            this.openFileDialog.Filter = "Question set file|*.qset";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "qset";
            this.saveFileDialog.Filter = "Question set file|*.qset";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(900, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtn_bold,
            this.tbtn_italic,
            this.tbtn_underline,
            this.toolStripSeparator1,
            this.tbtn_super,
            this.tbtn_sub,
            this.toolStripSeparator2,
            this.tbtn_incr,
            this.tbtn_decr});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(900, 25);
            this.toolBar.TabIndex = 4;
            this.toolBar.Text = "toolStrip1";
            // 
            // tbtn_bold
            // 
            this.tbtn_bold.CheckOnClick = true;
            this.tbtn_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_bold.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_bold.Image")));
            this.tbtn_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_bold.Name = "tbtn_bold";
            this.tbtn_bold.Size = new System.Drawing.Size(23, 22);
            this.tbtn_bold.Text = "Bold";
            this.tbtn_bold.Click += new System.EventHandler(this.tbtn_bold_Click);
            // 
            // tbtn_italic
            // 
            this.tbtn_italic.CheckOnClick = true;
            this.tbtn_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_italic.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_italic.Image")));
            this.tbtn_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_italic.Name = "tbtn_italic";
            this.tbtn_italic.Size = new System.Drawing.Size(23, 22);
            this.tbtn_italic.Text = "Italic";
            this.tbtn_italic.Click += new System.EventHandler(this.tbtn_italic_Click);
            // 
            // tbtn_underline
            // 
            this.tbtn_underline.CheckOnClick = true;
            this.tbtn_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_underline.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_underline.Image")));
            this.tbtn_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_underline.Name = "tbtn_underline";
            this.tbtn_underline.Size = new System.Drawing.Size(23, 22);
            this.tbtn_underline.Text = "Underline";
            this.tbtn_underline.Click += new System.EventHandler(this.tbtn_underline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtn_super
            // 
            this.tbtn_super.CheckOnClick = true;
            this.tbtn_super.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_super.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_super.Image")));
            this.tbtn_super.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_super.Name = "tbtn_super";
            this.tbtn_super.Size = new System.Drawing.Size(23, 22);
            this.tbtn_super.Text = "Superscript";
            this.tbtn_super.Click += new System.EventHandler(this.tbtn_super_Click);
            // 
            // tbtn_sub
            // 
            this.tbtn_sub.CheckOnClick = true;
            this.tbtn_sub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_sub.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_sub.Image")));
            this.tbtn_sub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_sub.Name = "tbtn_sub";
            this.tbtn_sub.Size = new System.Drawing.Size(23, 22);
            this.tbtn_sub.Text = "Subscript";
            this.tbtn_sub.Click += new System.EventHandler(this.tbtn_sub_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtn_incr
            // 
            this.tbtn_incr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_incr.Image = global::Question_Editor.Properties.Resources.increase_font_size;
            this.tbtn_incr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_incr.Name = "tbtn_incr";
            this.tbtn_incr.Size = new System.Drawing.Size(23, 22);
            this.tbtn_incr.Text = "Increase font size";
            this.tbtn_incr.Click += new System.EventHandler(this.tbtn_incr_Click);
            // 
            // tbtn_decr
            // 
            this.tbtn_decr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtn_decr.Image = global::Question_Editor.Properties.Resources.decrease_font_size;
            this.tbtn_decr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_decr.Name = "tbtn_decr";
            this.tbtn_decr.Size = new System.Drawing.Size(23, 22);
            this.tbtn_decr.Text = "Decrease font size";
            this.tbtn_decr.Click += new System.EventHandler(this.tbtn_decr_Click);
            // 
            // QuestionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnl_holder);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "QuestionEditor";
            this.Text = "IoE Model Entrance - Question Editor";
            this.Load += new System.EventHandler(this.QuestionsEditor_Load);
            this.pnl_holder.ResumeLayout(false);
            this.pnl_holder.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_holder;
        private System.Windows.Forms.Label lbl_qn1;
        private System.Windows.Forms.RichTextBox rtb_optionb1;
        private System.Windows.Forms.RichTextBox rtb_optiond1;
        private System.Windows.Forms.RichTextBox rtb_optiona1;
        private System.Windows.Forms.RichTextBox rtb_question1;
        private System.Windows.Forms.RichTextBox rtb_optionc1;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton tbtn_bold;
        private System.Windows.Forms.ToolStripButton tbtn_italic;
        private System.Windows.Forms.ToolStripButton tbtn_underline;
        private System.Windows.Forms.ToolStripButton tbtn_super;
        private System.Windows.Forms.ToolStripButton tbtn_sub;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtn_incr;
        private System.Windows.Forms.ToolStripButton tbtn_decr;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_insertPassage;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_remove;
    }
}

