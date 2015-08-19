namespace Question_Editor
{
    partial class QuestionsEditor
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
            this.rtb_optionb1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiond1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optiona1 = new System.Windows.Forms.RichTextBox();
            this.rtb_question1 = new System.Windows.Forms.RichTextBox();
            this.rtb_optionc1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pnl_holder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_holder
            // 
            this.pnl_holder.AutoScroll = true;
            this.pnl_holder.Controls.Add(this.lbl_qn1);
            this.pnl_holder.Controls.Add(this.rtb_optionb1);
            this.pnl_holder.Controls.Add(this.rtb_optiond1);
            this.pnl_holder.Controls.Add(this.rtb_optiona1);
            this.pnl_holder.Controls.Add(this.rtb_question1);
            this.pnl_holder.Controls.Add(this.rtb_optionc1);
            this.pnl_holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_holder.Location = new System.Drawing.Point(0, 0);
            this.pnl_holder.Name = "pnl_holder";
            this.pnl_holder.Size = new System.Drawing.Size(872, 446);
            this.pnl_holder.TabIndex = 2;
            // 
            // lbl_qn1
            // 
            this.lbl_qn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_qn1.AutoSize = true;
            this.lbl_qn1.Location = new System.Drawing.Point(20, 11);
            this.lbl_qn1.Name = "lbl_qn1";
            this.lbl_qn1.Size = new System.Drawing.Size(16, 13);
            this.lbl_qn1.TabIndex = 1;
            this.lbl_qn1.Text = "1.";
            // 
            // rtb_optionb1
            // 
            this.rtb_optionb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optionb1.Location = new System.Drawing.Point(447, 182);
            this.rtb_optionb1.Name = "rtb_optionb1";
            this.rtb_optionb1.Size = new System.Drawing.Size(385, 69);
            this.rtb_optionb1.TabIndex = 0;
            this.rtb_optionb1.Tag = "ob0";
            this.rtb_optionb1.Text = "";
            // 
            // rtb_optiond1
            // 
            this.rtb_optiond1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optiond1.Location = new System.Drawing.Point(447, 257);
            this.rtb_optiond1.Name = "rtb_optiond1";
            this.rtb_optiond1.Size = new System.Drawing.Size(385, 69);
            this.rtb_optiond1.TabIndex = 0;
            this.rtb_optiond1.Tag = "od0";
            this.rtb_optiond1.Text = "";
            // 
            // rtb_optiona1
            // 
            this.rtb_optiona1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optiona1.Location = new System.Drawing.Point(49, 182);
            this.rtb_optiona1.Name = "rtb_optiona1";
            this.rtb_optiona1.Size = new System.Drawing.Size(392, 69);
            this.rtb_optiona1.TabIndex = 0;
            this.rtb_optiona1.Tag = "oa0";
            this.rtb_optiona1.Text = "";
            // 
            // rtb_question1
            // 
            this.rtb_question1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_question1.Location = new System.Drawing.Point(49, 12);
            this.rtb_question1.Name = "rtb_question1";
            this.rtb_question1.Size = new System.Drawing.Size(783, 164);
            this.rtb_question1.TabIndex = 0;
            this.rtb_question1.Tag = "qn0";
            this.rtb_question1.Text = "";
            // 
            // rtb_optionc1
            // 
            this.rtb_optionc1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtb_optionc1.Location = new System.Drawing.Point(49, 257);
            this.rtb_optionc1.Name = "rtb_optionc1";
            this.rtb_optionc1.Size = new System.Drawing.Size(392, 69);
            this.rtb_optionc1.TabIndex = 0;
            this.rtb_optionc1.Tag = "oc0";
            this.rtb_optionc1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_prev);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 52);
            this.panel1.TabIndex = 2;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(49, 17);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Location = new System.Drawing.Point(732, 17);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // QuestionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.pnl_holder);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionsEditor";
            this.Text = "Questons Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuestionsEditor_Load);
            this.pnl_holder.ResumeLayout(false);
            this.pnl_holder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

