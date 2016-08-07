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

            if (MovieDropdownList.SelectedIndex != -1)
            {
                nextButtonAtSelectionForm.Enabled = false;
                SelectionForm NavToHide = new SelectionForm();
                NavToHide.Close();
            }
            else
            {
                nextButtonAtSelectionForm.Enabled = true;
                OrderForm NavToOrder = new OrderForm();
                NavToOrder.Show();
            }



        }


        public void MovieDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MovieDropdownList.SelectedIndex)
            {
                case 0:
                    TitleTextBox.Text = "Ceday Rapids";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = " $ 1.99 ";

                    break;
                case 1:
                    TitleTextBox.Text = "Company Men";
                    CategoryTextBox.Text = "Drama";
                    costTextBox.Text = " $ 1.99";

                    break;
                case 2:
                    TitleTextBox.Text = " Death Race 2";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = " $ 2.99";

                    break;
                case 3:
                    TitleTextBox.Text = "FootLoose";
                    CategoryTextBox.Text = "New Release";
                    costTextBox.Text = " $ 4.99";

                    break;
                case 4:
                    TitleTextBox.Text = "Gnomeo and Juliet";
                    CategoryTextBox.Text = "Family";
                    costTextBox.Text = "$ 0.99";
                    break;

                case 5:
                    TitleTextBox.Text = " I am Number Four";
                    CategoryTextBox.Text = "Sci-Fi";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 6:
                    TitleTextBox.Text = " Just Go With It";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = "$ 1.99";
                    break;

                case 7:
                    TitleTextBox.Text = "No String Attached";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = "$ 1.99";
                    break;

                case 8:
                    TitleTextBox.Text = "Real Steel";
                    CategoryTextBox.Text = "New Release";
                    costTextBox.Text = "$ 4.99";
                    break;

                case 9:
                    TitleTextBox.Text = "Sanctrum";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 10:
                    TitleTextBox.Text = "Season of the Witch";
                    CategoryTextBox.Text = "Sci-Fi";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 11:
                    TitleTextBox.Text = "The Dilemma";
                    CategoryTextBox.Text = "Comedy";
                    costTextBox.Text = "$ 1.99";
                    break;

                case 12:
                    TitleTextBox.Text = "The Eagle";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 13:
                    TitleTextBox.Text = "The Green Hornet";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 14:
                    TitleTextBox.Text = "The Mechanic";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 15:
                    TitleTextBox.Text = "The Other Woman";
                    CategoryTextBox.Text = "Action";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 16:
                    TitleTextBox.Text = "The Rite";
                    CategoryTextBox.Text = "Horror";
                    costTextBox.Text = "$ 2.99";
                    break;

                case 17:
                    TitleTextBox.Text = "The Roommate";
                    CategoryTextBox.Text = "Thriller";
                    costTextBox.Text = "$ 1.99";
                    break;

                case 18:
                    TitleTextBox.Text = "The Way Back";
                    CategoryTextBox.Text = "Drama";
                    costTextBox.Text = "$ 1.99";
                    break;

                case 19:
                    TitleTextBox.Text = "Waiting for Forever";
                    CategoryTextBox.Text = "Drama";
                    costTextBox.Text = "$ 1.99";
                    break;

            }



        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MovieDropdownList.SelectedItem.ToString();
        }
    }
}
