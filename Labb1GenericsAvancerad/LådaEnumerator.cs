using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1GenericsAvancerad
{
    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _lådor;
        private int curIndex;
        private Låda curLåda;

        public LådaEnumerator(LådaCollection låda)

        {
            _lådor = låda;
            curIndex = -1;
            curLåda = default(Låda);
        }
        public Låda Current
        {
            get { return curLåda; }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }
        public int Count 
        {
            get
            {
                return _lådor.Count;
            }
        }
        public bool MoveNext()
        {
            if (++curIndex >= _lådor.Count)
            {
                return false;
            }
            else
            {
                curLåda = _lådor[curIndex];
            }
            return true;
        }
        void IEnumerator.Reset()
        {
            curIndex = -1;
        }

        public void Dispose()
        {

        }
    }
}
