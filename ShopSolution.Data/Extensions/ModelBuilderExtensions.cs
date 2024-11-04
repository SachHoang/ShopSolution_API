﻿using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entities;
using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of Shop" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of Shop" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of Shop" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Điện thoại và máy tính bảng", LanguageId = "vi-VN", SeoAlias = "dien-thoai-va-may-tinh-bang", SeoDescription = "Sản phẩm điện thoại thông minh và máy tính bảng", SeoTitle = "Sản phẩm điện thoại thông minh và máy tính bảng" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Mobile Phones & Tablets", LanguageId = "en-US", SeoAlias = "mobile-phone-&-tablets", SeoDescription = "Smartphone and tablet products", SeoTitle = "Smartphone and tablet products" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Thiết bị chơi game", LanguageId = "vi-VN", SeoAlias = "Thiet-bi-choi-game", SeoDescription = "Sản phẩm chơi game", SeoTitle = "Sản phẩm chơi game" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Gaming Gear", LanguageId = "en-US", SeoAlias = "gaming-gear", SeoDescription = "Gaming products", SeoTitle = "Gaming products" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Tay cầm chơi game",
                     LanguageId = "vi-VN",
                     SeoAlias = "tay-cam-choi-game",
                     SeoDescription = "Tay cầm chơi game",
                     SeoTitle = "Tay cầm chơi game",
                     Details = "Tay cầm chơi game",
                     Description = "Tay cầm chơi game"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Game Controllers",
                        LanguageId = "en-US",
                        SeoAlias = "game-controllers",
                        SeoDescription = "Game Controllers",
                        SeoTitle = "Game Controllers",
                        Details = "Game Controllers",
                        Description = "Game Controllers"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }


    }
}
