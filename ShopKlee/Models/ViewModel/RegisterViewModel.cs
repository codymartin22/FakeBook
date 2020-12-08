using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models
{
    public class RegisterViewModel
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
        [MaxLength(25)]
        [MinLength(8)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Password should be over 8 characters")]
        [MaxLength(25)]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password should be over 8 characters")]
        [MaxLength(25)]
        [Compare("Password",ErrorMessage ="Password and Confirm Password do not match")]
        public string confirmPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public IFormFile Photo { get; set; }

        [Required]
        [Range(0,1,ErrorMessage ="Invalid Gender")]
        public int Gender { get; set; }
    }
}
