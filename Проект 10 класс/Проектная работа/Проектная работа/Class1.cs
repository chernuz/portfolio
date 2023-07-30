using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектная_работа
{
    class Sortirovka
    {
        public int[] array;
        public Sortirovka(int[] array)
        {
            this.array = array;
        }
        public Sortirovka()
        {
            array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next();
            }
        }
        public int[] Array
        {
            get
            {
                return array;
            }
        }
    }
    /*public class ReadOnlyRichTextBox : RichTextBox
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public ReadOnlyRichTextBox()
        {
            this.ReadOnly = true;
            this.TabStop = false;

        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            HideCaret(this.Handle);
        }
        /*protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = null;
        }*/
    //}
}
