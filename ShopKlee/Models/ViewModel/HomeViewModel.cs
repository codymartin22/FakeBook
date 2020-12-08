using Microsoft.AspNetCore.Http;
using ShopKlee.Models.MainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopKlee.Models.ViewModel
{
    public class HomeViewModel
    {
        public InfoUserModel user { get; set; }
        public string UserName { get; set; }
        public IFormFile PhotoPath { get; set; }
        public List<Posts> Post { get; set; }
        public List<String> BannerPath { get; set; }
        public List<Comments> Comments { get; set; }
        public List<Friends> Friends { get; set; }
    }
}
