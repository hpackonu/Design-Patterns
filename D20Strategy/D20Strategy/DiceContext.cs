using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20Strategy
{
    class DiceContext
    {
        int die=20;
        private Action PerformAction;

        public void SetAction(Action Change)
        {
            this.PerformAction = Change;
        }

        public int CompleteAction()
        {
            die=PerformAction.doAction(die);
            return die;
        }
    }
}
