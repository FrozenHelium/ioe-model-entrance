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
            controls.paste = btn_paste; controls.insert = btn_insert; controls.remove = btn_remove;
            m_questionControls.Add(controls);
            m_questions.Add(new Question());

            int distance = 300;
            int shift = distance;
            for (int i = 1; i < m_questionsPerPage; ++i)
            {
                controls = new QuestionControls();
                controls.label = lbl_qn1.Clone();
                controls.question = rtb_question1.Clone();
                controls.optiona = rtb_optiona1.Clone();
                controls.optionb = rtb_optionb1.Clone();
                controls.optionc = rtb_optionc1.Clone();
                controls.optiond = rtb_optiond1.Clone();
                controls.paste = btn_paste.Clone();
                controls.insert = btn_insert.Clone();
                controls.remove = btn_remove.Clone();

                controls.label.Top += shift;
                controls.question.Top += shift;
                controls.optiona.Top += shift;
                controls.optionb.Top += shift;
                controls.optionc.Top += shift;
                controls.optiond.Top += shift;
                controls.paste.Top += shift;
                controls.insert.Top += shift;
                controls.remove.Top += shift;

                controls.question.Tag = "qn" + i;
                controls.optiona.Tag = "oa" + i;
                controls.optionb.Tag = "ob" + i;
                controls.optionc.Tag = "oc" + i;
                controls.optiond.Tag = "od" + i;
                controls.paste.Tag = i + "";
                controls.insert.Tag = i + "";
                controls.remove.Tag = i + "";

                shift += distance;

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

                c.question.SelectionChanged += new EventHandler(selection_changed);
                c.optiona.SelectionChanged += new EventHandler(selection_changed);
                c.optionb.SelectionChanged += new EventHandler(selection_changed);
                c.optionc.SelectionChanged += new EventHandler(selection_changed);
                c.optiond.SelectionChanged += new EventHandler(selection_changed);

                c.paste.Click += new EventHandler(paste_clicked);
                c.insert.Click += new EventHandler(insert_question);
                c.remove.Click += new EventHandler(delete_question);
            }
        }


        private int m_currentPage = 0;
        private int m_totalPages = 1;
        private int m_questionsPerPage = 10;

        public String m_passage = "";
        public int m_passage_qn = -1;

        struct QuestionControls {
            public Label label;
            public RichTextBox question, optiona, optionb, optionc, optiond;
            public Button paste, insert, remove;
        }

        [Serializable]
        private class Question {
            public String question="", optiona="", optionb="", optionc="", optiond="";
        }

        [Serializable]
        private class Passage
        {
            public int passageQuestion = -1;
            public String passageText="";
        }

        private List<QuestionControls> m_questionControls =  new List<QuestionControls>();
        private List<Question> m_questions = new List<Question>();

        public RichTextBox m_lastTextBox;

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
                using (System.IO.Stream stream = System.IO.File.Open(fileName + "p", System.IO.FileMode.Create))
                {
                    Passage p = new Passage();
                    p.passageQuestion = m_passage_qn;
                    p.passageText = m_passage;
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, p);
                }
                
            }
            catch(Exception e)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("failed to save the file \"" + fileName + "\"\n\r"+e.Message, "Question Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("The question set was successfuly saved to \""+fileName+"\"", "Question Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                using (System.IO.Stream stream = System.IO.File.Open(fileName+"p", System.IO.FileMode.Open))
                {
                    Passage p = new Passage();
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    p = (Passage)bformatter.Deserialize(stream);
                    m_passage_qn = p.passageQuestion;
                    m_passage = p.passageText;
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
            if (m_questions.Count % m_questionsPerPage != 0)
            {
                for (int j = m_questions.Count % m_questionsPerPage; j < m_questionsPerPage; ++j)
                    m_questions.Add(new Question());
            }
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

        public void selection_changed(object _sender, EventArgs args)
        {
            RichTextBox sender = (RichTextBox)_sender;
            //String tag = sender.Tag.ToString();
            //int index = Int32.Parse(tag.Substring(2));
            //QuestionControls controls = m_questionControls[index];

            m_lastTextBox = sender;
            if (sender == null || sender.SelectionFont == null || m_formatting)
                return;
            tbtn_bold.Checked = sender.SelectionFont.Bold;
            tbtn_italic.Checked = sender.SelectionFont.Italic;
            tbtn_underline.Checked = sender.SelectionFont.Underline;
            tbtn_super.Checked = (sender.SelectionCharOffset > 0);
            tbtn_sub.Checked = (sender.SelectionCharOffset < 0);
        }

        public void insert_question(object _sender, EventArgs args)
        {
            Button sender = (Button)_sender;
            int index = Int32.Parse(sender.Tag.ToString());
            int i = m_currentPage * m_questionsPerPage;

            m_questions.Insert(i+index, new Question());
            RefreshQuestions();
        }

        public void delete_question(object _sender, EventArgs args)
        {
            Button sender = (Button)_sender;
            int index = Int32.Parse(sender.Tag.ToString());
            int i = m_currentPage * m_questionsPerPage;

            m_questions.RemoveAt(i + index);
            RefreshQuestions();
        }

        public void paste_clicked(object _sender, EventArgs args)
        {
            Button sender = (Button)_sender;
            int index = Int32.Parse(sender.Tag.ToString());
            QuestionControls controls = m_questionControls[index];

            controls.question.Paste();

            Match match = new Regex(@"\A\s*\d+\.\s?").Match(controls.question.Text);
            int startid = 0;
            if (match.Success)
                startid = match.Index + match.Length;

            match = new Regex(@"\s*a\)\s?").Match(controls.question.Text, startid);
            if (!match.Success)
                return;
            int id = match.Index + match.Length;
            controls.question.Select(startid, id - startid - match.Length);
            string question = controls.question.SelectedRtf;

            match = new Regex(@"b\)\s?").Match(controls.question.Text, id);
            if (!match.Success)
                return;
            int nid = match.Index + match.Length;
            controls.question.Select(id, nid - id - match.Length);
            controls.optiona.Rtf = controls.question.SelectedRtf;

            id = nid;
            match = new Regex(@"c\)\s?").Match(controls.question.Text, id);
            if (!match.Success)
                return;
            nid = match.Index + match.Length;
            controls.question.Select(id, nid - id - match.Length);
            controls.optionb.Rtf = controls.question.SelectedRtf;

            id = nid;
            match = new Regex(@"d\)\s?").Match(controls.question.Text, id);
            if (!match.Success)
                return;
            nid = match.Index + match.Length;
            controls.question.Select(id, nid - id - match.Length);
            controls.optionc.Rtf = controls.question.SelectedRtf;

            id = nid;
            match = new Regex(@"(?m)^\s*\d+\.\s?").Match(controls.question.Text, id);
            String remaining = "";
            if (match.Success)
            {
                nid = match.Index;
                controls.question.Select(nid, controls.question.Text.Length);
                remaining = controls.question.SelectedRtf;
            }
            else
                nid = controls.question.Text.Length;
            controls.question.Select(id, nid - id);
            controls.optiond.Rtf = controls.question.SelectedRtf;

            controls.question.Rtf = question;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                this.LoadQuestions(fileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
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

        private bool m_formatting = false;

        private void ChangeFormatting(FontStyle style, bool check)
        {
            if (m_lastTextBox == null)
                return;
            m_formatting = true;
            if (check)
                m_lastTextBox.SelectionFont = new Font(m_lastTextBox.SelectionFont, m_lastTextBox.SelectionFont.Style | style);
            else
                m_lastTextBox.SelectionFont = new Font(m_lastTextBox.SelectionFont, m_lastTextBox.SelectionFont.Style & ~style);
            m_formatting = false;
        }

        private void tbtn_bold_Click(object sender, EventArgs e)
        {
            ChangeFormatting(FontStyle.Bold, tbtn_bold.Checked);
        }

        private void tbtn_italic_Click(object sender, EventArgs e)
        {
            ChangeFormatting(FontStyle.Italic, tbtn_italic.Checked);
        }

        private void tbtn_underline_Click(object sender, EventArgs e)
        {
            ChangeFormatting(FontStyle.Underline, tbtn_underline.Checked);
        }

        private void tbtn_super_Click(object sender, EventArgs e)
        {
            if (m_lastTextBox == null)
                return;
            m_formatting = true;
            m_lastTextBox.SelectionCharOffset = (tbtn_super.Checked) ? 5 : 0;
            m_formatting = false; ;
        }

        private void tbtn_sub_Click(object sender, EventArgs e)
        {
            if (m_lastTextBox == null)
                return;
            m_formatting = true;
            m_lastTextBox.SelectionCharOffset = (tbtn_sub.Checked) ? -5 : 0;
            m_formatting = false;
        }

        private void tbtn_incr_Click(object sender, EventArgs e)
        {
            if (m_lastTextBox == null)
                return;
            m_formatting = true;
            m_lastTextBox.SelectionFont = new Font(m_lastTextBox.SelectionFont.FontFamily.Name,
                m_lastTextBox.SelectionFont.Size+1,
                m_lastTextBox.SelectionFont.Style);
            m_formatting = false; 
        }

        private void tbtn_decr_Click(object sender, EventArgs e)
        {
            if (m_lastTextBox == null)
                return;
            m_formatting = true;
            m_lastTextBox.SelectionFont = new Font(m_lastTextBox.SelectionFont.FontFamily.Name,
                m_lastTextBox.SelectionFont.Size - 1,
                m_lastTextBox.SelectionFont.Style);
            m_formatting = false; 
        }

        private void btn_insertPassage_Click(object sender, EventArgs e)
        {
            AddPassageDialog dialog = new AddPassageDialog(this);
            dialog.Show();
        }
    }
}
