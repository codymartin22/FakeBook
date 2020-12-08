using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models.MainModels
{
    public class Friends
    {
        public string Id { get; set; }
        public string IdUser { get; set; }
        public string IdFriend { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
    }
}
