namespace Client_test
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
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "함선 조종", "농사", "아이템 사용", "아이템 합성", "채집", "상점 방문" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(580, 708);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 726);
            button1.Name = "button1";
            button1.Size = new Size(580, 46);
            button1.TabIndex = 1;
            button1.Text = "결정";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 778);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "할 일 선택창:";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
    }
}