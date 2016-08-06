using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hiddenTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDVDCkBx_CheckedChanged(object sender, EventArgs e)
        {
            if(OrderDVDCkBx.Checked == true)
            {
                hiddenLabel.Visible = true;
                hiddenTxtBx.Visible = true;
            }
        }
    }
}
