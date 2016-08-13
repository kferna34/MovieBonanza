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
        public SelectionForm listInfo { get; set; }
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
            SelectionForm NavToSelection = new SelectionForm();//sends the user back to the selction menu
            NavToSelection.Show();
            this.Hide();
        }

        private void backButtonAtOrderForm_Click(object sender, EventArgs e)
        {

            SelectionForm NavToSelection = new SelectionForm(); //sends the user back to the selection menu
            NavToSelection.Show();
            this.Hide();
        }

        private void StreamButtonAtOrderForm_Click(object sender, EventArgs e)
        {
            StreamForm NavToStream = new StreamForm();//sends the user to the stream form 
            NavToStream.Show();
            this.Hide();

        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        public void TitleTextBoxAtOF_TextChanged(object sender, EventArgs e)
        {
            this.listInfo.Show();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryTextBoxAtOF_TextChanged(object sender, EventArgs e)
        {
            //this sets of codes basically checks the category box, then inputs the specific amount in the cost textbox and the sales tax 
            

            if(CategoryTextBox.Text == "Drama")
            {
                this.SubTotalTxtBx.Text = "$1.99";          
                this.SalesTaxTextBx.Text = string.Format($"{1.99*0.13:C}").ToString();     
            }
            else if( CategoryTextBox.Text == "Comedy")
            {
                this.SubTotalTxtBx.Text = "$1.99";
                this.SalesTaxTextBx.Text = string.Format($"{1.99 * 0.13:C}").ToString();

            }
            else if (CategoryTextBox.Text == "Action")
            {
                this.SubTotalTxtBx.Text = "$2.99";
                this.SalesTaxTextBx.Text = string.Format($"{2.99 * 0.13:C}").ToString();
            }
            else if (CategoryTextBox.Text == "Sci-Fi")
            {
                this.SubTotalTxtBx.Text = "$2.99";
                this.SalesTaxTextBx.Text = string.Format($"{2.99 * 0.13:C}").ToString();
            }
            else if (CategoryTextBox.Text == "Horror")
            {
                this.SubTotalTxtBx.Text = "$2.99";
                this.SalesTaxTextBx.Text = string.Format($"{2.99 * 0.13:C}").ToString();
            }
            else if (CategoryTextBox.Text == "Thriller")
            {
                this.SubTotalTxtBx.Text = "$1.99";
                this.SalesTaxTextBx.Text = string.Format($"{1.99 * 0.13:C}").ToString();
            }
            else if (CategoryTextBox.Text == "Family")
            {
                this.SubTotalTxtBx.Text = "$0.99";
                this.SalesTaxTextBx.Text = string.Format($"{0.99 * 0.13:C}").ToString();
            }
            else if (CategoryTextBox.Text == "New Release")
            {
                this.SubTotalTxtBx.Text = "$4.99";
                this.SalesTaxTextBx.Text = string.Format($"{4.99 * 0.13:C}").ToString();
            }

        }

        private void SubTotalTxtBx_TextChanged(object sender, EventArgs e)
        {
            
            //double cost = Convert.ToDouble(costTextBox.Text);
            //double subTotal = Convert.ToDouble(SubTotalTxtBx.Text);
            //double grandTotal = Convert.ToDouble(GrandTotalTxtBx.Text);
            //double taxAmount = Convert.ToDouble(SalesTaxTextBx);

            //double baseCost = (cost * 1);

            //SubTotalTxtBx.Text = Convert.ToString("" + cost);
            //SalesTaxTextBx.Text = Convert.ToString(baseCost * 0.13);

            //if (OrderDVDCkBx.Checked == true)
            //{
            //    grandTotal = baseCost * 1.13 + 10;
            //    this.GrandTotalTxtBx.Text = Convert.ToString("" + baseCost * 1.13 + 10);
            //}
            //else
            //{
            //    grandTotal = baseCost * 1.13;
            //    this.GrandTotalTxtBx.Text = Convert.ToString("" + baseCost * 1.13);
            //}

            //this.SubTotalTxtBx.Text = Convert.ToString("" + cost);
            //this.SalesTaxTextBx.Text = Convert.ToString("" + baseCost * 0.13);


        }

        private void GrandTotalTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalesTaxTextBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
