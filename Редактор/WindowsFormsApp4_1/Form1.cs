using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp4_1
{
    
    public partial class Form1 : Form
    {
        public string path { get; set; } = "";
        public Form1()
        {
            
            InitializeComponent();
           richTextBox1.AllowDrop = true;

            открытьToolStripButton.Click += открытьToolStripMenuItem_Click;
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;

            создатьToolStripButton.Click += создатьToolStripMenuItem_Click;
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;

            сохранитьToolStripButton.Click += сохранитьToolStripMenuItem_Click;
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;

            вырезатьToolStripButton.Click += вырезатьToolStripMenuItem_Click;
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;

            копироватьToolStripButton.Click += копироватьToolStripMenuItem_Click;
            копироватьToolStripMenuItem.Click += КопироватьToolStripMenuItem_Click;

            вставкаToolStripButton.Click += ВставкаToolStripButton_Click;
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;

            richTextBox1.DragDrop += Form1_DragDrop;


        }

        private void RichTextBox1_DragLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RichTextBox1_DragEnter1(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RichTextBox1_DragDrop1(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ВставкаToolStripButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = dialog.Color;
            }
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = dialog.Color;
            }

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dialog.Font;
            }
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                StreamWriter writer = new StreamWriter(path, false, Encoding.Default);
                writer.Write(richTextBox1.Text);
                writer.Close();
                MessageBox.Show("Сохранено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Выберите файл", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                Text =$"{path}";
                StreamReader reader = new StreamReader(dialog.FileName, Encoding.Default);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Text Files(*txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                Text = $"{path}";
                StreamWriter writer = new StreamWriter(path, false, Encoding.Default);
                writer.Write(richTextBox1.Text);
                writer.Close();
                MessageBox.Show("Сохранено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            throw new NotImplementedException();
        }



        private void Form1_DragLeave(object sender, EventArgs e)
        {
           richTextBox1.Text = "Перетащите файлы сюда!!!!";
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
           
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            path = "";
            richTextBox1.Text = "";
            List<string> paths = new List<string>();
            foreach (string item in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (Directory.Exists(item)) 
                { 
                 paths.AddRange(Directory.GetFiles(item, "All Files(*.*)|*.*|Text Files(*txt)|*.txt", SearchOption.AllDirectories));
                    paths.Add(item);
                    path += $"{paths.ToString()}";
                }
                else
                    paths.Add(item);
                    path = $"{paths[0].ToString()}";
                
            }
              Text = path;


            foreach (string item in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                StreamReader reader = new StreamReader(item.ToString(), Encoding.Default);

                richTextBox1.Text += reader.ReadToEnd();
                reader.Close();
            }
        }
    }
    
}

