using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacadeBand
{
    public partial class Form1 : Form
    {
        Facade facade = new Facade();
        
        public Form1()
        {   
            InitializeComponent();
            ResultsLabel.Text = "Instrument Together:\nInstrument In Hands:\nBurning Daylight:\nUniform On:";

        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = facade.Start();
        }

        private void BreakBtn_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = facade.Break();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = facade.End();
        }
    }

    class InstrumentTogether
    {
        public string Start()
        {
            return "Instrument Together: Yes";
        }
        public string Break()
        {
            return "Instrument Together: Yes";
        }
        public string End()
        {
            return "Instrument Together: No";
        }
    }
    class InstrumentInHands
    {
        public string Start()
        {
            return "Instrument In Hands: Yes";
        }
        public string Break()
        {
            return "Instrument In Hands: No";
        }
        public string End()
        {
            return "Instrument In Hands: No";
        }
    }
    class BurningDaylight
    {
        public string Start()
        {
            return "Burning Daylight: No";
        }
        public string Break()
        {
            return "Burning Daylight: Yes";
        }
        public string End()
        {
            return "Burning Daylight: Yes";
        }
    }
    class UniformOn
    {
        public string Start()
        {
            return "Uniform On: Yes";
        }
        public string Break()
        {
            return "Uniform On: Half";
        }
        public string End()
        {
            return "Uniform On: No";
        }
    }
class Facade
{
    private InstrumentTogether together = new InstrumentTogether();
    private InstrumentInHands inhands = new InstrumentInHands();
    private BurningDaylight daylight = new BurningDaylight();
    private UniformOn uniform = new UniformOn();
    public string Start()
    {
            string returned = "";
            returned+=together.Start()+"\n";
            returned+=inhands.Start()+"\n";
            returned+=daylight.Start()+"\n";
            returned+=uniform.Start();
            return returned;
    }
    public string Break()

    {
            string returned = "";
            returned+=together.Break()+"\n";
            returned+=inhands.Break()+"\n";
            returned+=daylight.Break()+"\n";
            returned+=uniform.Break();
            return returned;
    }
    public string End()
    {
            string returned = "";
            returned+=together.End()+"\n";
            returned+=inhands.End()+"\n";
            returned+=daylight.End()+"\n";
            returned+=uniform.End();
            return returned;
    }
}
}