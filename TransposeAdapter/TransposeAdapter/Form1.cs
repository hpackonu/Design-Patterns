using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransposeAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbEndInstrument.SelectedIndex = 0;
            cbStartInstrument.SelectedIndex = 0;
            cbNote.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            tbResultNote.Text = new Adapter(cbStartInstrument.Text, cbNote.Text, cbEndInstrument.Text).GetResultNote();
        }
    }

    //The Target class
    class Target
    {
        public string startInstrument;
        public string startNote;
        public string endInstrument;

        //Constructor
        public void SetVariables(String Start, String Note, String End)
        {
            startInstrument = Start;
            startNote = Note;
            endInstrument = End;
        }

        //Returns the transposed result
        public virtual string GetResultNote()
        {
            return "";
        }
    }

    class Adapter : Target
    {
        private Adaptee convert=new Adaptee();

        public Adapter(String Start, String Note, String End)
        {
            SetVariables(Start, Note, End);
        }
        public override string GetResultNote()
        {
            return convert.ConvertNote(startInstrument, startNote, endInstrument);
        }
    }
    
    //C, F, Bb, Eb, Ab, Db, Gb, B, E, A, D, G
    //Converts from C to Bb
    class Adaptee
    { 
        public string ConvertNote(string startInstrument, string startNote, string endInstrument)
        {
            if (startNote == "C") {
                return "D";
            }
            else if(startNote == "F")
            {
                return "G";
            }
            else if (startNote == "Bb")
            {
                return "C";
            }
            else if (startNote == "Eb")
            {
                return "F";
            }
            else if (startNote == "Ab")
            {
                return "Bb";
            }
            else if (startNote == "Db")
            {
                return "Eb";
            }
            else if (startNote == "Gb")
            {
                return "Ab";
            }
            else if (startNote == "B")
            {
                return "Db";
            }
            else if (startNote == "E")
            {
                return "Gb";
            }
            else if (startNote == "A")
            {
                return "B";
            }
            else if (startNote == "D")
            {
                return "E";
            }
            else if (startNote == "G")
            {
                return "A";
            }
            //Fallback
            return "";
        }
    }
}
