using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroWasteShop.Website.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Body Care Product" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Household Cleaning Product" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Product Made Of Recycled Materials" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Trash Reducing Product" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Vacuum Flask Product" });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Body Soap",
                Price = 6.99M,
                Description = "The soap does not contain palm or coconut oils. " +
                "A very gentle skin-softening soap.",
                CategoryId = 1,
                ImageUrl = "\\images\\bodycare1.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\bodycare1_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Bamboo Tooth Brush",
                Price = 3.99M,
                Description = "A bamboo toothbrush with charcoal bristles, giving " +
                "the product strong antibacterial properties, cleaning plaque and " +
                "intensive whitening.",
                CategoryId = 1,
                ImageUrl = "\\images\\bodycare2.png",
                ImageThumbnailUrl = "\\images\\thumbnails\\bodycare2_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Jar for cosmetics",
                Price = 1.99M,
                Description = "Helps keep your cosmetic products last longer, perfect for travel.",
                CategoryId = 1,
                ImageUrl = "\\images\\bodycare3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\bodycare3_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Laundry Soap",
                Price = 0.59M,
                Description = "Laundry soap with mustard and soda.",
                CategoryId = 2,
                ImageUrl = "\\images\\cleaning1.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\cleaning1_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Wooden Soap Dish",
                Price = 2.59M,
                Description = "Helps keep your soap fresh longer.",
                CategoryId = 2,
                ImageUrl = "\\images\\cleaning2.png",
                ImageThumbnailUrl = "\\images\\thumbnails\\cleaning2_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Cleaning Kit",
                Price = 12.59M,
                Description = "Helps to clean the house quickly, efficiently, " +
                "without much effort, while not using any cleaning agents.",
                CategoryId = 2,
                ImageUrl = "\\images\\cleaning3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\cleaning3_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Recycled Ballpoint Pen",
                Price = 0.50M,
                Description = "Eco-friendly ballpoint pen made from recycled milk " +
                "and juice bags, soft and pleasant to the touch. As a result of the " +
                "processing of this packaging, polyaluminium and cellulose are obtained, " +
                "from which handles and cases for them are subsequently created.",
                CategoryId = 3,
                ImageUrl = "\\images\\recycled1.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\recycled1_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Recycled Postcard",
                Price = 4.00M,
                Description = "Handcrafted from recycled paper and cardboard.",
                CategoryId = 3,
                ImageUrl = "\\images\\recycled2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\recycled2_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Eco Toy For Dogs",
                Price = 6.99M,
                Description = "Eco toy rope for dogs made of hemp, ball with two ribs.",
                CategoryId = 3,
                ImageUrl = "\\images\\recycled3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\recycled3_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Foldable Silicone Cup",
                Price = 9.00M,
                Description = "The glass is made of food grade silicone, the lid and sleeve " +
                "are made of polypropylene. Suitable for hot and cold drinks (0 to 100 ° C), " +
                "dishwasher safe (easy to disassemble), microwave use after removing the sleeve " +
                "and lid.",
                CategoryId = 4,
                ImageUrl = "\\images\\trashreducing1.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\trashreducing1_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Bag Clip",
                Price = 0.99M,
                Description = "Inexpensive and reliable bag clamps made of completely redesigned tetrapack. " +
                "As a result of the processing of this packaging, polyaluminium and cellulose are obtained, " +
                "from which clamps are subsequently created. Eco-friendly and versatile - they will definitely " +
                "find use in your kitchen!",
                CategoryId = 4,
                ImageUrl = "\\images\\trashreducing2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\trashreducing2_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Cutlery Set",
                Price = 14.00M,
                Description = "The set consists of a knife with a magnetic handle, a fork and a spoon, is compact " +
                "and has a special silicone cover to keep everything clean before and after use.",
                CategoryId = 4,
                ImageUrl = "\\images\\trashreducing3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\trashreducing3_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Metal Flask (0.5L)",
                Price = 12.00M,
                Description = "Used to keep drinks warm. The average temperature retention time is 5-7 hours. " +
                "Do not overfill the thermos, always leave a gap of about 2 centimeters between the liquid and the stopper. " +
                "Avoid sudden temperature changes. Rinse the thermos with warm water before first use. Service life is not limited.",
                CategoryId = 5,
                ImageUrl = "\\images\\vacuumflask1.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\vacuumflask1_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Metal Flask (0.75L)",
                Price = 16.59M,
                Description = "Used to keep drinks warm. The average temperature retention time is 5-7 hours. " +
                "Do not overfill the thermos, always leave a gap of about 2 centimeters between the liquid and the stopper. " +
                "Avoid sudden temperature changes. Rinse the thermos with warm water before first use. Service life is not limited.",
                CategoryId = 5,
                ImageUrl = "\\images\\vacuumflask2.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\vacuumflask2_thumb.jpg",
                IsInStock = true,
                IsOnSale = true
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Coffee Flask (0.5L)",
                Price = 10.00M,
                Description = "This thermos is not only beautiful, but also incredibly functional. Unique modern design. " +
                "Stylish matte colors. Ideal for hot / cold drinks, noodles, soups or rice. Double wall stainless steel. " +
                "Up to 12/24 hours of cold. 100% sealed.",
                CategoryId = 5,
                ImageUrl = "\\images\\vacuumflask3.jpg",
                ImageThumbnailUrl = "\\images\\thumbnails\\vacuumflask3_thumb.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
