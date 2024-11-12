using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<SysAdmin> SysAdmins { get; set; }
        public DbSet<Buys> Buys { get; set; } 
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<DateMembership> DateMembership { get; set; }

        public ProductDbContext() { }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Client>("Client")
                .HasValue<SysAdmin>("SysAdmin")
                .HasValue<Admin>("Admin");

            

            //modelBuilder.Entity<SysAdmin>().HasData(
            //    new SysAdmin
            //    {
            //        Id = 2,
            //        UserName = "admin",
            //        Email = "admin2@gmail.com",
            //        UserType = "SysAdmin",
            //        Password = "Admin123"
            //    }
            //);
            
            //modelBuilder.Entity<Admin>().HasData(
            //    new Admin
            //    {
            //        Id = 3,
            //        UserName = "Mateo",
            //        Email = "mateo@gmail.com",
            //        UserType = "Admin",
            //        Password = "MATEO"
            //    }
            //);

            //modelBuilder.Entity<Admin>().HasData(
            //    new Admin
            //    {
            //        Id = 4,
            //        UserName = "Felipe",
            //        Email = "felipe@gmail.com",
            //        UserType = "Admin",
            //        Password = "FELIPE"
            //    }
            //);
            
            //modelBuilder.Entity<Client>().HasData(
            //    new Client
            //    {
            //        Id = 5,
            //        UserName = "Emanuel",
            //        Email = "emanuel@gmail.com",
            //        UserType = "Client",
            //        Password = "EMANUEL"
            //    }
            //);

            //modelBuilder.Entity<Client>().HasData(
            //    new Client
            //    {
            //        Id = 6,
            //        UserName = "Sergio",
            //        Email = "sergio@gmail.com",
            //        UserType = "Client",
            //        Password = "SERGIO"
            //    }
            //);



            modelBuilder.Entity<Product>().HasData(
                //Bebidas
                new Product { ProductId = 1, ProductName = "Coca-Cola", ProductBrand = "Coca-Cola", ProductDetail = "Refresco de cola de 355 ml", ProductPrice = 1200, ProductCategory = "Bebidas", ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_914318-MLV45347421529_032021-O.webp" },
                new Product { ProductId = 2, ProductName = "Pepsi", ProductBrand = "Pepsi", ProductDetail = "Refresco de cola de 355 ml", ProductPrice = 1100, ProductCategory = "Bebidas", ProductImageUrl = "https://res.cloudinary.com/riqra/image/upload/v1682014535/sellers/merco-nuevo-leon/products/rh0exfu21r6ebt1dycbc.jpg" },
                new Product { ProductId = 3, ProductName = "Sprite", ProductBrand = "Coca-Cola", ProductDetail = "Refresco sabor limon de 355 ml", ProductPrice = 1150, ProductCategory = "Bebidas", ProductImageUrl = "https://i5.walmartimages.com.mx/gr/images/product-images/img_large/00750105530224L.jpg" },
                new Product { ProductId = 4, ProductName = "Fanta Naranja", ProductBrand = "Coca-Cola", ProductDetail = "Refresco sabor naranja de 355 ml", ProductPrice = 1200, ProductCategory = "Bebidas", ProductImageUrl = "https://www.distribuidoraniki.com.ar/database/articulos/fotos/335/Fanta%20Naranja%20Desc%20500cc%20pet__1.jpg" },
                //Bebidas Alcoholicas
                new Product { ProductId = 5, ProductName = "Corona", ProductBrand = "Grupo Modelo", ProductDetail = "Cerveza clara de 355m ml", ProductPrice = 1800, ProductCategory = "Bebidas Alcoholicas", ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_815688-MLA44293782129_122020-O.webp" },
                new Product { ProductId = 6, ProductName = "Heineken", ProductBrand = "Heineken", ProductDetail = "Cerveza lager de 330 ml", ProductPrice = 2000, ProductCategory = "Bebidas Alcoholicas", ProductImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfxcTiL32-FIWvby3Nfj9TeEtYmP5naoEqNg&s" },
                new Product { ProductId = 7, ProductName = "Bacardi Limon", ProductBrand = "Bacardi", ProductDetail = "Ron sabor limon de 355 ml", ProductPrice = 2500, ProductCategory = "Bebidas Alcoholicas", ProductImageUrl = "https://www.affinitydrinks.es/web/image/product.template/4428/image_1024?unique=e0fb397" },
                new Product { ProductId = 8, ProductName = "Jack Daniels", ProductBrand = "Jack Daniels", ProductDetail = "Whisky de 50 ml", ProductPrice = 3000, ProductCategory = "Bebidas Alcoholicas", ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_620975-MLA77321417311_062024-O.webp" },
                //Dulces
                new Product { ProductId = 9, ProductName = "M&M's", ProductBrand = "Mars", ProductDetail = "Dulces de chocolate de 100 g", ProductPrice = 1500, ProductCategory = "Dulces", ProductImageUrl = "https://acdn.mitiendanube.com/stores/001/132/452/products/mym-mani-d1fbe599c5870e506917134501908073-1024-1024.png" },
                new Product { ProductId = 10, ProductName = "Skittles", ProductBrand = "Mars", ProductDetail = "Dulces de frutas de 100 g", ProductPrice = 1300, ProductCategory = "Dulces", ProductImageUrl = "https://acdn.mitiendanube.com/stores/001/132/452/products/skittles-rojo1-54fc637f2f4eda62ea16261104128364-1024-1024.jpg" },
                new Product { ProductId = 11, ProductName = "Snickers", ProductBrand = "Mars", ProductDetail = "Barra de chocolate con maní de 50 g", ProductPrice = 1200, ProductCategory = "Dulces", ProductImageUrl = "https://http2.mlstatic.com/D_NQ_NP_688563-MLA49139368447_022022-O.webp" },
                new Product { ProductId = 12, ProductName = "Fizz", ProductBrand = "Arcor", ProductDetail = "Caramelos acidos x5", ProductPrice = 500, ProductCategory = "Dulces", ProductImageUrl = "https://camoga.ar/media/catalog/product/cache/17183a23c5d57b885c9e1f3d66234d68/5/0/50010014_-_fizz_relleno_x48.jpg" },
                new Product { ProductId = 13, ProductName = "Flynn Paff", ProductBrand = "Georgalos", ProductDetail = "Caramelos masticables con un sabor intenso a uva", ProductPrice = 200, ProductCategory = "Dulces", ProductImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2Pze0pV1DWPFRBYbt4WvvzF-RzJXKXgRYRg&s" },
                //Snacks
                new Product { ProductId = 14, ProductName = "Doritos", ProductBrand = "Frito-Lay", ProductDetail = "Botana de maíz con queso de 200 g", ProductPrice = 1800, ProductCategory = "Snacks", ProductImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJlxjpsPbLtpSJUOIfhLRCADGuKQfM5TqKTA&s" },
                new Product { ProductId = 15, ProductName = "Cheetos", ProductBrand = "Frito-Lay", ProductDetail = "Botana de queso de 200 g", ProductPrice = 1500, ProductCategory = "Snacks", ProductImageUrl = "https://www.casa-segal.com/wp-content/uploads/2023/01/cheetos-queso-94-g-snacks-casa-segal-mendoza-ofertas-en-mendoza-casa-segal-min.jpg" },
                new Product { ProductId = 16, ProductName = "Lays", ProductBrand = "Frito-Lay", ProductDetail = "Papas fritas clásicas de 150 g", ProductPrice = 1400, ProductCategory = "Snacks", ProductImageUrl = "https://f2h.shop/media/catalog/product/cache/ab45d104292f1bb63d093e6be8310c97/l/a/lays_clasicas_150gx15_uy.png" },
                new Product { ProductId = 17, ProductName = "Pringles", ProductBrand = "Pringles", ProductDetail = "Papas fritas de diferentes sabores de 150 g", ProductPrice = 2000, ProductCategory = "Snacks", ProductImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/800601/Papas-Fritas-Pringles-Original-X104gs-1-1000004.jpg?v=638355837787270000" },
                new Product { ProductId = 18, ProductName = "Saladix", ProductBrand = "Arcor", ProductDetail = "Galletitas saladas de diferentes sabores de 100 g", ProductPrice = 1000, ProductCategory = "Snacks", ProductImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/766461/Galletitas-Saladix-Jam-n-100-Gr-Galletitas-Saladix-Jam-n-100-Gr-1-3368.jpg?v=638104413673200000" }
            );

            modelBuilder.Entity<DateMembership>().HasData(
                new DateMembership { 
                    MembershipId = 1,
                    MembershipTitle = "Membresía Premium", 
                    MembershipDescription = "Suscríbete a nuestra membresía y unete al club!" +
                    "Obtendras muchos beneficios, como un 20% de descuento en el precio total de todas tus compras." +
                    "Estas a tan solo un simple paso de unirte!" +
                    "NO PIERDAS LA OPORTUNIDAD!",
                    MembershipPrice = 50000
                }
                );
        }
    }
}