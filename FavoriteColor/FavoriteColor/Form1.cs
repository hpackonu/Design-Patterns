using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavoriteColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Blue").getColor();
        }

        private void btnAqua_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Aqua").getColor();
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Magenta").getColor();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Red").getColor();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Green").getColor();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Yellow").getColor();
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Orange").getColor();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            txtboxFavorite.Text = Singleton.getInstance("Black").getColor();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Singleton.getInstance("").clear();
            txtboxFavorite.Text = "";
        }
    }
}
