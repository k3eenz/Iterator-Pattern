using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern.Interfaces;

namespace Iterator_Pattern.Services
{
    public class Library : IReadableCollection
    {
        private List<Book> _collection = new List<Book>();
        public int BookCount => _collection.Count;
        public Book GetBook(int index) => _collection[index];
        public IReadableIterator GetIterator() => new LibraryIterator(this);
        public void AddBook(Book book) => _collection.Add(book);
    }
}
