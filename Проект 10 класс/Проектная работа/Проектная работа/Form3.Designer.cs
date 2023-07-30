namespace Проектная_работа
{
    partial class Form3
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.readOnlyTextBox1 = new Проектная_работа.ReadOnlyTextBox();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(100, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 363);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 37);
            this.toolStripLabel1.Text = "text";
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.readOnlyTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.readOnlyTextBox1.Location = new System.Drawing.Point(0, 0);
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(582, 363);
            this.readOnlyTextBox1.TabIndex = 2;
            this.readOnlyTextBox1.TabStop = false;
            this.readOnlyTextBox1.Text = "";
            // 
            // closeFormButton
            // 
            this.closeFormButton.Location = new System.Drawing.Point(166, 373);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(137, 35);
            this.closeFormButton.TabIndex = 3;
            this.closeFormButton.Text = "Закрыть";
            this.closeFormButton.UseVisualStyleBackColor = true;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.closeFormButton);
            this.Controls.Add(this.readOnlyTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private ReadOnlyTextBox readOnlyTextBox1;
        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}