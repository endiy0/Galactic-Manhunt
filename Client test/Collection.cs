﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_test
{
    public partial class Collection : Form
    {
        TaskSelection form;
        ChatClient chatClient;
        public Collection(TaskSelection form, ChatClient chatClient)
        {
            InitializeComponent();
            this.form = form;
            this.chatClient = chatClient;
        }

        private void Collection_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: TaskSelection 본인 턴 확인 후 실행
            //if (본인 턴)
            //{
                  TaskSelection taskSelection = new TaskSelection(chatClient, false);
                  taskSelection.Show();
            //}
            //else
            //{
            //    TaskSelection taskSelection = new TaskSelection(chatClient, true);
            //    taskSelection.Show();
            //}
        }

        // TODO: 채집 구현
        // TODO: Enter 누르면 선택

    }
}