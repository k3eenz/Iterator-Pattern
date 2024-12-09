using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern.Interfaces;

namespace Iterator_Pattern.Services
{
    public class LibraryIterator : IReadableIterator
    {
        private readonly IReadableCollection _library;
        private int _currentIndex = 0;
        public LibraryIterator(IReadableCollection library)
        {
            _library = library;
        }
        public bool HasMoreBooks() =>  _currentIndex<_library.BookCount;
        public Book GetNextBook() => _library.GetBook(_currentIndex++);
    }
}
