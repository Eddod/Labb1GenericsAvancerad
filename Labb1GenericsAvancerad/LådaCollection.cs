using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1GenericsAvancerad
{
    public class LådaCollection : ICollection<Låda>
    {
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        private List<Låda> innerCol;
        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }

        public Låda this[int index]
        {
            get { return innerCol[index]; }
            set { innerCol[index] = value; }
        }
        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                if (L.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }
        public bool Contains(Låda item, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                if (comp.Equals(L, item))
                {
                    found = true;
                }
            }
            return found;
        }
        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("En låda med höjd :{0} , bredd : {1} längd : {2} har redan lagts till i kollektionen."
                    , item.höjd.ToString(), item.längd.ToString(), item.bredd.ToString());
            }
        }

        public void Clear()
        {
            innerCol.Clear();
        }
        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }
        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("Array cannot be null.");

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("Starting array index cannot be negative.");


            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("Destination array has fewer elements than the collection.");

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }

        }
        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda curLåda = innerCol[i];

                if (new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
