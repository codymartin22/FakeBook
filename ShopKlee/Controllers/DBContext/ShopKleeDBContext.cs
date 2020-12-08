using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopKlee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopKlee.Models.ViewModel;
using ShopKlee.Models.MainModels;

namespace ShopKlee.Controllers.DBContext
{
    public class ShopKleeDBContext:IdentityDbContext<InfoUserModel>
    {
        public ShopKleeDBContext(DbContextOptions<ShopKleeDBContext> options):base(options)
        {

        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Friends> Friends { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<InfoUserModel> UserInformationsTabele { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<ShopKlee.Models.ViewModel.UserProfileViewModel> UserProfileViewModel { get; set; }
    }
}
