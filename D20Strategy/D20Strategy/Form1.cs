using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D20Strategy
{
    public partial class Form1 : Form
    {
        DiceContext Dice = new DiceContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Dice.SetAction(new Increase());
            lblD20.Text = ""+Dice.CompleteAction();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Dice.SetAction(new Decrease());
            lblD20.Text = "" + Dice.CompleteAction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dice.SetAction(new Reroll());
            lblD20.Text = "" + Dice.CompleteAction();
        }
    }
}
