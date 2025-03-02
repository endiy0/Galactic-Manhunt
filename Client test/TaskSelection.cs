using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Client_test
{
    public partial class TaskSelection : Form
    {
        ChatClient form;
        public TaskSelection(ChatClient Form, bool isReservation) // isReservation: 현재 본인 턴 X = true, 현재 본인 턴 O = false
                                                                  // 본인 턴이 아니면 다음에 할 일 예약
        {
            InitializeComponent();
            form = Form;
            if (isReservation)
            {
                button1.Text = "예약";
            }
            else
            {
                button1.Text = "열기";
            }
        }

        private void button1_Click(object sender, EventArgs e) // 선택
        {
            int selectecIndex = listBox1.SelectedIndex;
            switch (selectecIndex)
            {
                case 0: // 함선 조종
                    ShipControl shipControl = new ShipControl(this, form);
                    shipControl.Show();
                    this.Close(); // 종료
                    break;

                case 1: // 농사
                    Farming farming = new Farming(this, form);
                    farming.Show();
                    this.Close(); // 종료
                    break;

                case 2: // 아이템 사용
                    ItemUse itemUse = new ItemUse(this, form);
                    itemUse.Show();
                    this.Close(); // 종료
                    break;

                case 3: // 아이템 합성
                    ItemSynthesis itemSynthesis = new ItemSynthesis(this, form);
                    itemSynthesis.Show();
                    this.Close(); // 종료
                    break;

                case 4: // 채집
                    Collection collecting = new Collection(this, form);
                    collecting.Show();
                    this.Close(); // 종료
                    break;

                case 5: // 상점
                    StoreClient store = new StoreClient(this, form);
                    store.Show();
                    this.Close(); // 종료
                    break;

                default:
                    label1.Text = "선택된 작업이 없습니다";
                    break;
            }
        }

        private void TaskSelection_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 누르면 선택
            {
                button1_Click(sender, e); // 선택 버튼
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // 엔터 누르면 선택
            {
                button1_Click(sender, e); // 선택 버튼
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // listBox1에 작업이 선택되면 "선택된 작업이 없습니다" 텍스트 삭제
        {
            label1.Text = "";
        }

        // TODO: 작업 선택 시 Enter로 실행 안되는 경우가 있음 => 오류 해결 필요
    }
}