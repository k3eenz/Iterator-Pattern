using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Interfaces
{
    public interface IReadableIterator
    {
        bool HasMoreBooks();
        Book GetNextBook();
    }
}
