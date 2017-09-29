using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class Form1 : Form
    {
        Factory factory = new Factory();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNote8_Click(object sender, EventArgs e)
        {
            lbResults.Text=factory.createProduct("Note8");
        }

        private void btniPhone7_Click(object sender, EventArgs e)
        {
            lbResults.Text = factory.createProduct("iPhone 7");
        }

        private void btnPriv_Click(object sender, EventArgs e)
        {
            lbResults.Text = factory.createProduct("Priv");
        }
    }
}
