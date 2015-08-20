using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_Editor
{
    public partial class AddPassageDialog : Form
    {
        private QuestionEditor m_parent;
        public AddPassageDialog(QuestionEditor parent)
        {
            m_parent = parent;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                m_parent.m_passage = richTextBox1.Rtf;
                m_parent.m_passage_qn = Int32.Parse(textBox1.Text);
            }
            catch (Exception) { }
            this.Close();
        }

        private void AddPassageDialog_Load(object sender, EventArgs e)
        {
            if (m_parent != null)
            {
                richTextBox1.Rtf = m_parent.m_passage;
                int pqn = m_parent.m_passage_qn;
                if (pqn >= 0)
                    textBox1.Text = pqn.ToString();
            }
        }
    }
}
