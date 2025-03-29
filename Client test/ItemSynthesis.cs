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
        ChatClient chatClient;
        private double hydrogen1 = 0;
        private double hydrogen2 = 0;
        private double nitrogen = 0;
        private double oxygen = 0;
        private double epsilonCrystal = 0;

        public ItemSynthesis(TaskSelection form, ChatClient chatClient)
        {
            InitializeComponent();
            this.form = form;
            this.chatClient = chatClient;
        }

        private void ItemSynthesis_Load(object sender, EventArgs e)
        {
            // 보유 자원 목록
            dataGridView1.Rows.Add("수소", 0);
            dataGridView1.Rows.Add("질소", 0);
            dataGridView1.Rows.Add("산소", 0);
            dataGridView1.Rows.Add("엑실론-크리스탈", 0);

            // 아이템 목록, 질량비
            dataGridView3.Rows.Add("퍼옥사이드", "수소 : 산소 = 1 : 8");
            dataGridView3.Rows.Add("하이드라진", "수소 : 질소 = 1 : 7");
            if (chatClient.ship == ShipType.galaxyTravelingShip)
            {
                dataGridView3.Rows.Add("엑실론", "엑실론-크리스탈 3");
            }
            else
            {
                dataGridView3.Rows.Add("엑실론", "엑실론-크리스탈 2");
            }

            // 필요 자원 목록
            dataGridView2.Rows.Add("수소", 0);
            dataGridView2.Rows.Add("질소", 0);
            dataGridView2.Rows.Add("산소", 0);
            dataGridView2.Rows.Add("엑실론-크리스탈", 0);

            dataGridView1.ClearSelection(); // 셀이 선택되지 않도록
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e) // 합성
        {

        }

        private void ItemSynthesis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 누르면 합성
            {
                button1.PerformClick(); // 합성
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // 퍼옥사이드
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            double mass = Convert.ToDouble(textBox1.Text);
            hydrogen1 = mass;
            oxygen = mass * 8; // 수소 : 산소 = 1 : 8 로 퍼옥사이드 1 합성
            dataGridView2.Rows[0].Cells[1].Value = hydrogen1 + hydrogen2; // 수소 양
            dataGridView2.Rows[2].Cells[1].Value = oxygen;   // 산소 양
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // 하이드라진
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            double mass = Convert.ToDouble(textBox2.Text);
            hydrogen2 = mass;
            nitrogen = mass * 7; // 수소 : 질소 = 1 : 7 로 하이드라진 1 합성
            dataGridView2.Rows[0].Cells[1].Value = hydrogen1 + hydrogen2; // 수소 양
            dataGridView2.Rows[1].Cells[1].Value = nitrogen; // 질소 양
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // 엑실론
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            double mass = Convert.ToDouble(textBox3.Text);
            if (chatClient.ship == ShipType.galaxyTravelingShip)
            {
                epsilonCrystal = mass * 3; // 엑실론-크리스탈 3로 엑실론 1 합성
            }
            else
            {
                epsilonCrystal = mass * 2; // 엑실론-크리스탈 2로 엑실론 1 합성
            }
            dataGridView2.Rows[3].Cells[1].Value = epsilonCrystal; // 엑실론-크리스탈 양
        }

        private void ItemSynthesis_FormClosing(object sender, FormClosingEventArgs e) // 종료
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

        // TODO: 아이템 합성 구현
        // TODO: Enter 누르면 아이템 합성, 합성 시 확인창으로 합성 확인
        // TODO: 선택한 아이템, 개수가 보유 자원으로 합성 불가능하면 합성 버튼 비활성화
        // TODO: 모든 입력값이 0일 때 합성 버튼 비활성화
        // TODO: 아이템 개수 입력 시 필요 자원 띄워주기
    }
}