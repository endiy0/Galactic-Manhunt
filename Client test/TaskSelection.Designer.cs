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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "함선 조종", "농사", "아이템 사용", "아이템 합성", "채집", "상점 방문" });
            listBox1.Location = new Point(9, 9);
            listBox1.Margin = new Padding(2, 2, 2, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(447, 554);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(9, 567);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(446, 36);
            button1.TabIndex = 1;
            button1.Text = "결정";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TaskSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 608);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TaskSelection";
            Text = "할 일 선택창:";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
    }
}