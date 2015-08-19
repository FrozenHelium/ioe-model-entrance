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
            this.pnl_holder = new System.Windows.Forms.Panel();
            this.lbl_qn1 = new System.Windows.Forms.Label();
            this.rtb_question1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiona1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionb1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionc1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiond1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_holder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_holder
            // 
            this.pnl_holder.AutoScroll = true;
            this.pnl_holder.Controls.Add(this.lbl_qn1);
            this.pnl_holder.Controls.Add(this.rtb_question1);
            this.pnl_holder.Controls.Add(this.rtb_optiona1);
            this.pnl_holder.Controls.Add(this.rtb_optionb1);
            this.pnl_holder.Controls.Add(this.rtb_optionc1);
            this.pnl_holder.Controls.Add(this.rtb_optiond1);
            this.pnl_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_holder.Location = new System.Drawing.Point(0, 24);
            this.pnl_holder.Name = "pnl_holder";
            this.pnl_holder.Size = new System.Drawing.Size(900, 426);
            this.pnl_holder.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_prev);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 1;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(50, 10);
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
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "qset";
            this.openFileDialog1.Filter = "Question set file|*.qset";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "qset";
            this.saveFileDialog1.Filter = "Question set file|*.qset";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // QuestionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnl_holder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "QuestionEditor";
            this.Text = "IoE Model Entrance - Question Editor";
            this.Load += new System.EventHandler(this.QuestionsEditor_Load);
            this.pnl_holder.ResumeLayout(false);
            this.pnl_holder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

