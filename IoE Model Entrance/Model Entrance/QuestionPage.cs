using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Entrance
{
    public partial class QuestionPage : Form
    {
        private SplashScreen splash;
        public QuestionPage()
        {
            splash = new SplashScreen();
            splash.Show();
            InitializeComponent();
            splash.Close();
        }


        private void QuestionsEditor_Load(object sender, EventArgs e)
        {
            SuspendDrawing(this);
            QuestionControls controls = new QuestionControls();
            controls.label = lbl_qn1; controls.question = rtb_question1;
            controls.optiona = rtb_optiona1; controls.optionb = rtb_optionb1; 
            controls.optionc = rtb_optionc1; controls.optiond = rtb_optiond1;
            controls.selecta = radio_a; controls.selectb = radio_b;
            controls.selectc = radio_c; controls.selectd = radio_d;
            controls.panel = pnl_question;
            m_questionControls.Add(controls);
            m_questions.Add(new Question());

            pnl_title.Visible = pnl_question.Visible = true;

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

                c.question.GotFocus += new EventHandler(delegate(Object o, EventArgs a)
                {
                    c.label.Focus();
                });

                c.optiona.GotFocus += new EventHandler(delegate(Object o, EventArgs a)
                {
                    c.selecta.Focus();
                    c.selecta.Checked = true;
                });
                c.optionb.GotFocus += new EventHandler(delegate(Object o, EventArgs a)
                {
                    c.selectb.Focus();
                    c.selectb.Checked = true;
                });
                c.optionc.GotFocus += new EventHandler(delegate(Object o, EventArgs a)
                {
                    c.selectc.Focus();
                    c.selectc.Checked = true;
                });
                c.optiond.GotFocus += new EventHandler(delegate(Object o, EventArgs a)
                {
                    c.selectd.Focus();
                    c.selectd.Checked = true;
                });
            }

            RefreshQuestions();
            RefreshControls();

            LoadSets();

            for (int i = 0; i < m_sets.Length; ++i )
            {
                ToolStripItem item = menu_item_change_set.DropDownItems.Add("Set " + (i+1));
                item.Tag = i;
                item.Click += new EventHandler(set_changed);
            }

            m_timer = new System.Timers.Timer(1000);
            m_timer.Elapsed += new System.Timers.ElapsedEventHandler(time_elapsed);
            m_timer.SynchronizingObject = this;

            pnl_holder.Hide();
            pnl_bottom.Hide();
            m_loginscreen = new FormLogIn(this);
            m_loginscreen.TopLevel = false;
            m_loginscreen.Parent = this;
            m_loginscreen.Show();
            ResumeDrawing(this);
        }

        public void SignIn(String username, String password)
        {
            m_loginscreen.Close();
            pnl_holder.Show();
            pnl_bottom.Show();

            if (m_sets.Length > 0)
                set_changed(randomToolStripMenuItem, null);
        }

        private void LoadSets()
        {
            m_sets = Directory.GetFiles(@"sets", "*.qset", SearchOption.AllDirectories);
        }

        private FormLogIn m_loginscreen;
        private String[] m_sets;
        private int m_current_set = -1;

        private int seconds = 0;
        private int target_seconds = 3 * 60 * 60; // 3 hrs
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


        struct QuestionControls
        {
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
        private static String GetTextFromRtf(String str)
        {
            RichTextBox rtf = new RichTextBox();
            rtf.Rtf = str;
            return rtf.Text;
        }
        [Serializable]
        private class Question
        {
            public String question = GetRtf("hello"), optiona = "", optionb = "", optionc = "", optiond = "";
        }

        [Serializable]
        public class Passage
        {
            public int passageQuestion = -1;
            public String passageText = "";
        }

        private List<QuestionControls> m_questionControls = new List<QuestionControls>();
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
                    bformatter.Binder = new ModelQuestionBinder();
                    m_questions = (List<Question>)bformatter.Deserialize(stream);

                }
                using (System.IO.Stream stream = System.IO.File.Open(fileName + "p", System.IO.FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Binder = new ModelQuestionPassageBinder();
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
            m_questions.RemoveAll(q => GetTextFromRtf(q.question) == "");

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
                    qc.panel.Show();
                }
                else
                    qc.panel.Hide();
                i++;
            }
        }

        public void RefreshControls()
        {
            int top = pnl_title.Top + pnl_title.Height;
            foreach (QuestionControls qc in m_questionControls)
            {
                qc.panel.Top = top;
                qc.question.Top = 5;
                qc.optiona.Top = qc.optionb.Top = qc.selecta.Top = qc.selectb.Top
                    = qc.question.Top + qc.question.Height + 10;
                qc.optionc.Top = qc.optiond.Top = qc.selectc.Top = qc.selectd.Top
                    = qc.optiona.Top + Math.Max(qc.optiona.Height, qc.optionb.Height) + 10;

                qc.panel.Height = qc.optionc.Top + Math.Max(qc.optiona.Height, qc.optionb.Height) + 20;
                top += qc.panel.Height;
            }
            if (m_currentPage == m_totalPages - 1)
                btn_next.Text = "Submit";
            else
                btn_next.Text = "Next";
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (m_currentPage == 0)
                return;
            m_currentPage--;
            pnl_title.Select();
            RefreshQuestions();
            RefreshControls();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (m_currentPage >= m_totalPages)
                return;
            if (m_currentPage == m_totalPages - 1)
            {
                Submit();
                return;
            }
            m_currentPage++;
            pnl_title.Select();
            RefreshQuestions();
            RefreshControls();
        }

        private void Submit()
        {
            DialogResult dialogResult = MessageBox.Show("You have ... questions unanswered !", "Are you sure you want to submit ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void content_resized(object _sender, ContentsResizedEventArgs e)
        {
            RichTextBox sender = (RichTextBox)_sender;
            sender.Height = e.NewRectangle.Height + 15;
            RefreshControls();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (!ctx_menu.Visible)
                ctx_menu.Show(btn_menu, 5, 5);
            else
                ctx_menu.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void set_changed(object _sender, EventArgs e)
        {
            if (m_sets == null || m_sets.Length == 0)
                return;
            ToolStripItem sender = (ToolStripItem)_sender;
            String tag = sender.Tag.ToString();
            int new_set;
            if (tag == "random")
            {
                Random random = new Random();
                do
                {
                    new_set = random.Next(0, m_sets.Length);
                } while (new_set == m_current_set);
            }
            else
                new_set = Int32.Parse(tag);
            if (new_set == m_current_set)
                return;
            LoadQuestions(m_sets[new_set]);
            m_current_set = new_set;
            m_timer.Stop();
            seconds = 0;
            m_timer.Start();
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }

    sealed class ModelQuestionBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {

            Type returntype = null;
            if (assemblyName == "Question Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
            {
                assemblyName = Assembly.GetExecutingAssembly().FullName;
                typeName = "Model_Entrance.QuestionPage+Question";
                returntype = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));

                //return returntype;
            }

            if (typeName == "System.Collections.Generic.List`1[[Question_Editor.QuestionEditor+Question, Question Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]")
            {
                typeName = typeName.Replace("Question Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
                    Assembly.GetExecutingAssembly().FullName);
                typeName = typeName.Replace("Question_Editor.QuestionEditor", "Model_Entrance.QuestionPage");
                returntype = Type.GetType(String.Format("{0}, {1}",
                    typeName, assemblyName));
                //return returntype;
            }

            return returntype;
        }
    }

    sealed class ModelQuestionPassageBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {

            Type returntype = null;
            if (assemblyName == "Question Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
            {
                assemblyName = Assembly.GetExecutingAssembly().FullName;
                typeName = "Model_Entrance.QuestionPage+Passage";
                returntype = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));

                //return returntype;
            }

            if (typeName == "Question_Editor.QuestionEditor+Passage")
            {
                
                typeName = typeName.Replace("Question_Editor.QuestionEditor", "Model_Entrance.QuestionPage");
                returntype = Type.GetType(String.Format("{0}, {1}",
                    typeName, assemblyName));
                //return returntype;
            }

            return returntype;
        }
    }
}
