using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.Models
{
    public class Images
    {
        
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Desc { get; set; }
        public string Category { get; set; }
        
        [NotMapped]
        [Required]
        public IFormFile  Picture { get; set; }
        [Required]
        public string PictureUrl { get; set; }
    }
}
