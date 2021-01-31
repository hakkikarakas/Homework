using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,V>
    {
        K[] _array;
        V[] _array2;
        K[] _tempArray;
        V[] _tempArray2;

        public MyDictionary()
        {
            _array = new K[0];//Newlenmiş dizide eleman sayısı verdik.
            _array2 = new V[0];
        }
        public void Add(K item, V item2)
        {
             _tempArray = _array;
            _tempArray2 = _array2;
            _array = new K[_array.Length + 1];
            _array2 = new V[_array2.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                _array2[i] = _tempArray2[i];
            }

            _array[_array.Length - 1] = item;
            _array2[_array2.Length - 1] = item2;
        }
        public void List(MyDictionary<K,V> myDictionary)
        {
            foreach (var items in _array2)
            {
                Console.WriteLine(items);
            }
        }
}
}
