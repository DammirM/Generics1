using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class BoxEnumrator : IEnumerator<Box>
    {

        private BoxCollection _box;
        private int _currIndex;
        private Box _currBox;

        public BoxEnumrator(BoxCollection box)
        {
            this._box = box;
            _currIndex = -1;
            _currBox = default(Box);
        }
        public Box Current { get { return _currBox; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++_currIndex >= _box.Count)
            {
                return false;
            }
            else
            {
                _currBox = _box[_currIndex];
            }
            return true;
        }

        public void Reset()
        {
            _currIndex = -1;
        }
    }
}
