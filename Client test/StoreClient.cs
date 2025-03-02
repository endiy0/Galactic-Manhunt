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
    public partial class StoreClient : Form
    {
        TaskSelection form;
        public StoreClient(TaskSelection form)
        {
            InitializeComponent();
            this.form = form;

            // 아이템 목록
            dataGridView1.Rows.Add("수소", 400);
            dataGridView1.Rows.Add("질소", 120);
            dataGridView1.Rows.Add("산소", 100);
            dataGridView1.Rows.Add("엑실론-크리스탈", 1000);
            dataGridView1.Rows.Add("퍼옥사이드", 0);
            dataGridView1.Rows.Add("하이드라진", 0);
            dataGridView1.Rows.Add("엑실론", 0);
            dataGridView1.Rows.Add("물", 100);
            dataGridView1.Rows.Add("식량", 600);
            dataGridView1.Rows.Add("씨앗", 400);

            // 역할에 따라 능력 목록 다르게
            // 경찰 능력 목록
            dataGridView2.Rows.Add("등잔 밑이 어둡다", 10000);
            dataGridView2.Rows.Add("은하 탐방", 50000);
            dataGridView2.Rows.Add("행성 탐방", 12000);
            //dataGridView2.Rows.Add("스턴", "0");
            dataGridView2.Rows.Add("수갑", 2000);
            dataGridView2.Rows.Add("팀 식별", 2000);
            dataGridView2.Rows.Add("저장량 증가", 16000);

            //// 도둑 능력 목록
            //dataGridView2.Rows.Add("겟 퓨얼", 5000);
            //dataGridView2.Rows.Add("연료 교환권", 5000);
            //dataGridView2.Rows.Add("연료 압축기", 10000);
            //dataGridView2.Rows.Add("스턴 제거기", 5000);
            //dataGridView2.Rows.Add("저장량 증가", 16000);
        }

        // TODO: 상점 구현
        // TODO: Enter 누르면 구매, 구매 전 구매하시겠습니까? 확인창
        // TODO: 구매할 때 구매할 질량 입력

    }
}
