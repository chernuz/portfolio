using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектная_работа
{
    public partial class Form3 : Form
    {
        string text;
        string name;
        public Form3(string s, string name)
        {
            InitializeComponent();
            text = s;
            this.name = name;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            toolStrip1.Height = 100;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            this.Text = name;
            readOnlyTextBox1.Text = text;
            toolStripLabel1.Margin = new Padding((this.Width - toolStripLabel1.Width) / 2, 1, 0, 2);
            closeFormButton.Left = (this.Width - closeFormButton.Width) / 2;
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
