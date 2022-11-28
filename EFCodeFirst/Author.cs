using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Author : INamable
    {
        public Author()
        {
            Books = new List<Book>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime Birthday {get; set; }

        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
