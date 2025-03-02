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
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(12, 228);
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 2;
            label1.Text = "현재 함선: ";
            // 
            // ShipSelection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 303);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
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
    }
}