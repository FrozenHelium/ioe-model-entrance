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
    public partial class QuestionsEditor : Form
    {
        public QuestionsEditor()
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

        private class Question {
            public String question="", optiona="", optionb="", optionc="", optiond="";
        }

        private List<QuestionControls> m_questionControls =  new List<QuestionControls>();
        private List<Question> m_questions = new List<Question>();

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
    }
}
