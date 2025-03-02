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
    public partial class ItemSynthesis : Form
    {
        TaskSelection form;
        public ItemSynthesis(TaskSelection form)
        {
            InitializeComponent();
            this.form = form;

            // 보유 자원 목록
            dataGridView1.Rows.Add("수소", 0);
            dataGridView1.Rows.Add("질소", 0);
            dataGridView1.Rows.Add("산소", 0);
            dataGridView1.Rows.Add("엑실론-크리스탈", 0);

            // 아이템 목록, 질량비
            dataGridView3.Rows.Add("퍼옥사이드", "수소 : 산소 = 1 : 8");
            dataGridView3.Rows.Add("하이드라진", "수소 : 질소 = 1 : 7");
            dataGridView3.Rows.Add("엑실론", "엑실론-크리스탈");
        }

        // TODO: 아이템 합성 구현
        // TODO: Enter 누르면 아이템 합성, 합성 시 확인창으로 합성 확인
        // TODO: 선택 된 아이템 없으면 합성 버튼 비활성화
        // TODO: 선택한 아이템, 개수가 보유 자원으로 합성 불가능하면 합성 버튼 비활성화
        // TODO: 아이템 개수 입력 시 필요 자원 띄워주기

    }
}