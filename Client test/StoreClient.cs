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

        // textBox에 입력한 값에 가격을 곱한 값을 Value에 저장
        // Value의 총합 = 지불해야 할 크로노 총합

        // 아이템 양에 따른 크로노 양
        private Dictionary<string, double> itemPrice
            = new Dictionary<string, double>
            {
                { "hydrogen", 0 },
                { "nitrogen", 0 },
                { "oxygen", 0 },
                { "epsilonCrystal", 0 },
                { "peroxide", 0 },
                { "hydrazine", 0 },
                { "epsilon", 0 },
                { "water", 0 },
                { "food", 0 },
                { "seed", 0 }
            };

        // 경찰 능력에 따른 크로노 양
        private Dictionary<string, int> copAbilityPrice
            = new Dictionary<string, int>
            {
                { "darkUnderTheLamp", 0 },
                { "galaxyTravel", 0 },
                { "planetTravel", 0 },
                { "handcuff", 0 },
                { "teamIdentify", 0 },
                { "storageGrowth", 0 }
            };

        // 도둑 능력에 따른 크로노 양
        private Dictionary<string, int> thiefAbilityPrice
            = new Dictionary<string, int>
            {
                { "getFuel", 0 },
                { "fuelChanger", 0 },
                { "fuelCompressor", 0 },
                { "stunRemover", 0 },
                { "storageGrowth", 0 }
            };

        public StoreClient(TaskSelection form, ChatClient chatClient)
        {
            InitializeComponent();
            this.form = form;
            this.chatClient = chatClient;
        }

        private void StoreClient_Load(object sender, EventArgs e)
        {
            // 아이템 목록
            // 이름, 가격, 남은 양
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
            // 이름, 가격, 남은 양
            dataGridView2.Rows.Add("등잔 밑이 어둡다", 10000, 0);
            dataGridView2.Rows.Add("은하 탐방", 50000, 0);
            dataGridView2.Rows.Add("행성 탐방", 12000, 0);
            //dataGridView2.Rows.Add("스턴", "∞"); // 스턴은 기본 스킬로 개수 제한 없이 사용할 수 있음
            dataGridView2.Rows.Add("수갑", 2000, 0);
            dataGridView2.Rows.Add("팀 식별", 2000, 0);
            dataGridView2.Rows.Add("저장량 증가", 16000, 0);

            //// 도둑 능력 목록
            //// 이름, 가격, 남은 양
            //dataGridView2.Rows.Add("겟 퓨얼", 5000, 0);
            //dataGridView2.Rows.Add("연료 교환권", 5000, 0);
            //dataGridView2.Rows.Add("연료 압축기", 10000, 0);
            //dataGridView2.Rows.Add("스턴 제거기", 5000, 0);
            //dataGridView2.Rows.Add("저장량 증가", 16000, 0);

            dataGridView1.ClearSelection(); // 셀 선택 해제
            dataGridView2.ClearSelection();

            showTotalItemPrice(); // 초기 가격 0 표시
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

        // 아이템 가격 총합 표시
        private void showTotalItemPrice()
        {
            double totalPrice = 0;

            // 아이템 가격 총합
            foreach (var price in itemPrice)
            {
                totalPrice += price.Value;
            }
            label5.Text = "합계 금액: " + totalPrice + " Cr";
        }

        private void showTotalAbilityPrice()
        {
            double totalPrice = 0;

            //역할에 따라 가격 총합 다르게 계산
            // 경찰 능력 가격 총합
            foreach (var price in copAbilityPrice)
            {
                totalPrice += price.Value;
            }

            //// 도둑 능력 가격 총합
            //foreach (var price in thiefAbilityPrice)
            //{
            //    totalPrice += price.Value;
            //}

            label6.Text = "합계 금액: " + totalPrice + " Cr";
        }

        #region item_textBox_TextChanged
        private void textBox1_TextChanged(object sender, EventArgs e) // 수소
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            double mass = Convert.ToDouble(textBox1.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
            if (mass > maxinum) // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            }

            itemPrice["hydrogen"] = mass * 400;
            showTotalItemPrice();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // 질소
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            double mass = Convert.ToDouble(textBox2.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[1].Cells[2].Value);
            if (mass > maxinum) // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox2.Text = dataGridView1.Rows[1].Cells[2].Value.ToString();
            }

            itemPrice["nitrogen"] = mass * 120;
            showTotalItemPrice();
        }

        private void textBox4_TextChanged(object sender, EventArgs e) // 산소 
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            double mass = Convert.ToDouble(textBox4.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[2].Cells[2].Value);
            if (mass > maxinum) // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox4.Text = dataGridView1.Rows[2].Cells[2].Value.ToString();
            }

            itemPrice["oxygen"] = mass * 100;
            showTotalItemPrice();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // 엑실론-크리스탈
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            double mass = Convert.ToDouble(textBox3.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[3].Cells[2].Value);
            if (mass > maxinum) // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox3.Text = dataGridView1.Rows[3].Cells[2].Value.ToString();
            }

            itemPrice["epsilonCrystal"] = mass * 1000;
            showTotalItemPrice();
        }

        private void textBox8_TextChanged(object sender, EventArgs e) // 퍼옥사이드
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            double mass = Convert.ToDouble(textBox8.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[4].Cells[2].Value);
            if (mass > maxinum) // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox8.Text = dataGridView1.Rows[4].Cells[2].Value.ToString();
            }

            itemPrice["peroxide"] = mass * 0; // TODO: 가격 정하기
            showTotalItemPrice();
        }

        private void textBox7_TextChanged(object sender, EventArgs e) // 하이드라진
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            double mass = Convert.ToDouble(textBox7.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[5].Cells[2].Value);
            if (mass > maxinum) // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox7.Text = dataGridView1.Rows[5].Cells[2].Value.ToString();
            }

            itemPrice["hydrazine"] = mass * 0; // TODO: 가격 정하기
            showTotalItemPrice();
        }

        private void textBox6_TextChanged(object sender, EventArgs e) // 엑실론
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            double mass = Convert.ToDouble(textBox6.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[6].Cells[2].Value);
            if (mass > maxinum)  // mass가 maxinum보다 크면 maxinum을 mass로
            {
                mass = maxinum;
                textBox6.Text = dataGridView1.Rows[6].Cells[2].Value.ToString();
            }

            itemPrice["epsilon"] = mass * 0; // TODO: 가격 정하기
            showTotalItemPrice();
        }

        private void textBox5_TextChanged(object sender, EventArgs e) // 물
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            double mass = Convert.ToDouble(textBox5.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[7].Cells[2].Value);
            mass = Double.Min(mass, maxinum); // mass가 maxinum보다 크면 maxinum을 mass로

            itemPrice["water"] = mass * 100;
            showTotalItemPrice();
        }

        private void textBox10_TextChanged(object sender, EventArgs e) // 식량
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }
            double mass = Convert.ToDouble(textBox10.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[8].Cells[2].Value);
            mass = Double.Min(mass, maxinum); // mass가 maxinum보다 크면 maxinum을 mass로

            itemPrice["food"] = mass * 600;
            showTotalItemPrice();
        }

        private void textBox9_TextChanged(object sender, EventArgs e) // 씨앗
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            double mass = Convert.ToDouble(textBox9.Text);
            double maxinum = Convert.ToDouble(dataGridView1.Rows[9].Cells[2].Value);
            mass = Double.Min(mass, maxinum); // mass가 maxinum보다 크면 maxinum을 mass로

            itemPrice["seed"] = mass * 400;
            showTotalItemPrice();
        }
        #endregion

        #region ability_textBox_TextChanged
        // 아래는 모두 경찰 기준
        // 도둑은 역할을 받아오는 것을 구현하면 if문으로 구분하여 처리
        // 도둑 능력 처리할 때 편하라고 이름 주석은 함수 않으로 넣음

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "")
            {
                textBox20.Text = "0";
            }
            // 등잔 밑이 어둡다
            int num = Convert.ToInt32(textBox20.Text);
            int maxinum = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);
            num = Int32.Min(num, maxinum); // num이 maxinum보다 크면 maxinum을 num으로

            copAbilityPrice["darkUnderTheLamp"] = num * 10000;
            showTotalAbilityPrice();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                textBox19.Text = "0";
            }
            // 은하 탐방
            int num = Convert.ToInt32(textBox19.Text);
            int maxinum = Convert.ToInt32(dataGridView2.Rows[1].Cells[2].Value);
            num = Int32.Min(num, maxinum); // num이 maxinum보다 크면 maxinum을 num으로

            copAbilityPrice["galaxyTravel"] = num * 50000;
            showTotalAbilityPrice();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "")
            {
                textBox18.Text = "0";
            }
            // 행성 탐방
            int num = Convert.ToInt32(textBox18.Text);
            int maxinum = Convert.ToInt32(dataGridView2.Rows[2].Cells[2].Value);
            num = Int32.Min(num, maxinum); // num이 maxinum보다 크면 maxinum을 num으로

            copAbilityPrice["planetTravel"] = num * 12000;
            showTotalAbilityPrice();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                textBox17.Text = "0";
            }
            // 수갑
            int num = Convert.ToInt32(textBox17.Text);
            int maxinum = Convert.ToInt32(dataGridView2.Rows[3].Cells[2].Value);
            num = Int32.Min(num, maxinum); // num이 maxinum보다 크면 maxinum을 num으로

            copAbilityPrice["handcuff"] = num * 2000;
            showTotalAbilityPrice();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "0";
            }
            // 팀 식별
            int num = Convert.ToInt32(textBox16.Text);
            int maxinum = Convert.ToInt32(dataGridView2.Rows[4].Cells[2].Value);
            num = Int32.Min(num, maxinum); // num이 maxinum보다 크면 maxinum을 num으로

            copAbilityPrice["teamIdentify"] = num * 2000;
            showTotalAbilityPrice();
        }

        private void textBox15_TextChanged(object sender, EventArgs e) // 도둑은 능력이 5개이므로 도둑인 경우 visibility = false
        {
            if (textBox15.Text == "")
            {
                textBox15.Text = "0";
            }
            // 저장량 증가
            int num = Convert.ToInt32(textBox15.Text);
            int maxinum = Convert.ToInt32(dataGridView2.Rows[5].Cells[2].Value);
            num = Int32.Min(num, maxinum); // num이 maxinum보다 크면 maxinum을 num으로

            copAbilityPrice["storageGrowth"] = num * 16000;
            showTotalAbilityPrice();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e) // 아이템 구매
        {
            DialogResult = MessageBox.Show("아이템을 구매하시겠습니까?", "구매 확인", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                // 아이템 구매
                MessageBox.Show("구매 완료"); // 구매 완료를 표현하는 방법은 이거 말고 label로 표현해주세요
            }
        }

        #region itemKeyDown
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("능력을 구매하시겠습니까?", "구매 확인", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                // 아이템 구매
                MessageBox.Show("구매 완료"); // 구매 완료를 표현하는 방법은 이거 말고 label로 표현해주세요
            }
        }

        #region abilityKeyDown
        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }
        #endregion

        // TODO: 상점 구현
        // 한번에 여러개 상품 선택가능하므로 여러개 한번에 구매할 수 있도록 구현해주세요
        // TODO: 선택 안되어 있으면 구매버튼 비활성화, Enter 눌러도 안되도록
        // TODO: 
    }
}