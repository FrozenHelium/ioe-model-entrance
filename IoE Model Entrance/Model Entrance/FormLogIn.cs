using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Entrance
{
    public partial class FormLogIn : Form
    {
        public FormLogIn(QuestionPage parent)
        {
            InitializeComponent();
            m_parent = parent;
        }

        private QuestionPage m_parent;

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            //StartOSK();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_parent.SignIn(textBox1.Text, textBox2.Text);
        }
    }
}
