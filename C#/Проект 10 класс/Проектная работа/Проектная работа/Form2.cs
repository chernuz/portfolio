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
    public partial class Form2 : Form
    {
        int SortType;
        public ReadOnlyTextBox[] textBoxes;
        List<int[]> Massivi = new List<int[]>();
        List<string> condition = new List<string>();
        List<string> result = new List<string>();
        List<int[]> redElements = new List<int[]>();
        List<bool> switchOrNot = new List<bool>();
        List<int> tmp = new List<int>();
        int animationIndex = 0;
        int[] array;
        int index = 0;
        int xChange = 0;
        int yChange = 0;
        int tempLeft = 0;
        bool isStopped = false;
        string name;
        public void SwitchTextBoxes(RichTextBox textBox1, RichTextBox textBox2)
        {
            nextStepButton.Enabled = false;
            if(autoModeButton.Text == "Включить автоматический режим")
                autoModeButton.Enabled = false;
            timer1.Enabled = false;
            animationTimer.Enabled = true;
            animationIndex = 0;
            xChange = (textBox2.Left - textBox1.Left) / 11;
            yChange = (textBox2.Top - textBox1.Top)/5;
        }

        public void ShowMassiv(int[] array2, int[] redElements, bool doWeSwitch)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                if (redElements.Length > 0)
                {
                    if (redElements[0] == i || redElements[1] == i)
                    {
                        textBoxes[i].BackColor = Color.FromArgb(255, 192, 192);
                    }
                    else
                    {
                        textBoxes[i].BackColor = Color.FromArgb(-986896);
                    }
                }
                else
                {
                    textBoxes[i].BackColor = Color.FromArgb(-986896);
                }
                textBoxes[i].Text = "Эл " + i + "\n " + array2[i];
            }
            if(doWeSwitch)
            {
                Refresh();
                SwitchTextBoxes(textBoxes[redElements[0]], textBoxes[redElements[1]]);
            }
            if (SortType == 4)
            {
                if (index==0)
                {
                    textBoxes[10].Text = "tmp\nnull ";
                    textBoxes[10].BackColor = Color.FromArgb(-986896);
                }
                else
                {
                    if (tmp[index-1] == 1000)
                    {
                        textBoxes[10].Text = "tmp\nnull ";
                        textBoxes[10].BackColor = Color.FromArgb(-986896);
                    }
                    else
                    {
                        textBoxes[10].Text = "tmp\n " + tmp[index-1];
                        textBoxes[10].BackColor = Color.FromArgb(255, 192, 192);
                    }
                }
            }
            Refresh();
        }

        public List<int[]> SortirovkaVstavkami(int[] array1, out List<string> condition1, out List<string> result1, out List<int[]> redElements1, out List<bool> switchOrNot1)
        {
            List<int[]> ResultingList = new List<int[]>();
            condition1 = new List<string>();
            result1 = new List<string>();
            redElements1 = new List<int[]>();
            switchOrNot1 = new List<bool>();
            int[] array2;
            for (int i = 1; i < array1.Length; i++)
            {
                int j = i;
                for (j = i; j > 0 && array1[j - 1] > array1[j]; j--)
                {
                    array2 = new int[array1.Length];
                    for (int k = 0; k < array1.Length; k++)
                    {
                        array2[k] = array1[k];
                    }
                    ResultingList.Add(array2);
                    int tempElement = array1[j];
                    redElements1.Add(new int[] { j, j-1 });
                    array1[j] = array1[j - 1];
                    array1[j - 1] = tempElement;
                    condition1.Add("Условия:\ni = " + i + "; j = " + j + "\nЭлемент массива под номером " + (j - 1) + " ( j - 1) больше элемента массива под номером " + j + " ( j) - условие выполняется. Условие j > 0 выполняется");
                    result1.Add("Результат:\nУсловия выполнены. Ячейки меняются местами, j уменьшается на 1\n i = " + i + "; j = " + (j - 1));
                    switchOrNot1.Add(true);
                }
                if (j == 0)
                {
                    array2 = new int[array1.Length];
                    for (int k = 0; k < array1.Length; k++)
                    {
                        array2[k] = array1[k];
                    }
                    ResultingList.Add(array2);
                    redElements1.Add(new int[] { j, j });
                    condition1.Add("Условия:\ni = " + i +"; j = " + j + "\nПеребор массива подошел к концу: j = 0 ( условие j > 0 не выполняется)");
                    result1.Add("Результат:\nУсловия не выполнены. i увеличивается на 1, j приравнивается к i.\n i = " + (i+1) + "; j = " + (i+1) );
                    switchOrNot1.Add(false);
                }
                if(j>0 && array[j-1]<array[j])
                {
                    condition1.Add("Условия:\ni = " + i + "; j = " + j +"\nЭлемент массива под номером " + (j-1) + " ( j - 1) меньше элемента массива под номером " + j + " ( j) - условие не выполняется. Условие j > 0 выполняется");
                    result1.Add("Результат:\nУсловия не выполнены. Ячейки не меняются местами, i  увеличивается на 1, j приравнивается к i.\n i = " + (i + 1) + "; j = " + (i + 1) );
                    array2 = new int[array1.Length];
                    for (int k = 0; k < array1.Length; k++)
                    {
                        array2[k] = array1[k];
                    }
                    ResultingList.Add(array2);
                    redElements1.Add(new int[] { j, j - 1 });
                    switchOrNot1.Add(false);
                }
            }
            array2 = new int[array1.Length];
            for (int k = 0; k < array1.Length; k++)
            {
                array2[k] = array1[k];
            }
            ResultingList.Add(array2);
            redElements1.Add(new int[] { });
            condition1.Add("Сортировка окончена!");
            result1.Add("Сортировка окончена!");
            switchOrNot1.Add(false);
            return ResultingList;
        }

        public List<int[]> BubbleSort(int[] arr, out List<string> condition1, out List<string> result1, out List<int[]> redElements1, out List<bool> switchOrNot1)
        {
            List<int[]> ResultingList = new List<int[]>();
            condition1 = new List<string>();
            result1 = new List<string>();
            redElements1 = new List<int[]>();
            switchOrNot1 = new List<bool>();
            int[] arr2;
            int n = arr.Length;
            bool sorted = false;
            while (sorted == false)
            {
                condition1.Add("sorted = false");
                result1.Add("Так как массив еще не отсортирован, то сортировка продолжается");
                switchOrNot1.Add(false);
                redElements.Add(new int[] { 20, 20});
                arr2 = new int[arr.Length];
                for (int k = 0; k < arr.Length; k++)
                {
                    arr2[k] = arr[k];
                }
                ResultingList.Add(arr2);
                sorted = true;
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        
                        sorted = false;
                        condition1.Add(("sorted = " + (sorted ? "true" : "false") + "; i = " + i) + "\nЭлемент массива под номером " + (i - 1) + " (i-1) оказался больше элемента под номером" + i + " (i). Условия выполняются");
                        result1.Add("Условия выполняются. Элементы массива меняются местами, i увеличивается на 1\ni = " + i + ";\nsorted = " + (sorted ? "true" : "false"));
                        switchOrNot1.Add(true);
                        redElements.Add(new int[] { i, i - 1 });
                        arr2 = new int[arr.Length];
                        for (int k = 0; k < arr.Length; k++)
                        {
                            arr2[k] = arr[k];
                        }
                        ResultingList.Add(arr2);
                        int tmp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = tmp;
                    }
                    else
                    {
                        condition1.Add(("sorted = " + (sorted? "true": "false") + "; i = " + i) + "\nЭлемент массива под номером "+ (i-1) + " (i-1) оказался меньше или равен элементу под номером" + i + " (i). Условия не выполняются");
                        result1.Add("Условия не выполняются. Проход массива завершается\nsorted = " + (sorted ? "true" : "false"));
                        switchOrNot1.Add(false);
                        redElements.Add(new int[] { i, i - 1 });
                        arr2 = new int[arr.Length];
                        for (int k = 0; k < arr.Length; k++)
                        {
                            arr2[k] = arr[k];
                        }
                        ResultingList.Add(arr2);
                    }
                }
            }
            condition1.Add("Сортировка окончена!");
            result1.Add("Сортировка окончена!");
            switchOrNot1.Add(false);
            redElements1.Add(new int[] { 100, 100 });
            arr2 = new int[arr.Length];
            for (int k = 0; k < arr.Length; k++)
            {
                arr2[k] = arr[k];
            }
            ResultingList.Add(arr2);
            return ResultingList;
        }

        public List<int[]> ShellSort(int[] arr, out List<string> condition1, out List<string> result1, out List<int[]> redElements1, out List<bool> switchOrNot1, out List<int> tmp1)
        {
            List<int[]> ResultingList = new List<int[]>();
            condition1 = new List<string>();
            result1 = new List<string>();
            redElements1 = new List<int[]>();
            switchOrNot1 = new List<bool>();
            tmp1 = new List<int>();
            int[] arr2;
            int n = arr.Length;
            int h;
            for (h = 1; h <= n / 9; h = 3 * h + 1)
            {
                condition1.Add("Рассчитываем максимальный шаг сортировки:\nh = " + h + "; n = " + n + "\n" + h + " ( h ) <= " + n + " ( n ). Условия выполняются");
                result1.Add("Шаг увеличивается:\n h = " + h + " ( h ) * 3 + 1 = " + (3*h + 1));
                switchOrNot1.Add(false);
                redElements1.Add(new int[]{ 100, 100 });
                tmp1.Add(1000);
                arr2 = new int[arr.Length];
                for (int k = 0; k < arr.Length; k++)
                {
                    arr2[k] = arr[k];
                }
                ResultingList.Add(arr2);

            };
            condition1.Add("Рассчитываем максимальный шаг сортировки:\nh = " + h + "; n = " + n + "\n" + h + " ( h ) > " + n + " ( n ). Условия не выполняются");
            result1.Add("Максимальный шаг рассчитан:\n h = " + h);
            switchOrNot1.Add(false);
            redElements1.Add(new int[]{ 100, 100 });
            tmp1.Add(1000);
            arr2 = new int[arr.Length];
            for (int k = 0; k < arr.Length; k++)
            {
                arr2[k] = arr[k];
            }
            ResultingList.Add(arr2);
            for (; h > 0; h /= 3)
            {
                for (int i = h; i < n; i++)
                {
                    int tmp2;
                    int j = i;
                    tmp2 = arr[i];
                    condition1.Add("Берем i = h = " + i + ";\nПриравниваем временную переменную tmp к элементу массива под номером "+ i + ":\ntmp = " + tmp2);
                    result1.Add("Переходим к перебору массива");
                    switchOrNot1.Add(true);
                    redElements1.Add(new int[]{ 10, i });
                    tmp1.Add(tmp2);
                    arr2 = new int[arr.Length];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr2[k] = arr[k];
                    }
                    ResultingList.Add(arr2);
                    while (j >= h && tmp2 < arr[j - h])
                    {
                        condition1.Add("j = "+ j +"; tmp = " + tmp2 + "\n" + j + " ( j ) >= " + h + " ( h ); \nВременно взятый элемент массива tmp меньше элемента номер " + (j-h) + " ( j - h )\nУсловия выполняются");
                        result1.Add(" Условия выполняются. Следовательно, приравниваем элемент массива под номером " + j + " ( j ) элементу массива под номером " + (j - h) + " ( j - h ), j уменьшаем на " + h + " ( h )\nj = " + (j-h) + "; tmp = " + tmp2);
                        switchOrNot1.Add(true);
                        redElements1.Add(new int[]{ j, j-h});
                        tmp1.Add(tmp2);
                        arr2 = new int[arr.Length];
                        for (int k = 0; k < arr.Length; k++)
                        {
                            arr2[k] = arr[k];
                        }
                        ResultingList.Add(arr2);
                        arr[j] = arr[j - h];
                        j -= h;
                        
                    }
                    condition1.Add("j = "+ (j+h) +"; tmp = " + tmp2 +(j >= h? ((j+h)+" ( j ) >= " + h+" ( h ),"): ((j+h)+" ( j ) < " + h+" ( h ),")) + (tmp2 < arr[j]? (" временно взятый элемент массива tmp меньше элемента номер" + (j) + " ( j - h )") :(" временно взятый элемент массива tmp больше или равен элементу номер" + j + " ( j - h )") + "\nУсловия не выполняются"));
                    result1.Add("Условия не выполняются. Следовательно, приравниваем элемент массива номер " + j + " ( j ) изначально взятому временному значению tmp");
                    switchOrNot1.Add(true);
                    redElements1.Add(new int[]{ j, 10 });
                    arr2 = new int[arr.Length];
                    tmp1.Add(tmp2);
                    for (int k = 0; k < arr.Length; k++)
                    {
                        arr2[k] = arr[k];
                    }
                    ResultingList.Add(arr2);
                    arr[j] = tmp2;
                }
                condition1.Add("Проход массива с данным шагом h = " + h +" завершен");
                result1.Add("Переходим на более маленький шаг сортировки:\n h = (h - 1) / 3 = h / 3 = " + h/3);
                switchOrNot1.Add(false);
                redElements1.Add(new int[]{ 100, 100 });
                arr2 = new int[arr.Length];
                tmp1.Add(1000);
                for (int k = 0; k < arr.Length; k++)
                {
                    arr2[k] = arr[k];
                }
                ResultingList.Add(arr2);
            }
            condition1.Add("Сортировка окончена!");
            result1.Add("Сортировка окончена!");
            switchOrNot1.Add(false);
            redElements1.Add(new int[]{ 100, 100 });
            arr2 = new int[arr.Length];
            for (int k = 0; k < arr.Length; k++)
            {
                arr2[k] = arr[k];
            }
            ResultingList.Add(arr2);
            return ResultingList;
        }

        public Form2(int SortType, string name1)//2 - пузырек, 3 - вставками, 4 - Шелла
        {
            name = name1;
            this.SortType = SortType;
            
            InitializeComponent();
            textBoxes = new ReadOnlyTextBox[] { TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, readOnlyTextBoxTmp};
            array = new int[10];
            int k = 15;
            for(int i=0; i<textBoxes.Length-1; i++)
            {
                textBoxes[i].Left = k;
                k += 55;
            }
        }

        private void autoModeButton_Click(object sender, EventArgs e)
        {
            if(autoModeButton.Text == "Включить автоматический режим")
            {
                autoModeButton.Text = "Выключить автоматический режим";
                nextStepButton.Enabled = false;
                stopButton.Enabled = true;
                stopButton.Text = "Стоп";
                timer1.Enabled = true;
                isStopped = false;
            }
            else
            {
                autoModeButton.Text = "Включить автоматический режим";
                nextStepButton.Enabled = true;
                stopButton.Text = "Стоп";
                stopButton.Enabled = false;
                timer1.Enabled = false;
                isStopped = false;
            }
        }

        private void nextStepButton_Click(object sender, EventArgs e)
        {
            switch (nextStepButton.Text)
            {
                case "Следующий шаг":
                    {
                        if (index < Massivi.Count())
                        {
                            ShowMassiv(Massivi[index], redElements[index], switchOrNot[index]);
                            conditionTextBox.Text = condition[index];
                            resultTextBox.Text = result[index];
                            index++;
                            if (index == Massivi.Count())
                            {
                                nextStepButton.Enabled = true;
                                stopButton.Enabled = false;
                                autoModeButton.Enabled = false;
                                nextStepButton.Text = "Завершить";
                            }
                            Refresh();
                        }
                        break;
                    }
                case "Завершить":
                    {
                        this.Close();
                        break;
                    }
                default:
                    {
                        nextStepButton.Text = "Следующий шаг";
                        autoModeButton.Enabled = true;
                        int[] array1 = array;
                        switch (SortType)
                        {
                            case 3:
                                Massivi = SortirovkaVstavkami(array1, out condition, out result, out redElements, out switchOrNot);
                                break;
                            case 2:
                                Massivi = BubbleSort(array1, out condition, out result, out redElements, out switchOrNot);
                                break;
                            case 4:
                                Massivi = ShellSort(array1, out condition, out result, out redElements, out switchOrNot, out tmp);
                                break;
                        }  
                        ShowMassiv(Massivi[index], redElements[index], switchOrNot[index]);
                        conditionTextBox.Text = condition[index];
                        resultTextBox.Text = result[index];
                        index++;
                        if (index == Massivi.Count()-1)
                        {
                            nextStepButton.Enabled = true;
                            stopButton.Enabled = false;
                            autoModeButton.Enabled = false;
                            nextStepButton.Text = "Завершить";
                        }
                        Refresh();
                        break;
                    }
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (SortType == 4)
                readOnlyTextBoxTmp.Visible = true;
            else
                readOnlyTextBoxTmp.Visible = false;
            this.Text = name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (SortType == 4)
            {
                readOnlyTextBoxTmp.Visible = true;
                groupBox1.Height = 165;
            }
            else
            {
                readOnlyTextBoxTmp.Visible = false;
                groupBox1.Height = 130;
            }
            animationTimer.Interval = 100;
            timer1.Interval = 750;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            tmp = new List<int>();
            tmp.Add(1000);
            ShowMassiv(array, new int[] { }, false);
            conditionTextBox.Lines = new string[] { "" };
            condition = new List<string>();
            result = new List<string>();
            switchOrNot = new List<bool>();
            tmp = new List<int>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < Massivi.Count())
            {
                ShowMassiv(Massivi[index], redElements[index], switchOrNot[index]);
                conditionTextBox.Text = condition[index];
                resultTextBox.Text = result[index];
                index++;
                if (index == Massivi.Count() - 1)
                {
                    nextStepButton.Enabled = true;
                    stopButton.Enabled = false;
                    autoModeButton.Enabled = false;
                    nextStepButton.Text = "Завершить";
                }
                Refresh();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (stopButton.Text == "Стоп")
            {
                timer1.Enabled = false;
                isStopped = true;
                stopButton.Text = "Продолжить";
            }
            else
            {
                isStopped = false;
                timer1.Enabled = true;
                stopButton.Text = "Стоп";
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animationIndex<11)
            {
                ReadOnlyTextBox textBox1 = textBoxes[redElements[index - 1][1]];
                ReadOnlyTextBox textBox2 = textBoxes[redElements[index - 1][0]];//в Shell не перелетает
                textBox1.Left -= xChange;
                if (SortType == 4)
                {
                    if (animationIndex == 0)
                    {
                        tempLeft = textBox1.Left + xChange;
                        textBox1.Top += 10;
                    }
                    if (animationIndex > 0 & animationIndex < 5)
                    {
                        textBox1.Top += 5;
                    }
                    //==5 пропускаем
                    if (animationIndex > 5 & animationIndex < 10)
                    {
                        textBox1.Top -= 5+yChange;
                    }
                    if (animationIndex == 10)
                    {
                        textBox1.Top -= 10+yChange;
                        if (redElements[index - 1][1] != 10)
                            textBox1.Text = "Эл " + (redElements[index - 1][1]) + "\n " + Massivi[index][redElements[index - 1][1]];
                        if(redElements[index - 1][0]!=10)
                            textBox2.Text = "Эл " + (redElements[index - 1][0]) + "\n " + Massivi[index][redElements[index - 1][0]];
                        textBoxes[10].BackColor = Color.FromArgb(255, 192, 192);
                        readOnlyTextBoxTmp.Text = "tmp\n " + tmp[index - 1];
                        textBox1.Left = tempLeft;
                        textBox1.Left = tempLeft;
                        textBox1.Top += yChange*5;
                    }
                }
                else
                {
                    textBox2.Left += xChange;
                    if (animationIndex == 0)
                    {
                        textBox2.Top -= 10;
                        textBox1.Top += 10;
                    }
                    if (animationIndex > 0 & animationIndex < 5)
                    {
                        textBox2.Top -= 5;
                        textBox1.Top += 5;
                    }
                    //==5 пропускаем
                    if (animationIndex > 5 & animationIndex < 10)
                    {
                        textBox2.Top += 5;
                        textBox1.Top -= 5;
                    }
                    if (animationIndex == 10)
                    {
                        textBox2.Top += 10;
                        textBox1.Top -= 10;
                        textBox1.Text = "Эл " + (redElements[index - 1][1]) + "\n " + Massivi[index][redElements[index - 1][1]];
                        textBox2.Text = "Эл " + (redElements[index - 1][0]) + "\n " + Massivi[index][redElements[index - 1][0]];
                        
                        tempLeft = textBox2.Left;
                        textBox2.Left = textBox1.Left;
                        textBox1.Left = tempLeft;

                    }
                }
                animationIndex++;
            }
            else
            {
                animationIndex = 0;
                animationTimer.Enabled = false;
                autoModeButton.Enabled = true;
                if (autoModeButton.Text == "Включить автоматический режим")
                {
                    nextStepButton.Enabled = true;
                }
                else if (isStopped==false)
                    timer1.Enabled = true;
            }
            Refresh();
        }

    }
}