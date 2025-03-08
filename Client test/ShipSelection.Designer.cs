namespace Client_test
{
    partial class ShipSelection
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("맑은 고딕", 10F);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "보유 함선";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "초급자용 함선", "자원 함선", "선원 함선", "초은하 이동 함선", "도적 함선" });
            listBox1.Location = new Point(6, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 144);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(13, 257);
            button1.Name = "button1";
            button1.Size = new Size(263, 57);
            button1.TabIndex = 1;
            button1.Text = "선택";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 10F);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 2;
            label1.Text = "현재 함선: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("맑은 고딕", 9F);
            label2.Location = new Point(43, 229);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 3;
            label2.Text = "선택된 함선이 없습니다";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 12);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 4;
            label3.Text = "함선 설명: ";
            // 
            // ShipSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 326);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ShipSelection";
            Text = "함선 선택";
            KeyDown += ShipSelection_KeyDown;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}