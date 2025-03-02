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
    public partial class ItemUse : Form
    {
        TaskSelection form;
        public ItemUse(TaskSelection form)
        {
            InitializeComponent();
            this.form = form;

            // 경찰인지 도둑인지에 따라 능력 목록 다르게
            // 경찰 능력 목록
            dataGridView2.Rows.Add("등잔 밑이 어둡다", "0");
            dataGridView2.Rows.Add("은하 탐방", "0");
            dataGridView2.Rows.Add("행성 탐방", "0");
            dataGridView2.Rows.Add("스턴", "0");
            dataGridView2.Rows.Add("수갑", "0");
            dataGridView2.Rows.Add("팀 식별", "0");
            dataGridView2.Rows.Add("저장량 증가", "0");

            //// 도둑 능력 목록
            //dataGridView2.Rows.Add("겟 퓨얼", "0");
            //dataGridView2.Rows.Add("연료 교환권", "0");
            //dataGridView2.Rows.Add("연료 압축기", "0");
            //dataGridView2.Rows.Add("스턴 제거기", "0");
            //dataGridView2.Rows.Add("저장량 증가", "0");
        }

        // TODO: 아아템 사용 구현
        // TODO: Enter 누르면 아이템 사용, 사용 시 확인칭으로 사용 확인
        // TODO: 선택 된 아이템 없으면 사용 버튼 비활성화
    }
}
