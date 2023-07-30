namespace Проектная_работа
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.autoModeButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox10 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox9 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox8 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox7 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox6 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox5 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox4 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox3 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox2 = new Проектная_работа.ReadOnlyTextBox();
            this.TextBox1 = new Проектная_работа.ReadOnlyTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.resultTextBox = new Проектная_работа.ReadOnlyTextBox();
            this.conditionTextBox = new Проектная_работа.ReadOnlyTextBox();
            this.readOnlyTextBoxTmp = new Проектная_работа.ReadOnlyTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextStepButton
            // 
            this.nextStepButton.Location = new System.Drawing.Point(591, 361);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(152, 47);
            this.nextStepButton.TabIndex = 0;
            this.nextStepButton.Text = "Старт";
            this.nextStepButton.UseVisualStyleBackColor = true;
            this.nextStepButton.Click += new System.EventHandler(this.nextStepButton_Click);
            // 
            // autoModeButton
            // 
            this.autoModeButton.Enabled = false;
            this.autoModeButton.Location = new System.Drawing.Point(317, 361);
            this.autoModeButton.Name = "autoModeButton";
            this.autoModeButton.Size = new System.Drawing.Size(152, 47);
            this.autoModeButton.TabIndex = 1;
            this.autoModeButton.Text = "Включить автоматический режим";
            this.autoModeButton.UseVisualStyleBackColor = true;
            this.autoModeButton.Click += new System.EventHandler(this.autoModeButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(40, 361);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(152, 47);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.readOnlyTextBoxTmp);
            this.groupBox1.Controls.Add(this.TextBox10);
            this.groupBox1.Controls.Add(this.TextBox9);
            this.groupBox1.Controls.Add(this.TextBox8);
            this.groupBox1.Controls.Add(this.TextBox7);
            this.groupBox1.Controls.Add(this.TextBox6);
            this.groupBox1.Controls.Add(this.TextBox5);
            this.groupBox1.Controls.Add(this.TextBox4);
            this.groupBox1.Controls.Add(this.TextBox3);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "                                                                          Элемент" +
    "ы массива";
            // 
            // TextBox10
            // 
            this.TextBox10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox10.Location = new System.Drawing.Point(690, 50);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.ReadOnly = true;
            this.TextBox10.Size = new System.Drawing.Size(50, 50);
            this.TextBox10.TabIndex = 22;
            this.TextBox10.TabStop = false;
            this.TextBox10.Text = "";
            // 
            // TextBox9
            // 
            this.TextBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox9.Location = new System.Drawing.Point(615, 50);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.ReadOnly = true;
            this.TextBox9.Size = new System.Drawing.Size(50, 50);
            this.TextBox9.TabIndex = 21;
            this.TextBox9.TabStop = false;
            this.TextBox9.Text = "";
            // 
            // TextBox8
            // 
            this.TextBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox8.Location = new System.Drawing.Point(540, 50);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.ReadOnly = true;
            this.TextBox8.Size = new System.Drawing.Size(50, 50);
            this.TextBox8.TabIndex = 20;
            this.TextBox8.TabStop = false;
            this.TextBox8.Text = "";
            // 
            // TextBox7
            // 
            this.TextBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox7.Location = new System.Drawing.Point(465, 50);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ReadOnly = true;
            this.TextBox7.Size = new System.Drawing.Size(50, 50);
            this.TextBox7.TabIndex = 19;
            this.TextBox7.TabStop = false;
            this.TextBox7.Text = "";
            // 
            // TextBox6
            // 
            this.TextBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox6.Location = new System.Drawing.Point(390, 50);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.ReadOnly = true;
            this.TextBox6.Size = new System.Drawing.Size(50, 50);
            this.TextBox6.TabIndex = 18;
            this.TextBox6.TabStop = false;
            this.TextBox6.Text = "";
            // 
            // TextBox5
            // 
            this.TextBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox5.Location = new System.Drawing.Point(315, 50);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new System.Drawing.Size(50, 50);
            this.TextBox5.TabIndex = 17;
            this.TextBox5.TabStop = false;
            this.TextBox5.Text = "";
            // 
            // TextBox4
            // 
            this.TextBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox4.Location = new System.Drawing.Point(240, 50);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(50, 50);
            this.TextBox4.TabIndex = 16;
            this.TextBox4.TabStop = false;
            this.TextBox4.Text = "";
            // 
            // TextBox3
            // 
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox3.Location = new System.Drawing.Point(165, 50);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(50, 50);
            this.TextBox3.TabIndex = 15;
            this.TextBox3.TabStop = false;
            this.TextBox3.Text = "";
            // 
            // TextBox2
            // 
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox2.Location = new System.Drawing.Point(90, 50);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(50, 50);
            this.TextBox2.TabIndex = 14;
            this.TextBox2.TabStop = false;
            this.TextBox2.Text = "";
            // 
            // TextBox1
            // 
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox1.Location = new System.Drawing.Point(15, 50);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(50, 50);
            this.TextBox1.TabIndex = 5;
            this.TextBox1.TabStop = false;
            this.TextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultTextBox.Location = new System.Drawing.Point(405, 12);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(365, 100);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.Text = "Результат:";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Location = new System.Drawing.Point(15, 12);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.ReadOnly = true;
            this.conditionTextBox.Size = new System.Drawing.Size(365, 100);
            this.conditionTextBox.TabIndex = 6;
            this.conditionTextBox.Text = "Условия:";
            // 
            // readOnlyTextBoxTmp
            // 
            this.readOnlyTextBoxTmp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.readOnlyTextBoxTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.readOnlyTextBoxTmp.Location = new System.Drawing.Point(353, 137);
            this.readOnlyTextBoxTmp.Name = "readOnlyTextBoxTmp";
            this.readOnlyTextBoxTmp.ReadOnly = true;
            this.readOnlyTextBoxTmp.Size = new System.Drawing.Size(50, 50);
            this.readOnlyTextBoxTmp.TabIndex = 23;
            this.readOnlyTextBoxTmp.TabStop = false;
            this.readOnlyTextBoxTmp.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.autoModeButton);
            this.Controls.Add(this.nextStepButton);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form2";
            this.Text = "Визуализация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Button autoModeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private ReadOnlyTextBox TextBox10;
        private ReadOnlyTextBox TextBox9;
        private ReadOnlyTextBox TextBox8;
        private ReadOnlyTextBox TextBox7;
        private ReadOnlyTextBox TextBox6;
        private ReadOnlyTextBox TextBox5;
        private ReadOnlyTextBox TextBox4;
        private ReadOnlyTextBox TextBox3;
        private ReadOnlyTextBox TextBox2;
        private ReadOnlyTextBox TextBox1;
        private System.Windows.Forms.Timer animationTimer;
        private ReadOnlyTextBox resultTextBox;
        private ReadOnlyTextBox conditionTextBox;
        private ReadOnlyTextBox readOnlyTextBoxTmp;
    }
}