using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;

namespace Проектная_работа
{
    public partial class Проект : Form
    {
        List<Page> PagesList = new List<Page> { new Page(1, 0, "Меню"), new Page(2, 1, "Сортировки"), new Page(2, 2, "Сортировка пузырьком"), new Page (2, 3, "Сортировка вставками"), new Page (2, 4, "Сортировка Шелла"), new Page(1, 5, "Финальная страницы") };
        int PageNumber = 0;
        string[] codesArray = new string[] { "", "", "1 Flag ← false\n2 while not Flag do\n3 for i ← 1 to N\n4 if A[i] < A[i – 1] then\n5   tmp ← A[i]\n6   A[i] ← A[i – 1]\n7   A[i – 1] ← tmp\n8   Flag ← false;", "1 for j ← 2 to length (A)\n2 do key ← A[j]\n3 // Вставка элемента A[j] в отсортированную последовательность A[1..j-1]\n4 i ← j-1\n5 while i> 0 и A[i] > key\n6 do A[i+1] ← A [i]\n7 i ← i-1\n8 A[i+1] ← кеу", "1 h ←1\n2 while h < N / 9 do h ← h*3 + 1\n3 repeat // цикл по сериям\n4 for i ← h... N do {сортировка i-ой серии}\n5 j ← i\n6 tmp ← A[i]\n7 while j <= h и tmp < A[j – h] do //сдвиг\n8 A[j] = A[j – h]\n9 j ← j – h;\n10 A[j] ← tmp\n11 h ← h / 3 {переход к новой серии}\n12 while h>0", "" };        //ReadOnlyTextBox rotb = new ReadOnlyTextBox();
        Form2 f2;
        Form3 f3;

        public Проект()
        {
            InitializeComponent();
            /*ReadOnlyTextBox rotb = new ReadOnlyTextBox();
            rotb.Location = new Point(6, 6);
            this.Controls.Add(rotb);
            rotb.Text = PagesList[PageNumber].Text;*/

            //rotb.Location = new Point(6, 6);
            //rotb.Dock = DockStyle.Fill;
            //rotb.ScrollBars = ScrollBars.Vertical;
            //rotb.Visible = true;
            //this.Controls.Add(rotb);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            toolStrip1.Size = new Size(907, 50);
            menuButton.Size = new Size(30, 30);
            backButton.Size = new Size(30, 30);
            infoButton.Size = new Size(30, 30);
            forwardButton.Size = new Size(30, 30);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (menuButton.Enabled == true)
                PageNumber = 0;
        }

        private void Проект_Paint(object sender, PaintEventArgs e)
        {
            pageName.Margin = new Padding((this.Width - menuButton.Width * 4 - pageName.Width - 20) / 2, 1, 0, 2);
            groupBox1.Width = (this.Width - 21) * 95 / 100;
            if (PageNumber == 0)
            {
                backButton.Enabled = false;
                groupBox1.Visible = true;
            }
            else
            {
                backButton.Enabled = true;
                groupBox1.Visible = false;
            }
            if (PageNumber == PagesList.Count() - 1)
            {
                nextButton.Text = "Закрыть";
                forwardButton.Enabled = false;
            }
            else
            {

                nextButton.Text = "Далее";
                forwardButton.Enabled = true;
            }
            PagesList[PageNumber].Show();
            pageName.Text = PagesList[PageNumber].Name;
            readOnlyTextBox1.Text = PagesList[PageNumber].Text;
            startSortingButton.Left = (Width - startSortingButton.Width) / 2 + 10;
            startSortingButton.Top = nextButton.Top;
            if (PageNumber>1 && PageNumber<5)
            {
                startSortingButton.Visible = true;
                showCodeButton.Visible = true;
            }
            else
            {
                startSortingButton.Visible = false;
                showCodeButton.Visible = false;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            PageNumber++;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PageNumber--;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            PagesList[PageNumber].Info();
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            if (nextButton.Text == "Далее")
                PageNumber++;
            else
                this.Dispose();
        }

        private void startSortingButton_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Form2(PageNumber, PagesList[PageNumber].Name);
                f2.Show();
            }
            else
            {
                f2.Activate();
                f2.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void showCodeButton_Click(object sender, EventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Form3(codesArray[PageNumber], PagesList[PageNumber].Name);
                f3.Left = (this.Width - f3.Width) / 2;
                f3.Show();
                f3.Left = (this.Width - f3.Width) / 2;
            }
            else
            {
                f3.Left = (this.Width - f3.Width) / 2;
                f3.Activate();
                f3.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageNumber = 2;
            Refresh();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageNumber = 1;
            Refresh();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageNumber = 3;
            Refresh();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageNumber = 4;
            Refresh();
        }

    }
    public class ReadOnlyTextBox : RichTextBox
    {
        public ReadOnlyTextBox()
        {
            HideCaret(this.Handle);
        }
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool HideCaret(IntPtr hwnd);

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            HideCaret(this.Handle);
            
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            HideCaret(this.Handle);
            
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            HideCaret(this.Handle);
            
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            HideCaret(this.Handle);
        }
    }
}
