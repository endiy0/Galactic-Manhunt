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
            if (form.storage.Items.Count() != 0)
            {
                // 아이템 리스트 보여주기
                foreach (var item in form.storage.Items)
                {
                    dataGridView1.Rows.Add(item.GetItemName(), 0);
                }
            }

            if (form.storage.Abilities.Count() != 0)
            {
                // 능력 리스트 보여주기
                foreach (var ability in form.storage.Abilities)
                {
                    dataGridView2.Rows.Add(ability.Key, ability.Value); // TODO: 한글 이름 가져오기
                }
            }

            dataGridView1.ClearSelection(); // 셀이 선택되지 않도록
            dataGridView2.ClearSelection();
        }
    }
}