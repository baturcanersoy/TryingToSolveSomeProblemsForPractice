using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class MyBooksList<T>
    {
        T[] books;
        public MyBooksList()
        {
            books = new T[0];
        }

        public void Add(T book)
        {
            T[] tempArray = books;

            books = new T[books.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                books[i] = tempArray[i];
            }

            books[books.Length - 1] = book;

        }

        public int Length
        {
            get { return books.Length; }// Bu yapı eleman sayısını verir.
        }

        public T[] Books
        {
            get { return books; }// Bu yapı array in elemanıni getirir.
        }
    }
}
