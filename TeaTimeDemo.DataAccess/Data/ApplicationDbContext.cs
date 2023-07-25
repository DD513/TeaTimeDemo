using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeaTimeDemo.Models;

namespace TeaTimeDemo.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "果汁", DisplayOrder = 1 },
                new Category { Id = 2, Name = "茶", DisplayOrder = 2 },
                new Category { Id = 3, Name = "咖啡", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "台灣水果茶",
                    Size = "大杯",
                    Description = "天然果飲，迷人多變。",
                    Price = 60,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "鐵觀音",
                    Size = "中杯",
                    Description = " 品鐵觀音，享人生的味道。",
                    Price = 35,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "冰美式咖啡",
                    Size = "中杯",
                    Description = "用咖啡體悟悠閒時光。",
                    Price = 50,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
            modelBuilder.Entity<Store>().HasData(
                new Store { Id = 1, Name = "台中一中店",Address = "台中市北區三民路三段129號", City= "台中市", PhoneNumber="0987654321" , Description = "鄰近台中一中商圈，學生消暑勝地。" },
                new Store { Id = 2, Name = "台北大安店", Address = "台北市大安區大安路一段11號", City = "台北市", PhoneNumber = "0911111111", Description = "濃厚的教育文化及熱鬧繁華的商圈，豐富整體氛圍。" },
                new Store { Id = 3, Name = "台南安平店", Address = "台南市安平區安平路22號", City = "台南市", PhoneNumber = "0922222222" , Description = "歷史造就了現今的安平，茶香中蘊含了悠遠的歷史。" }
                );
        }
    }
}