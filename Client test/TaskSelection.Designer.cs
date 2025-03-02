namespace Client_test
{
    partial class TaskSelection
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
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("맑은 고딕", 11F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "함선 조종", "농사", "아이템 사용", "아이템 합성", "채집", "상점" });
            listBox1.Location = new Point(9, 9);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(272, 184);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(9, 222);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(272, 55);
            button1.TabIndex = 1;
            button1.Text = "선택";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("맑은 고딕", 9F);
            label1.Location = new Point(43, 195);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 2;
            label1.Text = "선택된 항목이 없습니다";
            // 
            // TaskSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 291);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Margin = new Padding(2);
            Name = "TaskSelection";
            Text = "할 일 선택창";
            KeyDown += TaskSelection_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
    }
}