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
    public partial class ShipSelection : Form
    {
        ChatClient form;
        public ShipSelection(ChatClient form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e) // 선택
        {
            //Invoke(new Action(() => { form.ship = (ShipType)listBox1.SelectedIndex; })); // 선택된 함선을 form.ship에 저장
            form.ship = (ShipType)listBox1.SelectedIndex;
            label2.Text = listBox1.SelectedItem.ToString() + " 선택됨";
            var answer = MessageBox.Show(listBox1.SelectedItem.ToString() + "이 선택되었습니다.\n결정하시겠습니까?", "알림", MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
            {
                label2.Text = "";
                return;
            }
            else
            {
                form.GetShip(); // 선택된 함선을 서버로 전송
                this.Close(); // 종료
            }
        }

        private void ShipSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 누르면 선택
            {
                button1.PerformClick();
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 누르면 선택
            {
                button1.PerformClick();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // listBox1에 함선이 선택되면 "선택된 함선이 없습니다" 텍스트 삭제
        {
            label2.Text = "";
            button1.Enabled = true; // 리스트에 항목이 선택되면 버튼 활성화
            int selectedIndex = listBox1.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    label1.Text = "현재 함선: 초급자용 함선";
                    label3.Text = "함선 설명:\n\n시작할 때 기본 아이템과\n\n자원이 지원됩니다.";
                    break;
                case 1:
                    label1.Text = "현재 함선: 자원 함선";
                    label3.Text = "함선 설명:\n\n턴마다 자신이 원하는\n\n자원을 선택할 수 있습니다.\n\n단, 연료 제작에 필요한\n\n자원이 증가합니다.";
                    break;
                case 2:
                    label1.Text = "현재 함선: 선원 함선";
                    label3.Text = "함선 설명:\n\n선원이 3명 지급됩니다.\n\n첫 20턴 동안은 매번\n\n식량 3kg, 물 2kg이\n\n지급됩니다.";
                    break;
                case 3:
                    label1.Text = "현재 함선: 초은하 이동 함선";
                    label3.Text = "함선 설명:\n\n은하 이동을 3번\n\n무료로 사용할 수 있습니다.\n\n단, 엑실론 제작시\n\n엑실론-크리스탈이\n\n1.5배 많이 필요합니다.";
                    break;
                case 4:
                    label1.Text = "현재 함선: 도적 함선";
                    label3.Text = "함선 설명:\n\n같은 은하 내 다른 함선의\n\n연료를 빼앗을 수 있습니다.\n\n단, 20%의 확률로 3턴 동안\n\n이동 불가 상태가 됩니다.";
                    break;
                default:
                    label1.Text = "선택된 함선이 없습니다";
                    label3.Text = "함선 설명: ";
                    button1.Enabled = false; // 선택 안되면 버튼 비활성화
                    break;
            }
        }
    }
}