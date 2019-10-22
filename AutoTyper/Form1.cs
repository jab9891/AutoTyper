using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = Clipboard.GetText();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(Convert.ToInt32(numDelay.Value * 1000));
            SendKeys.Send(richTextBox1.Text);
        }
    }
}
