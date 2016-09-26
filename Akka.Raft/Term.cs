using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akka.Raft
{
   public struct Term
    {
       private readonly long _termNumber;

       public static Term Zero = new Term(0);
       public Term(long termNumber)
       {
           _termNumber = termNumber;
       }

       public static Term operator -(Term term,long val)
       {
           return new Term(term._termNumber - val);
       }

       public static Term operator +(Term term, long val)
       {
            return new Term(term._termNumber + val);
       }
        public static bool operator >(Term term, long val)
        {
            return term._termNumber > val;
        }
        public static bool operator <(Term term, long val)
        {
            return term._termNumber < val;
        }

        public static bool operator >=(Term term, long val)
        {
            return term._termNumber >=val;
        }
        public static bool operator <=(Term term, long val)
        {
            return term._termNumber <=val;
        }
    }
}
