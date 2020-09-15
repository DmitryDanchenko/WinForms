using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Reader
{

    public partial class Form1 : Form
    {
        private string _DocName;
        private string _BufferTex;
        private int _tempPage;
        private String _Bookmark;
        private List<string> _strPage = new List<string>();
        private string _FileType;



        public Form1()
        {
            _DocName = null;
            _BufferTex = null;
            _tempPage = 0;
            InitializeComponent();
            richTextBox.Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular);
            richTextBox.SelectionColor = System.Drawing.Color.AntiqueWhite;

        }


        private void Open_File_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"All Files|*.txt;*|Text File (.txt)|*.txt|Word File (.docx )|*.docx";
            



            if (dialog.ShowDialog() == DialogResult.OK)
            {

                _DocName = dialog.FileName;
                _FileType = _DocName.Substring(_DocName.LastIndexOf('.'));

                Text = $"{_DocName}";

                if (_FileType == ".docx" || _FileType == ".doc")
                {
                    WordprocessingDocument wordDoc = WordprocessingDocument.Open(_DocName, true);

                    Body body = wordDoc.MainDocumentPart.Document.Body;
                    _BufferTex = Convert.ToString(body.InnerText);
                    wordDoc.Close();                  
                    string[] newText = Regex.Split(_BufferTex, @" ");

                    richTextBox.Text = newText[1];
                    string BufferStr = "";
                    _strPage.Clear();
                    _tempPage = 0;


                    for (int i = 0; i < newText.Length; i++)
                    {
                        if (i % 3000 == 0)
                        {
                            BufferStr += $"\n\n            Page:   {_tempPage}";
                            _strPage.Insert(_tempPage, BufferStr);
                            BufferStr = "";
                            _tempPage++;
                        }
                        else
                        {
                            BufferStr += (_BufferTex[i]);
                        }
                    }
                    _tempPage = 1;
                    label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
                    richTextBox.Text = _strPage[_tempPage];
                }


                if (_FileType == ".rtf" || _FileType == ".RTF")
                {

                    _BufferTex = System.IO.File.ReadAllText(_DocName);

                    richTextBox.Rtf = _BufferTex; 

                }


                if (_FileType == ".txt" || _FileType == ".TXT")
                    {

                        StreamReader reader = new StreamReader(dialog.FileName, Encoding.Default);
                        _BufferTex = reader.ReadToEnd();
                        reader.Close();
                        string[] newText = Regex.Split(_BufferTex, @"\n");

                        richTextBox.Text = newText[1];
                        string BufferStr = "";
                        _strPage.Clear();
                        _tempPage = 0;

                        for (int i = 0; i < newText.Length; i++)
                        {
                            if (i % 30 == 0)
                            {
                                BufferStr += $"\n\n            Page:   {_tempPage}";
                                _strPage.Insert(_tempPage, BufferStr);
                                BufferStr = "";
                                _tempPage++;
                            }
                            else
                            {
                                BufferStr += (newText[i] + "\n");
                            }
                        }
                        _tempPage = 1;
                        label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
                        richTextBox.Text = _strPage[_tempPage];
                    }
                

            }
        }

    




        private void bunBack_Click(object sender, EventArgs e)
        { 

            try 
            { 
            this._tempPage--;
                label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
                richTextBox.Text = _strPage[_tempPage];
            }
            catch (Exception) { }
        }

        private void bunNext_Click(object sender, EventArgs e)
        {
            
            try
            {
             this._tempPage++;
                label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
                richTextBox.Text = _strPage[_tempPage];
            }
            catch (Exception) { }
        }

        private void createBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_DocName != "")
            {
                try 
                {                        
                StreamWriter writer = new StreamWriter("Bookmark.txt", true, Encoding.Default);
                    writer.Write(_DocName + "\n" + _tempPage.ToString() + "\n");
                    writer.Close();
                }
                catch (Exception)
                {
                    StreamWriter writer = new StreamWriter("Bookmark.txt", false, Encoding.Default);
                    writer.Write(_DocName + "\n" + _tempPage.ToString() + "\n");
                    writer.Close();
                }
                
                MessageBox.Show("Сохранено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Выберите файл", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GoOverBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            { 
            StreamReader reader = new StreamReader("Bookmark.txt", Encoding.Default);
                _Bookmark = reader.ReadToEnd();
                 
                String[] masBookmark = Regex.Split(_Bookmark, @"\n");
                for (int i = 0; i < masBookmark.Length; i++)
                {
                    if (masBookmark[i].Contains(_DocName))
                    {
                        
                        _tempPage = Convert.ToInt32 (masBookmark[i+1]);
                        label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
                    }
                }
                
                reader.Close();
                richTextBox.Text = _strPage[_tempPage];
                label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
            }
            catch (Exception)
            {
              MessageBox.Show("Файл не найден", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void createQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Оставить комментарий?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {               
             Form2 form2 = new Form2();
                if (form2.ShowDialog() == DialogResult.OK) 
                {
                _BufferTex = richTextBox.SelectedText+ "\nКомментарий\n"+ form2.BufferText2;
                }
                form2.Close();

            }
            else 
            { 
            _BufferTex = richTextBox.SelectedText;
            }
            
            if (_DocName != "")
            {
                try
                {
                    StreamWriter writer = new StreamWriter("Quotes.txt", true, Encoding.Default);
                    writer.Write("\n"+_BufferTex + "\nИсточник-"+_DocName + "\nСтраница " + _tempPage.ToString() + "\n");
                    writer.Close();
                }
                catch (Exception)
                {
                    StreamWriter writer = new StreamWriter("Quotes.txt", false, Encoding.Default);
                    writer.Write("\n"+_BufferTex + "\nИсточник-" + _DocName + "\nСтраница " + _tempPage.ToString() + "\n");
                    writer.Close();
                }

                MessageBox.Show("Сохранено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Файл не найден", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void watchQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Quotes.txt", Encoding.Default);
            richTextBox.Text = reader.ReadToEnd();
            reader.Close();
        }

        

        private void searchTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BufferTex = "";
            try 
            { 
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                _BufferTex = form2.BufferText2;
            }
            form2.Close();

                for (int i = 0; i < _strPage.Count; i++)
                    
                {
                    
                    if (_strPage[i].Contains(_BufferTex))
                    {
                        
                    _tempPage = i;
                    richTextBox.Text = _strPage[_tempPage];
                    label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
                        
                     richTextBox.SelectionColor = System.Drawing.Color.AntiqueWhite;
                     richTextBox.Select (richTextBox.Text.IndexOf(_BufferTex), _BufferTex.Length) ;
                                           
                     break;
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Совпадений не найдено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void searchPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    _BufferTex = form2.BufferText2;
                }
                form2.Close();

                _tempPage = Convert.ToInt32(_BufferTex);
                richTextBox.Text = _strPage[_tempPage];
                label1.Text = $"Page:{_tempPage}/{_strPage.Count}";
            }

            catch (Exception)
            {
                MessageBox.Show("Совпадений не найдено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cloceQuotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = _strPage[_tempPage];
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.BackColor = dialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Font = dialog.Font;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.ForeColor = dialog.Color;
            }
        }
    }
    
    
}
