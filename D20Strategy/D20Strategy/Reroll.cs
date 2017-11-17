using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20Strategy
{
    class Reroll : Action
    {
        public override int doAction(int die)
        {
            Random rnd = new Random();
            return rnd.Next(1, 21); //Random die value from 1-20
        }
    }
}
