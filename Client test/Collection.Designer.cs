namespace Client_test
{
    partial class Collection
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
            listBox1 = new ListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(6, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 479);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 547);
            button1.Name = "button1";
            button1.Size = new Size(274, 55);
            button1.TabIndex = 1;
            button1.Text = "선택";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 530);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "행성";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox2);
            groupBox2.Location = new Point(292, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(274, 591);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "자원";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(6, 45);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(262, 529);
            listBox2.TabIndex = 0;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(652, 55);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(256, 529);
            listBox3.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("맑은 고딕", 17F);
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(572, 258);
            button3.Name = "button3";
            button3.Size = new Size(74, 54);
            button3.TabIndex = 9;
            button3.Text = "🠖";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("맑은 고딕", 17F);
            button4.ImageAlign = ContentAlignment.TopLeft;
            button4.Location = new Point(572, 332);
            button4.Name = "button4";
            button4.Size = new Size(74, 54);
            button4.TabIndex = 10;
            button4.Text = "🠔";
            button4.UseVisualStyleBackColor = false;
            // 
            // Collection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 614);
            Controls.Add(button4);
            Controls.Add(listBox3);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Collection";
            Text = "채집";
            FormClosing += Collection_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button3;
        private Button button4;
    }
}