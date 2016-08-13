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
        public OrderForm listInfo { get; set; }
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {

        }     
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreditCardCharged_Click(object sender, EventArgs e)
        {
            listInfo.Show();
        }

        private void streamingMessage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
