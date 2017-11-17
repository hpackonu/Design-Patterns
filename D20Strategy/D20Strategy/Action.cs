using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20Strategy
{
    abstract class Action
    {
        //Does an action to the die then returns the new die value
        public abstract int doAction(int die);
    }
}
