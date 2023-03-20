using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(new BookComparator());
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;

            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                currentIndex++;

                if (currentIndex < this.books.Count)
                {
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }

    }
}
