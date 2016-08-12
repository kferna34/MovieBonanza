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
            //showing the logo
            Thread LogoScreen = new Thread(new ThreadStart(SplashStart));
            LogoScreen.Start();
            Thread.Sleep(4000);
            InitializeComponent();
            LogoScreen.Abort();// close the logo 

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
            //moves to the next form
            nextButtonAtSelectionForm.Enabled = true;//displays the NextButton

            OrderForm NavToOrder = new OrderForm();//instantiate an obj of the next form        

            NavToOrder.listInfo = this;

            NavToOrder.TitleTextBox.Text = this.TitleTextBox.Text;//passes the title to the order form  
            NavToOrder.CategoryTextBox.Text = this.CategoryTextBox.Text;//passes the category to the order form
            NavToOrder.costTextBox.Text = this.costTextBox.Text;//passes the cost to the order form
            NavToOrder.MoviePic.Image = this.pictureOfMovie.Image;
           

            NavToOrder.Show();
            this.Hide();
        }
        public void MovieDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (MovieDropdownList.SelectedIndex)
            {
                case 0:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Ceday Rapids";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = " $ 1.99 ";
                    pictureOfMovie.Image = Properties.Resources.cedarrapids;
                    break;
                case 1:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Company Men";
                    CategoryTextBox.Text = "Drama";
                    costTextBox.Text = " $ 1.99";
                    pictureOfMovie.Image = Properties.Resources.companymen;
                    break;
                case 2:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = " Death Race 2";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = " $ 2.99";
                    pictureOfMovie.Image = Properties.Resources.deathrace2;
                    break;
                case 3:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "FootLoose";
                    CategoryTextBox.Text = "New Release";
                    costTextBox.Text = " $ 4.99";
                    pictureOfMovie.Image = Properties.Resources.footloose;
                    break;
                case 4:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Gnomeo and Juliet";
                    CategoryTextBox.Text = "Family";
                    costTextBox.Text = "$ 0.99";
                    pictureOfMovie.Image = Properties.Resources.gnomeoandjuliet;
                    break;

                case 5:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = " I am Number Four";
                    CategoryTextBox.Text = "Sci-Fi";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.iamnumberfour;
                    break;

                case 6:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = " Just Go With It";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = "$ 1.99";
                    pictureOfMovie.Image = Properties.Resources.justgowithit;
                    break;

                case 7:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "No String Attached";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = "$ 1.99";
                    pictureOfMovie.Image = Properties.Resources.nostringsattached;
                    break;

                case 8:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Real Steel";
                    CategoryTextBox.Text = "New Release";
                    costTextBox.Text = "$ 4.99";
                    pictureOfMovie.Image = Properties.Resources.realsteel;
                    break;

                case 9:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Sanctrum";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.sanctum;
                    break;

                case 10:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Season of the Witch";
                    CategoryTextBox.Text = "Sci-Fi";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.seasonofthewitch;
                    break;

                case 11:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Dilemma";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = "$ 1.99";
                    pictureOfMovie.Image = Properties.Resources.thedilemma;
                    break;

                case 12:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Eagle";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.theeagle;
                    break;

                case 13:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Green Hornet";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.theeagle;
                    break;

                case 14:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Mechanic";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.themechanic;
                    break;

                case 15:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Other Woman";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.theotherwoman;
                    break;

                case 16:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Rite";
                    CategoryTextBox.Text = "Horror";
                    costTextBox.Text = "$ 2.99";
                    pictureOfMovie.Image = Properties.Resources.therite;
                    break;

                case 17:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Roommate";
                    CategoryTextBox.Text = "Thriller";
                    costTextBox.Text = "$ 1.99";
                    pictureOfMovie.Image = Properties.Resources.theroommate;
                    break;

                case 18:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "The Way Back";
                    CategoryTextBox.Text = "Drama";
                    costTextBox.Text = "$ 1.99";
                    pictureOfMovie.Image = Properties.Resources.thewayback;
                    break;

                case 19:
                    nextButtonAtSelectionForm.Enabled = true;
                    TitleTextBox.Text = "Waiting for Forever";
                    CategoryTextBox.Text = "Drama";
                    costTextBox.Text = "$ 1.99";
                    pictureOfMovie.Image = Properties.Resources.waitingforever;
                    break;
            }
        }
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
