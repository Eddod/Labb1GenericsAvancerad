using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Labb1GenericsAvancerad
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals(Låda x, Låda y)
        {
            if (x.höjd == y.höjd && x.längd == y.längd && x.bredd == y.bredd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            var hCode = obj.höjd ^ obj.längd ^ obj.bredd;
            return hCode.GetHashCode();
        }
    }
}