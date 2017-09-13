using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IteratorPhone
{
    public partial class Form1 : Form
    {
        ConcreteAggregate agg;

        public Form1()
        {
            InitializeComponent();
            agg = new ConcreteAggregate();
            LoadAgg(agg);
            Iterator iterVerizon = agg.CreateIterator(IteratorType.Verizon);
            Iterator iterATNT = agg.CreateIterator(IteratorType.ATNT);
            Iterator iterSprint = agg.CreateIterator(IteratorType.Sprint);
            Iterator iterTMobile = agg.CreateIterator(IteratorType.TMobile);
            PopulateListBox(iterVerizon, lbTotalIterated);
            PopulateListBox(iterATNT, lbTotalIterated);
            PopulateListBox(iterSprint, lbTotalIterated);
            PopulateListBox(iterTMobile, lbTotalIterated);
        }
        private void LoadAgg(ConcreteAggregate agg)
        {
            agg.Add("Verizon : Hayden");
            agg.Add("Verizon : William");
            agg.Add("AT&T : Matt");
            agg.Add("AT&T : Frank");
            agg.Add("Sprint : Shawn");
            agg.Add("T-Mobile : Kat");
        }
        private void PopulateListBox(Iterator iter, ListBox lb)
        {
            for (iter.First(); !iter.IsDone(); iter.Next())
            {
                lb.Items.Add(iter.CurrentItem());
            }

        }
        private void CheckAll()
        {
            Iterator iterVerizon = agg.CreateIterator(IteratorType.Verizon);
            Iterator iterATNT = agg.CreateIterator(IteratorType.ATNT);
            Iterator iterSprint = agg.CreateIterator(IteratorType.Sprint);
            Iterator iterTMobile = agg.CreateIterator(IteratorType.TMobile);
            lbResults.Items.Clear();
            if ((bool)cbVerizon.Checked)
                PopulateListBox(iterVerizon, lbResults);
            if ((bool)cbATNT.Checked)
                PopulateListBox(iterATNT, lbResults);
            if ((bool)cbSprint.Checked)
                PopulateListBox(iterSprint, lbResults);
            if ((bool)cbTMobile.Checked)
                PopulateListBox(iterTMobile, lbResults);
        }

        private void cbVerizon_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void cbATNT_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void cbSprint_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void cbTMobile_CheckedChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
    }
}
