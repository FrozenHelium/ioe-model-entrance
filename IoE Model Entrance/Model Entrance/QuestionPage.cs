using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Entrance
{
    public partial class QuestionPage : Form
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        private void QuestionsEditor_Load(object sender, EventArgs e)
        {
            QuestionControls controls = new QuestionControls();
            controls.label = lbl_qn1; controls.question = rtb_question1;
            controls.optiona = rtb_optiona1; controls.optionb = rtb_optionb1; 
            controls.optionc = rtb_optionc1; controls.optiond = rtb_optiond1;
            controls.selecta = radio_a; controls.selectb = radio_b;
            controls.selectc = radio_c; controls.selectd = radio_d;
            controls.panel = pnl_question;
            m_questionControls.Add(controls);
            m_questions.Add(new Question());

            for (int i = 1; i < m_questionsPerPage; ++i)
            {
                controls = new QuestionControls();
                controls.label = lbl_qn1.Clone();
                controls.question = rtb_question1.Clone();
                controls.optiona = rtb_optiona1.Clone();
                controls.optionb = rtb_optionb1.Clone();
                controls.optionc = rtb_optionc1.Clone();
                controls.optiond = rtb_optiond1.Clone();
                controls.selecta = radio_a.Clone();
                controls.selectb = radio_b.Clone();
                controls.selectc = radio_c.Clone();
                controls.selectd = radio_d.Clone();
                controls.panel = pnl_question.Clone();

                controls.ChangeParent();

                controls.question.Tag = "qn" + i;
                controls.optiona.Tag = "oa" + i;
                controls.optionb.Tag = "ob" + i;
                controls.optionc.Tag = "oc" + i;
                controls.optiond.Tag = "od" + i;

                m_questionControls.Add(controls);
                m_questions.Add(new Question());
            }

            foreach (QuestionControls c in m_questionControls)
            {

                c.question.ContentsResized += new ContentsResizedEventHandler(content_resized);
                c.optiona.ContentsResized += new ContentsResizedEventHandler(content_resized);
                c.optionb.ContentsResized += new ContentsResizedEventHandler(content_resized);
                c.optionc.ContentsResized += new ContentsResizedEventHandler(content_resized);
                c.optiond.ContentsResized += new ContentsResizedEventHandler(content_resized);

                c.question.Text = c.optiona.Text = c.optionb.Text = c.optionc.Text = c.optiond.Text = "\n";
                c.question.Text = c.optiona.Text = c.optionb.Text = c.optionc.Text = c.optiond.Text = "";
            }

            RefreshQuestions();
            RefreshControls();

            m_timer = new System.Timers.Timer(1000);
            m_timer.Elapsed += new System.Timers.ElapsedEventHandler(time_elapsed);
            m_timer.SynchronizingObject = this;
            m_timer.Start();
        }

        private int seconds = 0;
        private int target_seconds = 3*60*60; // 3 hrs
        public void time_elapsed(object sender, System.Timers.ElapsedEventArgs args)
        {
            seconds++;
            lbl_timer.Text = "Time Elapsed: " + TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");

            if (seconds == target_seconds)
            {
                m_timer.Stop();
                MessageBox.Show("Time Up!!!");
            }
        }

        private int m_currentPage = 0;
        private int m_totalPages = 1;
        private int m_questionsPerPage = 10;
        private System.Timers.Timer m_timer;


        struct QuestionControls {
            public Label label;
            public RichTextBox question, optiona, optionb, optionc, optiond;
            public RadioButton selecta, selectb, selectc, selectd;
            public Panel panel;

            public void ChangeParent()
            {
                label.Parent = question.Parent = optiona.Parent = optionb.Parent =
                    optionc.Parent = optiond.Parent =
                    selecta.Parent = selectb.Parent = selectc.Parent = selectd.Parent =
                    panel;
            }
        }

        private static String GetRtf(String str)
        {
            RichTextBox rtf = new RichTextBox();
            rtf.Text = str;
            return rtf.Rtf;
        }
        [Serializable]
        private class Question {
            public String question=GetRtf("hello"), optiona="", optionb="", optionc="", optiond="";
        }

        [Serializable]
        public class Passage
        {
            public int passageQuestion = -1;
            public String passageText="";
        }

        private List<QuestionControls> m_questionControls =  new List<QuestionControls>();
        private List<Question> m_questions = new List<Question>();
        public Passage m_passage = new Passage();

        public RichTextBox m_lastTextBox;

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
                using (System.IO.Stream stream = System.IO.File.Open(fileName+"p", System.IO.FileMode.Open))
                {
                    Passage p = new Passage();
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    m_passage = (Passage)bformatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("failed to load the file \"" + fileName + "\"\n\r" + e.Message, "Question Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            m_currentPage = 0;
            m_totalPages = m_questions.Count / m_questionsPerPage;
            this.RefreshQuestions();
            Cursor.Current = Cursors.Default;
        }

        public void RefreshQuestions()
        {
            // Remove all questions that are empty
            m_questions.RemoveAll(q => q.question == "");

            int i = m_currentPage * m_questionsPerPage;
            foreach (QuestionControls qc in m_questionControls) 
            {
                if (i < m_questions.Count)
                {
                    Question q = m_questions[i];
                    qc.label.Text = (i + 1) + ".";
                    qc.question.Rtf = q.question;
                    qc.optiona.Rtf = q.optiona;
                    qc.optionb.Rtf = q.optionb;
                    qc.optionc.Rtf = q.optionc;
                    qc.optiond.Rtf = q.optiond;
                }
                else
                    qc.panel.Hide();
                i++;
            }
        }

        public void RefreshControls()
        {
            int top = 5;
            foreach (QuestionControls qc in m_questionControls)
            {
                qc.panel.Top = top;
                qc.question.Top = 5;
                qc.optiona.Top = qc.optionb.Top = qc.selecta.Top = qc.selectb.Top
                    = qc.question.Top + qc.question.Height + 10;
                qc.optionc.Top = qc.optiond.Top = qc.selectc.Top = qc.selectd.Top
                    = qc.optiona.Top + Math.Max(qc.optiona.Height, qc.optionb.Height) + 10;

                qc.panel.Height = qc.optionc.Top + Math.Max(qc.optiona.Height, qc.optionb.Height) + 20;
                top += qc.panel.Height + 10;
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
            if (m_currentPage >= m_totalPages - 1)
                return;
            m_currentPage++;
            RefreshQuestions();
        }


        private void content_resized(object _sender, ContentsResizedEventArgs e)
        {
            RichTextBox sender = (RichTextBox)_sender;
            sender.Height = e.NewRectangle.Height + 5;
            RefreshControls();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
