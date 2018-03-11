using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model;
namespace TeduShop.Data
{
    public class TeduShopDbContext:DbContext
    {
        public TeduShopDbContext():base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }
        public  DbSet<PostTags> PostTags { get; set; }
        public  DbSet<Footer> Footers { get; set; }
        public  DbSet<MenuGroup> MenuGroups { get; set; }
        public  DbSet<Menus> Menus { get; set; }
        public  DbSet<OrderDetail> OrderDetails { get; set; }
        public  DbSet<Orders> Orders { get; set; }
        public  DbSet<Pages> Pages { get; set; }
        public  DbSet<Post> Posts { get; set; }
        public  DbSet<PostCategories> PostCategories { get; set; }
        public  DbSet<ProductCategorie> ProductCategories { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Slides> Slides { get; set; }
        public  DbSet<SupportOnline> SupportOnlines { get; set; }
        public  DbSet<SystemConfigs> SystemConfigs { get; set; }
        public  DbSet<Tags> Tags { get; set; }
        public  DbSet<VisitorStatistics> VisitorStatistics { get; set; }
        public  DbSet<Error> Errors { get; set; }
        protected   override  void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }

    
}
