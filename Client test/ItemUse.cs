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
        }

        // TODO: 아아템 사용 구현
        // TODO: Enter 누르면 아이템 사용, 사용 시 확인칭으로 사용 확인
        // TODO: 선택 된 아이템 없으면 사용 버튼 비활성화
    }
}
