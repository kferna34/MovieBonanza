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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {

        }

        private void movieStartsLabel_Click(object sender, EventArgs e)
        {
            
            movieStartsLabel.Text = "{0} will begin streaming shortly";
        }

        private void creditcardBilledLabel_Click(object sender, EventArgs e)
        {
            creditcardBilledLabel.Text = "";
            creditcardBilledLabel.Text=("Your Credit card will be charged {0}");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
