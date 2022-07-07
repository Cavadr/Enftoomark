using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Category { get; set; }
        public byte[] Picture { get; set; }
    }
}
