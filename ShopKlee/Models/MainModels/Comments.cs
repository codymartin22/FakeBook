using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models.MainModels
{
    public class Comments
    {
        public string Id { get; set; }
        public string IdPost { get; set; }
        public string IdCreator { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        public string Description { get; set;}

        public int Like { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
    }
}
