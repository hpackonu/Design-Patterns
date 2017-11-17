using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositChords
{
    class NoteLeaf : Component
    {
        string note;
        public NoteLeaf(string input)
        {
            note = input;
        }

        //Unusable in a leaf
        public override bool Add(Component c)
        {
            throw new NotImplementedException();
        }

        //Returns the note
        public override string Play()
        {
            return note;
        }

        //Unusable in a leaf
        public override bool Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
