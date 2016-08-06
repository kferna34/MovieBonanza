using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/*
 * Author: Krytia Fernandez
 * Date Last Modified : August 06 2016
 * version: 0.0.0.1
 */
namespace MovieBonanza
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            Thread LogoScreen = new Thread(new ThreadStart(SplashStart));
            LogoScreen.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            LogoScreen.Abort();
        }
        public void SplashStart()
        {
            Application.Run(new splashForm());
        }
        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nextButtonAtSelectionForm_Click(object sender, EventArgs e)
        {

           
                nextButtonAtSelectionForm.Visible = true;
                OrderForm NavToOrder = new OrderForm();
                NavToOrder.Show();
            }
        

        public void MovieDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MovieDropdownList.SelectedItem.ToString();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MovieDropdownList.SelectedItem.ToString();
        }
    }
}
