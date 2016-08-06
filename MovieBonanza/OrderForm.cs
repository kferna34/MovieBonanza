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

        private void CancelbuttonAtOrderForm_Click(object sender, EventArgs e)
        {
            SelectionForm NavToSelection = new SelectionForm();
            NavToSelection.Show();
        }

        private void backButtonAtOrderForm_Click(object sender, EventArgs e)
        {
            SelectionForm NavToSelection = new SelectionForm();
            NavToSelection.Show();
        }

        private void StreamButtonAtOrderForm_Click(object sender, EventArgs e)
        {
            StreamForm NavToStream = new StreamForm();
            NavToStream.Show();
        }
    }
}
