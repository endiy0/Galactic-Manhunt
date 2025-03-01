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
        }

        // TODO: 상점 구현
        // TODO: Enter 누르면 구매, 구매 전 구매하시겠습니까? 확인창

    }
}
