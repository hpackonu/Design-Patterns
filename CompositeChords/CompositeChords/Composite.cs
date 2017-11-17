using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositChords
{
    class Composite : Component
    {
        private List<Component> elements =new List<Component>();

        public override bool Add(Component c)
        {
            //Prevents Empty Notes
            if (c.Play() == "")
                return false;
            //Adds the note to a list
            elements.Add(c);
            return true;
        }

        public override bool Remove(Component c)
        {
            //Prevents Empty Notes
            if (c.Play() == "")
                return false;
            //Checks for the first identical note then removes it
            foreach(Component D in elements)
            {
                if (D.Play() == c.Play())
                {
                    elements.Remove(D);
                    return true; ;
                }
                if (D.GetType() == typeof(Composite))
                {
                    //Checks if the removing was successful and if so returns true
                    if(D.Remove(c))
                        return true;
                }
            }
            return false;
        }

        public override string Play()
        {
            string chord="";
            //Goes through all the elements in the list and returns all their Play() method returns as one string
            foreach (Component c in elements)
            {
                if (chord != "")
                    chord += ", ";
                chord += c.Play();
            }
            return chord;
        }
    }
}
