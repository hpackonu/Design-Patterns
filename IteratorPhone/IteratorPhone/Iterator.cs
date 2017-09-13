using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPhone
{
    public abstract class Iterator
    {
        protected Aggregate aggregate;
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract string CurrentItem();
    }
    public class ConcreteIterator : Iterator
    {
        public override string CurrentItem()
        {
            throw new NotImplementedException();
        }

        public override void First()
        {
            throw new NotImplementedException();
        }

        public override bool IsDone()
        {
            throw new NotImplementedException();
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
    public class VerizonIterator : Iterator
    {
        public VerizonIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        int currItem=0;

        public override string CurrentItem()
        {
            if (!IsDone())
            {
                return aggregate[currItem];
            }
            else
            {
                throw new Exception();
            }
        }

        public override void First()
        {
            currItem = FindVerizon();
        }

        public override bool IsDone()
        {
            return (currItem >= aggregate.Count);
        }

        public override void Next()
        {
            currItem++;
            FindVerizon();
        }
        private int FindVerizon()
        {
            while (!IsDone())
            {
                if (aggregate[currItem].Contains("Verizon"))
                    return currItem;
                currItem++;
            }
            return 7; //Fallback if something goes wrong
        }
    }
    public class ATNTIterator : Iterator
    {
        public ATNTIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        int currItem = 0;

        public override string CurrentItem()
        {
            if (!IsDone())
            {
                return aggregate[currItem];
            }
            else
            {
                throw new Exception();
            }
        }

        public override void First()
        {
            currItem = FindATNT();
        }

        public override bool IsDone()
        {
            return (currItem >= aggregate.Count);
        }

        public override void Next()
        {
            currItem++;
            FindATNT();
        }
        private int FindATNT()
        {
            while (!IsDone())
            {
                if (aggregate[currItem].Contains("AT&T"))
                    return currItem;
                currItem++;
            }
            return 7; //Fallback if something goes wrong
        }
    }
    public class SprintIterator : Iterator
    {
        public SprintIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        int currItem = 0;

        public override string CurrentItem()
        {
            if (!IsDone())
            {
                return aggregate[currItem];
            }
            else
            {
                throw new Exception();
            }
        }

        public override void First()
        {
            currItem = FindSprint();
        }

        public override bool IsDone()
        {
            return (currItem >= aggregate.Count);
        }

        public override void Next()
        {
            currItem++;
            FindSprint();
        }
        private int FindSprint()
        {
            while (!IsDone())
            {
                if (aggregate[currItem].Contains("Sprint"))
                    return currItem;
                currItem++;
            }
            return 7; //Fallback if something goes wrong
        }
    }
    public class TMobileIterator : Iterator
    {
        public TMobileIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        int currItem = 0;

        public override string CurrentItem()
        {
            if (!IsDone())
            {
                return aggregate[currItem];
            }
            else
            {
                throw new Exception();
            }
        }

        public override void First()
        {
            currItem = FindTMobile();
        }

        public override bool IsDone()
        {
            return (currItem >= aggregate.Count);
        }

        public override void Next()
        {
            currItem++;
            FindTMobile();
        }
        private int FindTMobile()
        {
            while (!IsDone())
            {
                if (aggregate[currItem].Contains("T-Mobile"))
                    return currItem;
                currItem++;
            }
            return 7; //Fallback if something goes wrong
        }
    }
}
