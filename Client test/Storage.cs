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
    public partial class Storage : Form
    {
        ChatClient form;
        public Storage(ChatClient form)
        {
            InitializeComponent();
            this.form = form;
        }
    }
}