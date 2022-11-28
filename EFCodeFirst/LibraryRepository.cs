using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class LibraryRepository : ILibraryRepository
    {
        private LibraryContext context;

        public LibraryRepository(IConfiguration configuration)
        {
            var settings = configuration.GetSection("DataAccess");
            if (settings == null)
            {
                this.Ready = false;
                return;
            }
            this.connString = settings["ConnectionString"];
            context = new LibraryContext(connString);
            this.Ready = true;
        }

        public bool Ready { get; private set; }
        public string connString { get; private set; }

        public IEnumerable<Author> GetAuthors()
        {
            return context.Authors.ToList();
        }

        public IEnumerable<Book> GetBooks()
        {
            return context.Books.ToList();
        }
    }
}
