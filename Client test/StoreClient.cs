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
        ChatClient chatClient;
        public StoreClient(TaskSelection form, ChatClient chatClient)
        {
            InitializeComponent();
            this.form = form;
            this.chatClient = chatClient;

            // 아이템 목록
            dataGridView1.Rows.Add("수소", 400, 0);
            dataGridView1.Rows.Add("질소", 120, 0);
            dataGridView1.Rows.Add("산소", 100, 0);
            dataGridView1.Rows.Add("엑실론-크리스탈", 1000, 0);
            dataGridView1.Rows.Add("퍼옥사이드", 0, 0);
            dataGridView1.Rows.Add("하이드라진", 0, 0);
            dataGridView1.Rows.Add("엑실론", 0, 0);
            dataGridView1.Rows.Add("물", 100, 0);
            dataGridView1.Rows.Add("식량", 600, 0);
            dataGridView1.Rows.Add("씨앗", 400, 0);

            // 역할에 따라 능력 목록 다르게
            // 경찰 능력 목록
            dataGridView2.Rows.Add("등잔 밑이 어둡다", 10000, 0);
            dataGridView2.Rows.Add("은하 탐방", 50000, 0);
            dataGridView2.Rows.Add("행성 탐방", 12000, 0);
            //dataGridView2.Rows.Add("스턴", "∞"); // 스턴은 기본 스킬로 개수 제한 없이 사용할 수 있음
            dataGridView2.Rows.Add("수갑", 2000, 0);
            dataGridView2.Rows.Add("팀 식별", 2000, 0);
            dataGridView2.Rows.Add("저장량 증가", 16000, 0);

            //// 도둑 능력 목록
            //dataGridView2.Rows.Add("겟 퓨얼", 5000, 0);
            //dataGridView2.Rows.Add("연료 교환권", 5000, 0);
            //dataGridView2.Rows.Add("연료 압축기", 10000, 0);
            //dataGridView2.Rows.Add("스턴 제거기", 5000, 0);
            //dataGridView2.Rows.Add("저장량 증가", 16000, 0);
        }

        private void StoreClient_FormClosing(object sender, FormClosingEventArgs e)
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

        // TODO: 상점 구현
        // 한번에 여러개 상품 선택가능하므로 여러개 한번에 구매할 수 있도록 구현해주세요
        // TODO: Enter 누르면 구매, 구매 전 구매하시겠습니까? 확인창
        // TODO: 구매할 때 구매할 질량 입력
        // TODO: 선택 안되어 있으면 구매버튼 비활성화, Enter 눌러도 안되도록
    }
}
