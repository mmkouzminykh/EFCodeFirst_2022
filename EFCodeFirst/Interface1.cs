using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public interface ILibraryRepository
    {
        bool Ready { get; }
        IEnumerable<Author> GetAuthors();
        IEnumerable<Book> GetBooks();
    }
}
