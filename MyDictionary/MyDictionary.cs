using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key, Value>
    {
        Key[] _keyArray;
        Key[] _keyTempArray;
        Value[] _valueArray;
        Value[] _valueTempArray;
        public MyDictionary()
        {
            _keyArray = new Key[0];
            _valueArray = new Value[0];
        }

        public void Add(Key k, Value v)
        {
            _keyTempArray = _keyArray;
            _valueTempArray = _valueArray;
            _keyArray = new Key[_keyArray.Length + 1];
            _valueArray = new Value[_valueArray.Length + 1];

            for (int i = 0; i < _keyTempArray.Length; i++)
            {
                _keyArray[i] = _keyTempArray[i];
                _valueArray[i] = _valueArray[i];
            }

            _keyArray[_keyArray.Length - 1] = k;
            _valueArray[_valueArray.Length - 1] = v;
        }

       

        public int Length
        {
            get { return _keyArray.Length; }// Bu yapı eleman sayısını verir.
        }

        public Key[] MyKey
        {
            get { return _keyArray; }// Bu yapı array in elemanıni getirir.
        }

        public Value[] MyValue
        {
            get { return _valueArray; }
        }
        
    }
}
