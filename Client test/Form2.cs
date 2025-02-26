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
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 Form, string title, bool isreservation)
        {
            InitializeComponent();
            form = Form;
            this.Text = title;
            if (isreservation) button1.Text = "예약";
            else button1.Text = "결정";
        }
    }
}
