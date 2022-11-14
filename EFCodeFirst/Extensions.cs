using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public static class Extensions
    {
        public static int Age(this Book book)
        {
            return DateTime.Now.Year - book.PublishingYear;
        }
    }
}
