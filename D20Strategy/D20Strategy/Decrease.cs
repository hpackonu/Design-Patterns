﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20Strategy
{
    class Decrease : Action
    {
        public override int doAction(int die)
        {
            return --die;
        }
    }
}
