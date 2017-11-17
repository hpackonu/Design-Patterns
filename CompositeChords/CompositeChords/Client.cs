using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositChords
{
    public partial class Client : Form
    {
        Composite ChordOne = new Composite();
        Composite ChordTwo = new Composite();
        Composite ChordThree = new Composite();
        public Client()
        {
            InitializeComponent();
        }

        private void btnAddChordOne_Click(object sender, EventArgs e)
        {
            ChordOne.Add(new NoteLeaf(tbUserInput.Text));
            tbUserInput.Clear();
            rtbChordOne.Text = ChordOne.Play();
        }

        private void btnRemoveChordOne_Click(object sender, EventArgs e)
        {
            ChordOne.Remove(new NoteLeaf(tbUserInput.Text));
            tbUserInput.Clear();
            rtbChordOne.Text = ChordOne.Play();
        }

        private void btnPlayChordOne_Click(object sender, EventArgs e)
        {
            rtbPlayed.Text = ChordOne.Play();
        }

        private void btnAddChordTwo_Click(object sender, EventArgs e)
        {
            ChordTwo.Add(new NoteLeaf(tbUserInput.Text));
            tbUserInput.Clear();
            rtbChordTwo.Text = ChordTwo.Play();
        }

        private void btnPlayNote_Click(object sender, EventArgs e)
        {
            if (tbUserInput.Text != "")
            {
                NoteLeaf note = new NoteLeaf(tbUserInput.Text);
                tbUserInput.Clear();
                rtbPlayed.Text = "";
                rtbPlayed.Text = note.Play();
            }
        }

        private void btnAddThreeToTwo_Click(object sender, EventArgs e)
        {
            ChordTwo.Add(ChordThree);
            ChordThree = new Composite();
            //Updates the chord two & three rich textboxes
            rtbChordTwo.Text = ChordTwo.Play();
            rtbChordThree.Text = ChordThree.Play();
        }

        private void btnAddChordThree_Click(object sender, EventArgs e)
        {
            ChordThree.Add(new NoteLeaf(tbUserInput.Text));
            tbUserInput.Clear();
            //Updates the chord two rich textbo
            rtbChordThree.Text = ChordThree.Play();
        }

        private void btnRemoveChordTwo_Click(object sender, EventArgs e)
        {
            ChordTwo.Remove(new NoteLeaf(tbUserInput.Text));
            tbUserInput.Clear();
            rtbChordTwo.Text = ChordTwo.Play();
        }

        private void btnRemoveChordThree_Click(object sender, EventArgs e)
        {
            ChordThree.Remove(new NoteLeaf(tbUserInput.Text));
            tbUserInput.Clear();
            rtbChordThree.Text = ChordThree.Play();
        }

        private void btnPlayChordTwo_Click(object sender, EventArgs e)
        {
            rtbPlayed.Text = ChordTwo.Play();
        }
    }
}
