using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models
{
    public class LoginViewModel
    {
        [Required]
        [MinLength(8, ErrorMessage = "Min length is 8")]
        [MaxLength(25,ErrorMessage ="Max length is 25")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password,ErrorMessage ="Password is invalid")]
        [MaxLength(25, ErrorMessage = "Max length is 25")]
        [MinLength(8, ErrorMessage = "Min length is 8")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool Rememberme { get; set; }
    }
}
