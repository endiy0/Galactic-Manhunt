namespace Client_test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            listBox2 = new ListBox();
            label4 = new Label();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button5 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 76);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(688, 644);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(912, 43);
            button1.Name = "button1";
            button1.Size = new Size(200, 46);
            button1.TabIndex = 1;
            button1.Text = "연결";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(912, 120);
            button2.Name = "button2";
            button2.Size = new Size(200, 46);
            button2.TabIndex = 2;
            button2.Text = "연결 해제";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 736);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 39);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(706, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 4;
            label1.Text = "IP주소";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(706, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(706, 89);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 6;
            label2.Text = "포트";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(706, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(550, 729);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "전송";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(706, 166);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 9;
            label3.Text = "닉네임";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(706, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox2);
            groupBox1.Location = new Point(706, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 465);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "선원";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(6, 38);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(394, 420);
            listBox2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(67, 64);
            label4.TabIndex = 12;
            label4.Text = "직업:\r\n함선:\r\n";
            // 
            // button4
            // 
            button4.Location = new Point(706, 721);
            button4.Name = "button4";
            button4.Size = new Size(200, 54);
            button4.TabIndex = 13;
            button4.Text = "할 일 선택";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "전체", "팀" });
            comboBox1.Location = new Point(12, 735);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 40);
            comboBox1.TabIndex = 14;
            // 
            // button5
            // 
            button5.Location = new Point(912, 721);
            button5.Name = "button5";
            button5.Size = new Size(200, 54);
            button5.TabIndex = 15;
            button5.Text = "저장고 확인";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 787);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Chat Client";
            FormClosing += Form1_FormClosing;
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button3;
        private Label label3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private ListBox listBox2;
        private Label label4;
        private Button button4;
        private ComboBox comboBox1;
        private Button button5;
    }
}
