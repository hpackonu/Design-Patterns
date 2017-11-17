using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositChords
{
    abstract class Component
    {
        public abstract bool Add(Component c);

        public abstract bool Remove(Component c);

        public abstract string Play();
    }
}
