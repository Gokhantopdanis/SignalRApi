﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Concrete
{
    public class SignalRContext : IdentityDbContext<AppUser, AppRole, int>  
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8SVKNDE; initial Catalog=SignalRDb; integrated Security=true");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<Feature> Features { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<MoneyCase> MoneyCases { get; set; }

        public DbSet<MenuTable> MenuTables { get; set; }
        
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}
