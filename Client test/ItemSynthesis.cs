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
        public ItemSynthesis(TaskSelection form)
        {
            InitializeComponent();
            this.form = form;
        }

        // TODO: 아이템 합성 구현
        // TODO: Enter 누르면 아이템 합성, 합성 시 확인창으로 합성 확인
        // TODO: 선택 된 아이템 없으면 합성 버튼 비활성화
        // TODO: 선택한 아이템, 개수가 보유 자원으로 합성 불가능하면 합성 버튼 비활성화
        // TODO: 아이템 개수 입력 시 필요 자원 띄워주기

    }
}