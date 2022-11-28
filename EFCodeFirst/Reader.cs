using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Reader: Human, INamable
    {
        [Required]
        [MaxLength(20)]
        public string Category { get; set; }
    }
}
