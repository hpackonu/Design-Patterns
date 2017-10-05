using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverV2
{
    public partial class Followed_Users_Form : Form
    {
        public delegate void DUpdate(String uno, String dos); // D stands for delegate
        DUpdate updating;
        public Followed_Users_Form()
        {
            InitializeComponent();
            
        }

        private void btnFollower_Click(object sender, EventArgs e)
        {
            Followers_Form follower = new Followers_Form();
            updating += follower.UpdateUsers; //WORKS!!!
            follower.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updating(tbUserOne.Text, tbUserTwo.Text);
        }
    }
}
