using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models.MainModels
{
    public class Messages
    {
        public string Id { get; set; }
        public string IdFrom { get; set; }
        public string IdTo { get; set;}

        [Required]
        [MinLength(1)]
        public string Message { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }
    }
}
