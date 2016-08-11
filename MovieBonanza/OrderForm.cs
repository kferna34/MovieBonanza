﻿using System;
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
        public OrderForm TitleBoxCopy { get; set; }
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
            if (OrderDVDCkBx.Checked == true)
            {
                hiddenLabel.Visible = true;
                hiddenTxtBx.Visible = true;
            }
            else
            {
                hiddenLabel.Visible = false;
                hiddenTxtBx.Visible = false;
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
        private void OrderForm_Load(object sender, EventArgs e)
        {
            
        }

        public void TitleTextBoxAtOF_TextChanged(object sender, EventArgs e)
        {
            this.TitleTextBox.Show();
        }

        private void OrderGroupBoxAtOrderForm_Enter(object sender, EventArgs e)
        {

        }

        public static implicit operator OrderForm(SelectionForm v)
        {
            throw new NotImplementedException();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxMe aboutBox = new AboutBoxMe();

            // show dialog 
            aboutBox.ShowDialog();
        }
    }
}
