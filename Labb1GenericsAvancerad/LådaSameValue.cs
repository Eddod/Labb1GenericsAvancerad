using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1GenericsAvancerad
{
    public class LådaSameValue : EqualityComparer<Låda>
    {
        public override bool Equals(Låda l1, Låda l2)
        {
            if ((l1.höjd,l1.längd,l1.bredd) == (l2.höjd,l2.längd,l2.bredd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda låda)
        {
            int hCode = låda.höjd ^ låda.längd ^ låda.bredd;
            Console.WriteLine("HC: {0}", hCode.GetHashCode());
            return hCode.GetHashCode();
        }
    }
}
