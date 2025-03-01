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
        {
            InitializeComponent();
            form = Form;
            if (isReservation)
            {
                button1.Text = "예약";
            }
            else
            {
                button1.Text = "결정";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectecIndex = listBox1.SelectedIndex;
            switch(selectecIndex)
            {
                case -1:
                    MessageBox.Show("선택된 항목이 없습니다.");
                    break;
                case 0:
                    ShipControl shipControl = new ShipControl(this);
                    shipControl.Show();
                    break;
                case 1:
                    Farming farming = new Farming(this);
                    farming.Show();
                    break;
                case 2:
                    ItemUse itemUse = new ItemUse(this);
                    itemUse.Show();
                    break;
                case 3:
                    ItemSynthesis itemSynthesis = new ItemSynthesis(this);
                    itemSynthesis.Show();
                    break;
                case 4:
                    Collection collecting = new Collection(this);
                    collecting.Show();
                    break;
                case 5:
                    Store store = new Store(this);
                    store.Show();
                    break;
                default:
                    break;
            }
        }
    }
}