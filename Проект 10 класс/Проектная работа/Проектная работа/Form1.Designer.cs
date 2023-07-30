namespace Проектная_работа
{
    partial class Проект
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Проект));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuButton = new System.Windows.Forms.ToolStripButton();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.pageName = new System.Windows.Forms.ToolStripLabel();
            this.infoButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.startSortingButton = new System.Windows.Forms.Button();
            this.showCodeButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.readOnlyTextBox1 = new Проектная_работа.ReadOnlyTextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButton,
            this.backButton,
            this.pageName,
            this.infoButton,
            this.forwardButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(907, 40);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuButton
            // 
            this.menuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(34, 37);
            this.menuButton.Text = "Меню";
            this.menuButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(34, 37);
            this.backButton.Text = "Назад";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pageName
            // 
            this.pageName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.pageName.Margin = new System.Windows.Forms.Padding(250, 1, 0, 2);
            this.pageName.Name = "pageName";
            this.pageName.Size = new System.Drawing.Size(198, 37);
            this.pageName.Text = "toolStripLabel1";
            // 
            // infoButton
            // 
            this.infoButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoButton.Name = "infoButton";
            this.infoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infoButton.Size = new System.Drawing.Size(34, 37);
            this.infoButton.Text = "Информация";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.forwardButton.Size = new System.Drawing.Size(34, 37);
            this.forwardButton.Text = "Вперед";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(100, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 487);
            this.toolStrip2.MinimumSize = new System.Drawing.Size(907, 50);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(907, 50);
            this.toolStrip2.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(775, 500);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(120, 40);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // startSortingButton
            // 
            this.startSortingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startSortingButton.Location = new System.Drawing.Point(300, 500);
            this.startSortingButton.Name = "startSortingButton";
            this.startSortingButton.Size = new System.Drawing.Size(220, 40);
            this.startSortingButton.TabIndex = 0;
            this.startSortingButton.Text = "Начать сортировку";
            this.startSortingButton.UseVisualStyleBackColor = true;
            this.startSortingButton.Visible = false;
            this.startSortingButton.Click += new System.EventHandler(this.startSortingButton_Click);
            // 
            // showCodeButton
            // 
            this.showCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showCodeButton.Location = new System.Drawing.Point(13, 500);
            this.showCodeButton.Name = "showCodeButton";
            this.showCodeButton.Size = new System.Drawing.Size(120, 40);
            this.showCodeButton.TabIndex = 14;
            this.showCodeButton.Text = "Показать код";
            this.showCodeButton.UseVisualStyleBackColor = true;
            this.showCodeButton.Visible = false;
            this.showCodeButton.Click += new System.EventHandler(this.showCodeButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri Light", 16.2F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(6, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(318, 35);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "2. Сортировка пузырьком";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri Light", 16.2F);
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(6, 88);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(309, 35);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "3. Сортировка вставками";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Calibri Light", 16.2F);
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(6, 118);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(267, 35);
            this.linkLabel3.TabIndex = 18;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "4. Сортировка Шелла";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 16.2F);
            this.groupBox1.Location = new System.Drawing.Point(13, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 163);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Содержание";
            this.groupBox1.Text = "Содержание";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(6, 28);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(184, 35);
            this.linkLabel4.TabIndex = 19;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "1. Сортировки";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readOnlyTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.readOnlyTextBox1.Location = new System.Drawing.Point(0, 40);
            this.readOnlyTextBox1.Margin = new System.Windows.Forms.Padding(15);
            this.readOnlyTextBox1.MinimumSize = new System.Drawing.Size(907, 447);
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(907, 447);
            this.readOnlyTextBox1.TabIndex = 15;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "";
            // 
            // Проект
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.showCodeButton);
            this.Controls.Add(this.startSortingButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(925, 584);
            this.Name = "Проект";
            this.Text = "Проектная работа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Проект_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton menuButton;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripLabel pageName;
        private System.Windows.Forms.ToolStripButton infoButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button startSortingButton;
        private System.Windows.Forms.Button showCodeButton;
        private ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}

