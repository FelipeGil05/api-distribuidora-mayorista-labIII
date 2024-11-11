﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20241111012039_UpdateMembership")]
    partial class UpdateMembership
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Domain.Entities.Buys", b =>
                {
                    b.Property<int>("BuysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserBuysId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BuysId");

                    b.ToTable("Buys");
                });

            modelBuilder.Entity("Domain.Entities.DetailBuys", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuysId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductDetailId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("DetailId");

                    b.HasIndex("BuysId");

                    b.ToTable("DetailBuys");
                });

            modelBuilder.Entity("Domain.Entities.Membership", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MembershipId");

                    b.HasIndex("UserId");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductBrand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDetail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductBrand = "Coca-Cola",
                            ProductCategory = "Bebidas",
                            ProductDetail = "Refresco de cola de 355 ml",
                            ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_914318-MLV45347421529_032021-O.webp",
                            ProductName = "Coca-Cola",
                            ProductPrice = 1200
                        },
                        new
                        {
                            ProductId = 2,
                            ProductBrand = "Pepsi",
                            ProductCategory = "Bebidas",
                            ProductDetail = "Refresco de cola de 355 ml",
                            ProductImageUrl = "https://res.cloudinary.com/riqra/image/upload/v1682014535/sellers/merco-nuevo-leon/products/rh0exfu21r6ebt1dycbc.jpg",
                            ProductName = "Pepsi",
                            ProductPrice = 1100
                        },
                        new
                        {
                            ProductId = 3,
                            ProductBrand = "Coca-Cola",
                            ProductCategory = "Bebidas",
                            ProductDetail = "Refresco sabor limon de 355 ml",
                            ProductImageUrl = "https://i5.walmartimages.com.mx/gr/images/product-images/img_large/00750105530224L.jpg",
                            ProductName = "Sprite",
                            ProductPrice = 1150
                        },
                        new
                        {
                            ProductId = 4,
                            ProductBrand = "Coca-Cola",
                            ProductCategory = "Bebidas",
                            ProductDetail = "Refresco sabor naranja de 355 ml",
                            ProductImageUrl = "https://www.distribuidoraniki.com.ar/database/articulos/fotos/335/Fanta%20Naranja%20Desc%20500cc%20pet__1.jpg",
                            ProductName = "Fanta Naranja",
                            ProductPrice = 1200
                        },
                        new
                        {
                            ProductId = 5,
                            ProductBrand = "Grupo Modelo",
                            ProductCategory = "Bebidas Alcoholicas",
                            ProductDetail = "Cerveza clara de 355m ml",
                            ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_815688-MLA44293782129_122020-O.webp",
                            ProductName = "Corona",
                            ProductPrice = 1800
                        },
                        new
                        {
                            ProductId = 6,
                            ProductBrand = "Heineken",
                            ProductCategory = "Bebidas Alcoholicas",
                            ProductDetail = "Cerveza lager de 330 ml",
                            ProductImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfxcTiL32-FIWvby3Nfj9TeEtYmP5naoEqNg&s",
                            ProductName = "Heineken",
                            ProductPrice = 2000
                        },
                        new
                        {
                            ProductId = 7,
                            ProductBrand = "Bacardi",
                            ProductCategory = "Bebidas Alcoholicas",
                            ProductDetail = "Ron sabor limon de 355 ml",
                            ProductImageUrl = "https://www.affinitydrinks.es/web/image/product.template/4428/image_1024?unique=e0fb397",
                            ProductName = "Bacardi Limon",
                            ProductPrice = 2500
                        },
                        new
                        {
                            ProductId = 8,
                            ProductBrand = "Jack Daniels",
                            ProductCategory = "Bebidas Alcoholicas",
                            ProductDetail = "Whisky de 50 ml",
                            ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_620975-MLA77321417311_062024-O.webp",
                            ProductName = "Jack Daniels",
                            ProductPrice = 3000
                        },
                        new
                        {
                            ProductId = 9,
                            ProductBrand = "Mars",
                            ProductCategory = "Dulces",
                            ProductDetail = "Dulces de chocolate de 100 g",
                            ProductImageUrl = "https://acdn.mitiendanube.com/stores/001/132/452/products/mym-mani-d1fbe599c5870e506917134501908073-1024-1024.png",
                            ProductName = "M&M's",
                            ProductPrice = 1500
                        },
                        new
                        {
                            ProductId = 10,
                            ProductBrand = "Mars",
                            ProductCategory = "Dulces",
                            ProductDetail = "Dulces de frutas de 100 g",
                            ProductImageUrl = "https://acdn.mitiendanube.com/stores/001/132/452/products/skittles-rojo1-54fc637f2f4eda62ea16261104128364-1024-1024.jpg",
                            ProductName = "Skittles",
                            ProductPrice = 1300
                        },
                        new
                        {
                            ProductId = 11,
                            ProductBrand = "Mars",
                            ProductCategory = "Dulces",
                            ProductDetail = "Barra de chocolate con maní de 50 g",
                            ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_688563-MLA49139368447_022022-O.webp",
                            ProductName = "Snickers",
                            ProductPrice = 1200
                        },
                        new
                        {
                            ProductId = 12,
                            ProductBrand = "Arcor",
                            ProductCategory = "Dulces",
                            ProductDetail = "Caramelos acidos x5",
                            ProductImageUrl = "https://camoga.ar/media/catalog/product/cache/17183a23c5d57b885c9e1f3d66234d68/5/0/50010014_-_fizz_relleno_x48.jpg",
                            ProductName = "Fizz",
                            ProductPrice = 500
                        },
                        new
                        {
                            ProductId = 13,
                            ProductBrand = "Georgalos",
                            ProductCategory = "Dulces",
                            ProductDetail = "Caramelos masticables con un sabor intenso a uva",
                            ProductImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2Pze0pV1DWPFRBYbt4WvvzF-RzJXKXgRYRg&s",
                            ProductName = "Flynn Paff",
                            ProductPrice = 200
                        },
                        new
                        {
                            ProductId = 14,
                            ProductBrand = "Frito-Lay",
                            ProductCategory = "Snacks",
                            ProductDetail = "Botana de maíz con queso de 200 g",
                            ProductImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJlxjpsPbLtpSJUOIfhLRCADGuKQfM5TqKTA&s",
                            ProductName = "Doritos",
                            ProductPrice = 1800
                        },
                        new
                        {
                            ProductId = 15,
                            ProductBrand = "Frito-Lay",
                            ProductCategory = "Snacks",
                            ProductDetail = "Botana de queso de 200 g",
                            ProductImageUrl = "https://www.casa-segal.com/wp-content/uploads/2023/01/cheetos-queso-94-g-snacks-casa-segal-mendoza-ofertas-en-mendoza-casa-segal-min.jpg",
                            ProductName = "Cheetos",
                            ProductPrice = 1500
                        },
                        new
                        {
                            ProductId = 16,
                            ProductBrand = "Frito-Lay",
                            ProductCategory = "Snacks",
                            ProductDetail = "Papas fritas clásicas de 150 g",
                            ProductImageUrl = "https://f2h.shop/media/catalog/product/cache/ab45d104292f1bb63d093e6be8310c97/l/a/lays_clasicas_150gx15_uy.png",
                            ProductName = "Lays",
                            ProductPrice = 1400
                        },
                        new
                        {
                            ProductId = 17,
                            ProductBrand = "Pringles",
                            ProductCategory = "Snacks",
                            ProductDetail = "Papas fritas de diferentes sabores de 150 g",
                            ProductImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/800601/Papas-Fritas-Pringles-Original-X104gs-1-1000004.jpg?v=638355837787270000",
                            ProductName = "Pringles",
                            ProductPrice = 2000
                        },
                        new
                        {
                            ProductId = 18,
                            ProductBrand = "Arcor",
                            ProductCategory = "Snacks",
                            ProductDetail = "Galletitas saladas de diferentes sabores de 100 g",
                            ProductImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/766461/Galletitas-Saladix-Jam-n-100-Gr-Galletitas-Saladix-Jam-n-100-Gr-1-3368.jpg?v=638104413673200000",
                            ProductName = "Saladix",
                            ProductPrice = 1000
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Entities.Admin", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Domain.Entities.SysAdmin", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.HasDiscriminator().HasValue("SysAdmin");
                });

            modelBuilder.Entity("Domain.Entities.DetailBuys", b =>
                {
                    b.HasOne("Domain.Entities.Buys", null)
                        .WithMany("Details")
                        .HasForeignKey("BuysId");
                });

            modelBuilder.Entity("Domain.Entities.Membership", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Buys", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
