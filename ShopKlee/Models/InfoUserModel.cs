using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models
{
    public class InfoUserModel:IdentityUser
    {
        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(20)]
        public string Address { get; set; }

        [Required]
        public bool Gender { get; set; }

        [DataType(DataType.Url)]
        public string IMG_url { get; set; }
        public bool IsOnline { get; set; }
    }
}
