using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Personnel: Human
    {
        [Required]
        [MaxLength(100)]
        public string Position { get; set; }
    }
}
