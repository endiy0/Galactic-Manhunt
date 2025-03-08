using System;
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
    public partial class Storage : Form
    {
        ChatClient form;
        public Storage(ChatClient form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            // TODO: 보유 자원 보여주기 추가

            dataGridView1.ClearSelection(); // 셀이 선택되지 않도록
            dataGridView2.ClearSelection();
        }
    }
}