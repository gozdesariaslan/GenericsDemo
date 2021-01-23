using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0]; //sıfır elemanlı dizi
            values = new TValue[0]; //sıfır elemanlı dizi
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeyArr = keys; //geçici dizi
            TValue[] tempValueArr = values; //geçici dizi

            keys = new TKey[keys.Length + 1]; //dizi boyutu 1 artırıldı
            values = new TValue[values.Length + 1]; //dizi boyutu 1 artırıldı

            for (int i = 0; i < tempKeyArr.Length; i++)
            {
                keys[i] = tempKeyArr[i]; //yeni diziye eski veriler sırasıyla eklendi
                values[i] = tempValueArr[i]; //yeni diziye eski veriler sırasıyla eklendi

            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void GetList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Number: " + keys[i] + " Name: " + values[i]);
            }
        }
    }
}
