using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models.MainModels
{
    public class Posts
    {
        public string Id { get; set; }
        public string IdCreator { get; set; }
        
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        public string Description { get; set; }

        public string Photo { get; set; }

        public List<Comments> Comments { get; set; }

        public List<Likes> Like { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }
    }
}
