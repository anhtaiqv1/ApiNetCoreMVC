﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShopSolution.Data.EF;

namespace eShopSolution.Data.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20230510031052_ChangeFileLengthTpe")]
    partial class ChangeFileLengthTpe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppRoleCaim");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserToken");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "This is home page of eShopSolution"
                        },
                        new
                        {
                            Key = "HomeKeyWord",
                            Value = "This is HomeKeyWord of eShopSolution"
                        },
                        new
                        {
                            Key = "HomeDesCription",
                            Value = "This is DesCription of eShopSolution"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRole");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUser");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c474210-7f46-4b5f-b8e6-99541a6fd26f",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ngoctaiqv1@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Toan",
                            LastName = "Bach",
                            LockoutEnabled = false,
                            NormalizedEmail = "ngoctaiqv1@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAIAAYagAAAAEEcpUIe1dsMjArtmVaE47nQDBXTKlJPJQDv+gwAre4QwIWeKDDh+D0Nr9ws9rtfCNA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsShowOnHome")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("ParenId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsShowOnHome = true,
                            SortOrder = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            IsShowOnHome = true,
                            SortOrder = 2,
                            Status = 0
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CategoryTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoAlias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CategoryTranslation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            LanguageId = "vi",
                            Name = "Áo nam",
                            SeoAlias = "ao-nam",
                            SeoDescription = "Sản phẩm áo thời trang nam",
                            SeoTitle = "Sản phẩm áo thời trang nam"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            LanguageId = "en",
                            Name = "Men Shirt",
                            SeoAlias = "men-shirt",
                            SeoDescription = "The shirt products for men",
                            SeoTitle = "The shirt products for men"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            LanguageId = "vi",
                            Name = "Áo nữ",
                            SeoAlias = "ao-nu",
                            SeoDescription = "Sản phẩm áo thời trang nữ",
                            SeoTitle = "Sản phẩm áo thời trang women"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            LanguageId = "en",
                            Name = "Women Shirt",
                            SeoAlias = "women-shirt",
                            SeoDescription = "The shirt products for women",
                            SeoTitle = "The shirt products for women"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Id = "vi",
                            IsDefault = true,
                            Name = "Tiếng Việt"
                        },
                        new
                        {
                            Id = "en",
                            IsDefault = false,
                            Name = "English"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ShipPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("SeaoAlias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ViewCout")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 10, 10, 10, 52, 373, DateTimeKind.Local).AddTicks(8183),
                            OriginalPrice = 100000m,
                            Price = 200000m,
                            Stock = 0,
                            ViewCout = 0
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductInCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("SeoAlias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTranslations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Áo sơ mi nam trắng Việt Tiến",
                            Details = "Áo sơ mi nam trắng Việt Tiến",
                            LanguageId = "vi",
                            Name = "Áo sơ mi nam trắng Việt Tiến",
                            ProductId = 1,
                            SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                            SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                            SeoTitle = "Áo sơ mi nam trắng Việt Tiến"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Viet Tien Men T-Shirt",
                            Details = "Viet Tien Men T-Shirt",
                            LanguageId = "en",
                            Name = "Viet Tien Men T-Shirt",
                            ProductId = 1,
                            SeoAlias = "viet-tien-men-t-shirt",
                            SeoDescription = "Viet Tien Men T-Shirt",
                            SeoTitle = "Viet Tien Men T-Shirt"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ApplyForAll")
                        .HasColumnType("bit");

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategoryIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Promotion");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Slide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slide");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                            Image = "/themes/images/carousel/1.png",
                            Name = "Second Thumbnail label",
                            SortOrder = 1,
                            Status = 0,
                            Url = "#"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                            Image = "/themes/images/carousel/2.png",
                            Name = "Second Thumbnail label",
                            SortOrder = 2,
                            Status = 0,
                            Url = "#"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                            Image = "/themes/images/carousel/3.png",
                            Name = "Second Thumbnail label",
                            SortOrder = 3,
                            Status = 0,
                            Url = "#"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                            Image = "/themes/images/carousel/4.png",
                            Name = "Second Thumbnail label",
                            SortOrder = 4,
                            Status = 0,
                            Url = "#"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                            Image = "/themes/images/carousel/5.png",
                            Name = "Second Thumbnail label",
                            SortOrder = 5,
                            Status = 0,
                            Url = "#"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.",
                            Image = "/themes/images/carousel/6.png",
                            Name = "Second Thumbnail label",
                            SortOrder = 6,
                            Status = 0,
                            Url = "#"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExternalTransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Cart", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.AppUser", "AppUser")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CategoryTranslation", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Category")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Language", "Language")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("LanguageId");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Order", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductInCategory", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Category")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductTranslation", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Language", "Language")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("LanguageId");

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Transaction", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.AppUser", "AppUser")
                        .WithMany("Transactions")
                        .HasForeignKey("AppUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
