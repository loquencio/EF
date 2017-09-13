using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Editora
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(250)]       
        public string Nome { get; set; }
        [Required, MaxLength(250)]
        public string Email { get; set; }
    }
}
