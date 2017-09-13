using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPhone
{
    public enum IteratorType { Verizon, ATNT, Sprint, TMobile }
    public abstract class Aggregate :List<string>
    {
        public Iterator CreateIterator(IteratorType amount)
        {
            Iterator returnVal=null;
            switch (amount)
            {
                case IteratorType.Verizon:
                    returnVal = CreateVerizonIterator(this);
                    break;
                case IteratorType.ATNT:
                    returnVal = CreateATNTIterator(this);
                    break;
                case IteratorType.Sprint:
                    returnVal = CreateSprintIterator(this);
                    break;
                case IteratorType.TMobile:
                    returnVal = CreateTMobileIterator(this);
                    break;

            }
            return returnVal;
        }
        private Iterator CreateVerizonIterator(Aggregate agg)
        {
            return new VerizonIterator(agg);
        }
        private Iterator CreateATNTIterator(Aggregate agg)
        {
            return new ATNTIterator(agg);
        }
        private Iterator CreateSprintIterator(Aggregate agg)
        {
            return new SprintIterator(agg);
        }
        private Iterator CreateTMobileIterator(Aggregate agg)
        {
            return new TMobileIterator(agg);
        }
    }
    public class ConcreteAggregate : Aggregate
    {
    }
    
}
