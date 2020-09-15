using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Reader
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
           
        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
              
        }

        public string BufferText2
        {
            get
            {
                return richTextBox1.Text;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
