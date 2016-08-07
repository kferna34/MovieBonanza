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
            switch (MovieDropdownList.SelectedIndex)
            {
                case 0:
                    CategoryTextBox.Text = "Comedy";
                    TitleTextBox.Text = "Ceday Rapids";

                    break;
                case 1:
                    CategoryTextBox.Text = "Drama";
                    TitleTextBox.Text = "Company Men";
                    break;
                case 2:
                    CategoryTextBox.Text = "Action";
                    TitleTextBox.Text = " Death Race 2";
                    break;
                case 3:
                    CategoryTextBox.Text = "New Release";
                    TitleTextBox.Text = "FootLoose";
                    break;
                case 4:
                    CategoryTextBox.Text = "Family";
                    TitleTextBox.Text = "Gnomeo and Juliet";
                    break;
                case 5:
                    CategoryTextBox.Text = "Sci-Fi";
                    TitleTextBox.Text = " I am Number Four";
                    break;
                case 6:
                    CategoryTextBox.Text = "Comedy";
                    TitleTextBox.Text = " Just Go With It";
                    break;
                case 7:
                    CategoryTextBox.Text = "Comedy";
                    TitleTextBox.Text = "No String Attached";
                    break;
                case 8:
                    CategoryTextBox.Text = "New Release";
                    TitleTextBox.Text = "Real Steel";
                    break;
                case 9:
                    CategoryTextBox.Text = "Action";
                    TitleTextBox.Text = "Sanctrum";
                    break;
                case 10:
                    CategoryTextBox.Text = "Sci-Fi";
                    TitleTextBox.Text = "Season of the Witch";
                    break;
                case 11:
                    CategoryTextBox.Text = "Comedy";
                    TitleTextBox.Text = "The Dilemma";
                    break;
                case 12:
                    CategoryTextBox.Text = "Action";
                    TitleTextBox.Text = "The Eagle";
                    break;
                case 13:
                    CategoryTextBox.Text = "Action";
                    TitleTextBox.Text = "The Green Hornet";
                    break;
                case 14:
                    CategoryTextBox.Text = "Action";
                    TitleTextBox.Text = "The Mechanic";
                    break;
                case 15:
                    CategoryTextBox.Text = "Action";
                    TitleTextBox.Text = "The Other Woman";
                    break;
                case 16:
                    CategoryTextBox.Text = "Horror";
                    TitleTextBox.Text = "The Rite";
                    break;
                case 17:
                    CategoryTextBox.Text = "Thriller";
                    TitleTextBox.Text = "The Roommate";
                    break;
                case 18:
                    CategoryTextBox.Text = "Drama";
                    TitleTextBox.Text = "The Way Back";
                    break;
                case 19:
                    CategoryTextBox.Text = "Drama";
                    TitleTextBox.Text = "Waiting for Forever";
                    break;
                
            }



        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MovieDropdownList.SelectedItem.ToString();
        }
    }
}
