using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Interfaces
{
    public interface IReadableCollection
    {
        IReadableIterator GetIterator();
        int BookCount { get; }
        Book GetBook(int index);
    }
}
