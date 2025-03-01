﻿namespace Client_test
{
    partial class Storage
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            Item = new DataGridViewTextBoxColumn();
            Mass = new DataGridViewTextBoxColumn();
            Abilities = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            dataGridView1.Size = new Size(503, 538);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Abilities, Number });
            dataGridView2.Location = new Point(521, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(503, 538);
            dataGridView2.TabIndex = 2;
            // 
            // Item
            // 
            Item.HeaderText = "아이템";
            Item.MinimumWidth = 8;
            Item.Name = "Item";
            Item.ReadOnly = true;
            Item.Width = 250;
            // 
            // Mass
            // 
            Mass.HeaderText = "질량";
            Mass.MinimumWidth = 8;
            Mass.Name = "Mass";
            Mass.ReadOnly = true;
            Mass.Width = 250;
            // 
            // Abilities
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Abilities.DefaultCellStyle = dataGridViewCellStyle1;
            Abilities.HeaderText = "능력";
            Abilities.MinimumWidth = 8;
            Abilities.Name = "Abilities";
            Abilities.ReadOnly = true;
            Abilities.Width = 250;
            // 
            // Number
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Number.DefaultCellStyle = dataGridViewCellStyle2;
            Number.HeaderText = "개수";
            Number.MinimumWidth = 8;
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Width = 250;
            // 
            // Storage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 562);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Storage";
            Text = "저장고";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Item;
        private DataGridViewTextBoxColumn Mass;
        private DataGridViewTextBoxColumn Abilities;
        private DataGridViewTextBoxColumn Number;
    }
}