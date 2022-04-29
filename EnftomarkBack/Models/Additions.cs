using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BackendProject.Models
{
    public class Additions
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "do not leave empty")]
        [MinLength(4, ErrorMessage = "minimum must be 4")]
        public string Title { get; set; }
        [Required(ErrorMessage = "do not leave empty")]
        [MinLength(10, ErrorMessage = "minimum must be 10")]
        public string Description { get; set; }

    }
}
