namespace Client_test
{
    partial class ItemSynthesis
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
            dataGridView1 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Mass = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item, Mass });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(303, 221);
            dataGridView1.TabIndex = 2;
            // 
            // Item
            // 
            Item.HeaderText = "보유 자원";
            Item.MinimumWidth = 8;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 150;
            // 
            // Mass
            // 
            Mass.HeaderText = "질량(kg)";
            Mass.MinimumWidth = 8;
            Mass.Name = "Mass";
            Mass.ReadOnly = true;
            Mass.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 359);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "합성 선택";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(3, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 279);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 315);
            button1.Name = "button1";
            button1.Size = new Size(297, 34);
            button1.TabIndex = 4;
            button1.Text = "선택";
            button1.UseVisualStyleBackColor = true;
            // 
            // ItemSynthesis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 607);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ItemSynthesis";
            Text = "아이템 합성";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Mass;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
    }
}