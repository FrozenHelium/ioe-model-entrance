using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_Editor
{
    public partial class QuestionEditor : Form
    {
        public QuestionEditor()
        {
            InitializeComponent();
        }

        private void QuestionsEditor_Load(object sender, EventArgs e)
        {
            QuestionControls controls = new QuestionControls();
            controls.label = lbl_qn1; controls.question = rtb_question1;
            controls.optiona = rtb_optiona1; controls.optionb = rtb_optionb1; 
            controls.optionc = rtb_optionc1; controls.optiond = rtb_optiond1;
            m_questionControls.Add(controls);
            m_questions.Add(new Question());

            int distance = 300;
            int shift = distance;
            for (int i = 1; i < m_questionsPerPage; ++i)
            {
                Label label = lbl_qn1.Clone();
                RichTextBox question = rtb_question1.Clone();
                RichTextBox optiona = rtb_optiona1.Clone();
                RichTextBox optionb = rtb_optionb1.Clone();
                RichTextBox optionc = rtb_optionc1.Clone();
                RichTextBox optiond = rtb_optiond1.Clone();

                label.Top += shift;
                question.Top += shift;
                optiona.Top += shift;
                optionb.Top += shift;
                optionc.Top += shift;
                optiond.Top += shift;

                question.Tag = "qn" + i;
                optiona.Tag = "oa" + i;
                optionb.Tag = "ob" + i;
                optionc.Tag = "oc" + i;
                optiond.Tag = "od" + i;

                shift += distance;

                controls = new QuestionControls();
                controls.label = label; controls.question = question;
                controls.optiona = optiona; controls.optionb = optionb; controls.optionc = optionc; controls.optiond = optiond;
                m_questionControls.Add(controls);
                m_questions.Add(new Question());
            }
            RefreshQuestions();

            foreach (QuestionControls c in m_questionControls)
            {
                c.question.TextChanged += new EventHandler(text_changed);
                c.optiona.TextChanged += new EventHandler(text_changed); 
                c.optionb.TextChanged += new EventHandler(text_changed); 
                c.optionc.TextChanged += new EventHandler(text_changed); 
                c.optiond.TextChanged += new EventHandler(text_changed); 
            }
        }


        private int m_currentPage = 0;
        private int m_totalPages = 1;
        private int m_questionsPerPage = 10;

        struct QuestionControls {
            public Label label;
            public RichTextBox question, optiona, optionb, optionc, optiond;
        }

        [Serializable]
        private class Question {
            public String question="", optiona="", optionb="", optionc="", optiond="";
        }

        private List<QuestionControls> m_questionControls =  new List<QuestionControls>();
        private List<Question> m_questions = new List<Question>();

        public void SaveQuestions(String fileName)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (System.IO.Stream stream = System.IO.File.Open(fileName, System.IO.FileMode.Create))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, m_questions);
                }
            }
            catch(Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("failed to save the file \"" + fileName + "\"\n\r"+e.Message, "Question Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("The question set was successfuly saved to \""+fileName+"\"", "Question Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadQuestions(String fileName)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (System.IO.Stream stream = System.IO.File.Open(fileName, System.IO.FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    m_questions = (List<Question>)bformatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("failed to load the file \"" + fileName + "\"\n\r" + e.Message, "Question Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            m_currentPage = 0;
            m_totalPages = m_questions.Count() / m_questionsPerPage;
            this.RefreshQuestions();
            Cursor.Current = Cursors.Default;
        }

        public void RefreshQuestions()
        {
            int i = m_currentPage * m_questionsPerPage;
            foreach (QuestionControls qc in m_questionControls) 
            {
                Question q =  m_questions[i];
                qc.label.Text = (i+1) + ".";
                qc.question.Rtf = q.question;
                qc.optiona.Rtf = q.optiona;
                qc.optionb.Rtf = q.optionb;
                qc.optionc.Rtf = q.optionc;
                qc.optiond.Rtf = q.optiond;
                i++;
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (m_currentPage == 0)
                return;
            m_currentPage--;
            RefreshQuestions();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            m_currentPage++;
            if (m_currentPage >= m_totalPages)
            {
                m_totalPages++;
                for (int i = 0; i < m_questionsPerPage; ++i)
                    m_questions.Add(new Question());
            }
            RefreshQuestions();
        }

        public void text_changed(object _sender, EventArgs args)
        {
            RichTextBox sender = (RichTextBox)_sender;
            String tag = sender.Tag.ToString();
            String type = tag.Substring(0, 2);
            int index = Int32.Parse(tag.Substring(2));

            int i = m_currentPage * m_questionsPerPage;
            if (type == "qn")
                m_questions[i + index].question = sender.Rtf;
            else if (type == "oa")
                m_questions[i + index].optiona = sender.Rtf;
            else if (type == "ob")
                m_questions[i + index].optionb = sender.Rtf;
            else if (type == "oc")
                m_questions[i + index].optionc = sender.Rtf;
            else if (type == "od")
                m_questions[i + index].optiond = sender.Rtf;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                this.LoadQuestions(fileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                this.SaveQuestions(fileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutQuestionEditor about = new AboutQuestionEditor();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
