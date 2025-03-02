namespace Client_test
{
    partial class StoreClient
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(13, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(498, 365);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "아이템";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column1.Width = 165;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.HeaderText = "1kg 당 가격(Cr)";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.Width = 165;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle2;
            Column3.HeaderText = "남은 양(kg)";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 165;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 10F);
            button1.Location = new Point(13, 425);
            button1.Name = "button1";
            button1.Size = new Size(499, 55);
            button1.TabIndex = 1;
            button1.Text = "구매";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 10F);
            button2.Location = new Point(517, 425);
            button2.Name = "button2";
            button2.Size = new Size(498, 55);
            button2.TabIndex = 3;
            button2.Text = "구매";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 36);
            label1.TabIndex = 4;
            label1.Text = "보유 화폐 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 13F);
            label2.Location = new Point(152, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 36);
            label2.TabIndex = 5;
            label2.Text = "(금액) Cr";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, Column4 });
            dataGridView2.Location = new Point(517, 54);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(498, 365);
            dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn1.HeaderText = "능력";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn1.Width = 165;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn3.HeaderText = "가격(Cr)";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn3.Width = 165;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            Column4.DefaultCellStyle = dataGridViewCellStyle5;
            Column4.HeaderText = "남은 양(개)";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 165;
            // 
            // StoreClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 495);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "StoreClient";
            Text = "상점";
            FormClosing += StoreClient_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}