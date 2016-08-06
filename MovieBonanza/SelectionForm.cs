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
            Thread.Sleep(2500);
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
    }
}
