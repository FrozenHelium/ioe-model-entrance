namespace Model_Entrance
{
    partial class QuestionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionPage));
            this.pnl_holder = new System.Windows.Forms.Panel();
            this.pnl_title = new System.Windows.Forms.Panel();
            this.img_titleLogo = new System.Windows.Forms.PictureBox();
            this.lbl_titleText = new System.Windows.Forms.Label();
            this.pnl_question = new System.Windows.Forms.Panel();
            this.radio_d = new System.Windows.Forms.RadioButton();
            this.radio_b = new System.Windows.Forms.RadioButton();
            this.radio_c = new System.Windows.Forms.RadioButton();
            this.radio_a = new System.Windows.Forms.RadioButton();
            this.lbl_qn1 = new System.Windows.Forms.Label();
            this.rtb_question1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiona1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionb1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionc1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiond1 = new System.Windows.Forms.RichTextBox();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pnl_holder.SuspendLayout();
            this.pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_titleLogo)).BeginInit();
            this.pnl_question.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_holder
            // 
            this.pnl_holder.AutoScroll = true;
            this.pnl_holder.Controls.Add(this.pnl_title);
            this.pnl_holder.Controls.Add(this.pnl_question);
            this.pnl_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_holder.Location = new System.Drawing.Point(0, 0);
            this.pnl_holder.Name = "pnl_holder";
            this.pnl_holder.Size = new System.Drawing.Size(900, 450);
            this.pnl_holder.TabIndex = 0;
            // 
            // pnl_title
            // 
            this.pnl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_title.BackColor = System.Drawing.Color.White;
            this.pnl_title.Controls.Add(this.img_titleLogo);
            this.pnl_title.Controls.Add(this.lbl_titleText);
            this.pnl_title.Location = new System.Drawing.Point(50, 10);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(800, 120);
            this.pnl_title.TabIndex = 0;
            // 
            // img_titleLogo
            // 
            this.img_titleLogo.Image = global::Model_Entrance.Properties.Resources.modelIoE;
            this.img_titleLogo.InitialImage = global::Model_Entrance.Properties.Resources.modelIoE;
            this.img_titleLogo.Location = new System.Drawing.Point(50, 15);
            this.img_titleLogo.Name = "img_titleLogo";
            this.img_titleLogo.Size = new System.Drawing.Size(64, 64);
            this.img_titleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_titleLogo.TabIndex = 0;
            this.img_titleLogo.TabStop = false;
            // 
            // lbl_titleText
            // 
            this.lbl_titleText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titleText.AutoSize = true;
            this.lbl_titleText.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(190)))), ((int)(((byte)(160)))));
            this.lbl_titleText.Location = new System.Drawing.Point(120, 20);
            this.lbl_titleText.Name = "lbl_titleText";
            this.lbl_titleText.Size = new System.Drawing.Size(328, 47);
            this.lbl_titleText.TabIndex = 0;
            this.lbl_titleText.Text = "IoE Model Entrance";
            this.lbl_titleText.Click += new System.EventHandler(this.lbl_titleText_Click);
            // 
            // pnl_question
            // 
            this.pnl_question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl_question.AutoSize = true;
            this.pnl_question.BackColor = System.Drawing.Color.White;
            this.pnl_question.Controls.Add(this.radio_d);
            this.pnl_question.Controls.Add(this.radio_b);
            this.pnl_question.Controls.Add(this.radio_c);
            this.pnl_question.Controls.Add(this.radio_a);
            this.pnl_question.Controls.Add(this.lbl_qn1);
            this.pnl_question.Controls.Add(this.rtb_question1);
            this.pnl_question.Controls.Add(this.rtb_optiona1);
            this.pnl_question.Controls.Add(this.rtb_optionb1);
            this.pnl_question.Controls.Add(this.rtb_optionc1);
            this.pnl_question.Controls.Add(this.rtb_optiond1);
            this.pnl_question.Location = new System.Drawing.Point(50, 120);
            this.pnl_question.Name = "pnl_question";
            this.pnl_question.Size = new System.Drawing.Size(800, 300);
            this.pnl_question.TabIndex = 2;
            // 
            // radio_d
            // 
            this.radio_d.AutoSize = true;
            this.radio_d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_d.Location = new System.Drawing.Point(430, 260);
            this.radio_d.Name = "radio_d";
            this.radio_d.Size = new System.Drawing.Size(14, 13);
            this.radio_d.TabIndex = 1;
            this.radio_d.TabStop = true;
            this.radio_d.UseVisualStyleBackColor = true;
            // 
            // radio_b
            // 
            this.radio_b.AutoSize = true;
            this.radio_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_b.Location = new System.Drawing.Point(430, 200);
            this.radio_b.Name = "radio_b";
            this.radio_b.Size = new System.Drawing.Size(14, 13);
            this.radio_b.TabIndex = 1;
            this.radio_b.TabStop = true;
            this.radio_b.UseVisualStyleBackColor = true;
            // 
            // radio_c
            // 
            this.radio_c.AutoSize = true;
            this.radio_c.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_c.Location = new System.Drawing.Point(80, 260);
            this.radio_c.Name = "radio_c";
            this.radio_c.Size = new System.Drawing.Size(14, 13);
            this.radio_c.TabIndex = 1;
            this.radio_c.TabStop = true;
            this.radio_c.UseVisualStyleBackColor = true;
            // 
            // radio_a
            // 
            this.radio_a.AutoSize = true;
            this.radio_a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_a.Location = new System.Drawing.Point(80, 200);
            this.radio_a.Name = "radio_a";
            this.radio_a.Size = new System.Drawing.Size(14, 13);
            this.radio_a.TabIndex = 1;
            this.radio_a.TabStop = true;
            this.radio_a.UseVisualStyleBackColor = true;
            // 
            // lbl_qn1
            // 
            this.lbl_qn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_qn1.AutoSize = true;
            this.lbl_qn1.Location = new System.Drawing.Point(15, 5);
            this.lbl_qn1.Name = "lbl_qn1";
            this.lbl_qn1.Size = new System.Drawing.Size(16, 13);
            this.lbl_qn1.TabIndex = 0;
            this.lbl_qn1.Text = "1.";
            // 
            // rtb_question1
            // 
            this.rtb_question1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_question1.BackColor = System.Drawing.Color.White;
            this.rtb_question1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_question1.Location = new System.Drawing.Point(50, 5);
            this.rtb_question1.Name = "rtb_question1";
            this.rtb_question1.ReadOnly = true;
            this.rtb_question1.Size = new System.Drawing.Size(700, 150);
            this.rtb_question1.TabIndex = 0;
            this.rtb_question1.Tag = "qn0";
            this.rtb_question1.Text = "";
            // 
            // rtb_optiona1
            // 
            this.rtb_optiona1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optiona1.BackColor = System.Drawing.Color.White;
            this.rtb_optiona1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optiona1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_optiona1.Location = new System.Drawing.Point(110, 180);
            this.rtb_optiona1.Name = "rtb_optiona1";
            this.rtb_optiona1.ReadOnly = true;
            this.rtb_optiona1.Size = new System.Drawing.Size(280, 50);
            this.rtb_optiona1.TabIndex = 0;
            this.rtb_optiona1.Tag = "oa0";
            this.rtb_optiona1.Text = "";
            // 
            // rtb_optionb1
            // 
            this.rtb_optionb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optionb1.BackColor = System.Drawing.Color.White;
            this.rtb_optionb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optionb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_optionb1.Location = new System.Drawing.Point(470, 180);
            this.rtb_optionb1.Name = "rtb_optionb1";
            this.rtb_optionb1.ReadOnly = true;
            this.rtb_optionb1.Size = new System.Drawing.Size(280, 50);
            this.rtb_optionb1.TabIndex = 0;
            this.rtb_optionb1.Tag = "ob0";
            this.rtb_optionb1.Text = "";
            // 
            // rtb_optionc1
            // 
            this.rtb_optionc1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optionc1.BackColor = System.Drawing.Color.White;
            this.rtb_optionc1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optionc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_optionc1.Location = new System.Drawing.Point(110, 240);
            this.rtb_optionc1.Name = "rtb_optionc1";
            this.rtb_optionc1.ReadOnly = true;
            this.rtb_optionc1.Size = new System.Drawing.Size(280, 50);
            this.rtb_optionc1.TabIndex = 0;
            this.rtb_optionc1.Tag = "oc0";
            this.rtb_optionc1.Text = "";
            // 
            // rtb_optiond1
            // 
            this.rtb_optiond1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optiond1.BackColor = System.Drawing.Color.White;
            this.rtb_optiond1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_optiond1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtb_optiond1.Location = new System.Drawing.Point(470, 240);
            this.rtb_optiond1.Name = "rtb_optiond1";
            this.rtb_optiond1.ReadOnly = true;
            this.rtb_optiond1.Size = new System.Drawing.Size(280, 50);
            this.rtb_optiond1.TabIndex = 0;
            this.rtb_optiond1.Tag = "od0";
            this.rtb_optiond1.Text = "";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.lbl_timer);
            this.pnl_bottom.Controls.Add(this.btn_prev);
            this.pnl_bottom.Controls.Add(this.btn_next);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 450);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(900, 50);
            this.pnl_bottom.TabIndex = 1;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(50, 10);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(222, 30);
            this.lbl_timer.TabIndex = 2;
            this.lbl_timer.Text = "Time Elapsed: 00:00:00";
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
            // QuestionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnl_holder);
            this.Controls.Add(this.pnl_bottom);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "QuestionPage";
            this.Text = "IoE Model Entrance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuestionsEditor_Load);
            this.pnl_holder.ResumeLayout(false);
            this.pnl_holder.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_titleLogo)).EndInit();
            this.pnl_question.ResumeLayout(false);
            this.pnl_question.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_holder;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label lbl_qn1;
        private System.Windows.Forms.RichTextBox rtb_optionb1;
        private System.Windows.Forms.RichTextBox rtb_optiond1;
        private System.Windows.Forms.RichTextBox rtb_optiona1;
        private System.Windows.Forms.RichTextBox rtb_question1;
        private System.Windows.Forms.RichTextBox rtb_optionc1;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel pnl_question;
        private System.Windows.Forms.RadioButton radio_d;
        private System.Windows.Forms.RadioButton radio_b;
        private System.Windows.Forms.RadioButton radio_c;
        private System.Windows.Forms.RadioButton radio_a;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.PictureBox img_titleLogo;
        private System.Windows.Forms.Label lbl_titleText;
    }
}

