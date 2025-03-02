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
        public ShipSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 선택
        {
            MessageBox.Show("선택 완료");
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
    }
}
