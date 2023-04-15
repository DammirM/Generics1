using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class BoxCollection : ICollection<Box>
    {

        private List<Box> boxcol;

        public BoxCollection() { boxcol = new List<Box>(); }

        public Box this[int index]
        {
            get { return (Box)boxcol[index]; }
            set { boxcol[index] = value; }
        }
        public int Count
        {
            get { return boxcol.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                boxcol.Add(item);
            }
            else
            {
                Console.WriteLine("A box with Height: {0}, Length: {1}, Width: {2} was already added",
                    item.height.ToString(), item.length.ToString(), item.width.ToString());
            }
        }

        public void Clear()
        {
            boxcol.Clear();
        }

        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in boxcol)
            {
                if (b.Equals(item))
                {

                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The Array cannot be null");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting Array index cannot be negative");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection");
            }
            for (int i = 0; i < boxcol.Count; i++)
            {
                array[i + arrayIndex] = boxcol[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumrator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < boxcol.Count; i++)
            {
                Box student = boxcol[i];
                if (new BoxSameDimensions().Equals(student, item))
                {
                    boxcol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
