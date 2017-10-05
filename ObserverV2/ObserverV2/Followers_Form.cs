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
    public partial class Followers_Form : Form
    {
        public Followers_Form()
        {
            InitializeComponent();
        }

        public void UpdateUsers(String uno, String dos)
        {
            if (cbUserOne.Checked)
                lblUserOne.Text = "User One: " + uno;
            if (cbUserTwo.Checked)
                lblUserTwo.Text = "User Two: " + dos;
        }
    }
}
