using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models.MainModels
{
    public class Likes
    {
        public string Id { get; set; }
        public string IdCreator { get; set; }
        public string IdPost { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
    }
}
