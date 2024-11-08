using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductBrand = table.Column<string>(type: "TEXT", nullable: false),
                    ProductDetail = table.Column<string>(type: "TEXT", nullable: false),
                    ProductPrice = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ProductCategory = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductBrand", "ProductCategory", "ProductDetail", "ProductImageUrl", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "Coca-Cola", "Bebidas", "Refresco de cola de 355 ml", "https://http2.mlstatic.com/D_NQ_NP_914318-MLV45347421529_032021-O.webp", "Coca-Cola", 1200 },
                    { 2, "Pepsi", "Bebidas", "Refresco de cola de 355 ml", "https://res.cloudinary.com/riqra/image/upload/v1682014535/sellers/merco-nuevo-leon/products/rh0exfu21r6ebt1dycbc.jpg", "Pepsi", 1100 },
                    { 3, "Coca-Cola", "Bebidas", "Refresco sabor limon de 355 ml", "https://i5.walmartimages.com.mx/gr/images/product-images/img_large/00750105530224L.jpg", "Sprite", 1150 },
                    { 4, "Coca-Cola", "Bebidas", "Refresco sabor naranja de 355 ml", "https://www.distribuidoraniki.com.ar/database/articulos/fotos/335/Fanta%20Naranja%20Desc%20500cc%20pet__1.jpg", "Fanta Naranja", 1200 },
                    { 5, "Grupo Modelo", "Bebidas Alcoholicas", "Cerveza clara de 355m ml", "https://http2.mlstatic.com/D_NQ_NP_815688-MLA44293782129_122020-O.webp", "Corona", 1800 },
                    { 6, "Heineken", "Bebidas Alcoholicas", "Cerveza lager de 330 ml", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfxcTiL32-FIWvby3Nfj9TeEtYmP5naoEqNg&s", "Heineken", 2000 },
                    { 7, "Bacardi", "Bebidas Alcoholicas", "Ron sabor limon de 355 ml", "https://www.affinitydrinks.es/web/image/product.template/4428/image_1024?unique=e0fb397", "Bacardi Limon", 2500 },
                    { 8, "Jack Daniels", "Bebidas Alcoholicas", "Whisky de 50 ml", "https://http2.mlstatic.com/D_NQ_NP_620975-MLA77321417311_062024-O.webp", "Jack Daniels", 3000 },
                    { 9, "Mars", "Dulces", "Dulces de chocolate de 100 g", "https://acdn.mitiendanube.com/stores/001/132/452/products/mym-mani-d1fbe599c5870e506917134501908073-1024-1024.png", "M&M's", 1500 },
                    { 10, "Mars", "Dulces", "Dulces de frutas de 100 g", "https://acdn.mitiendanube.com/stores/001/132/452/products/skittles-rojo1-54fc637f2f4eda62ea16261104128364-1024-1024.jpg", "Skittles", 1300 },
                    { 11, "Mars", "Dulces", "Barra de chocolate con maní de 50 g", "https://http2.mlstatic.com/D_NQ_NP_688563-MLA49139368447_022022-O.webp", "Snickers", 1200 },
                    { 12, "Arcor", "Dulces", "Caramelos acidos x5", "https://camoga.ar/media/catalog/product/cache/17183a23c5d57b885c9e1f3d66234d68/5/0/50010014_-_fizz_relleno_x48.jpg", "Fizz", 500 },
                    { 13, "Georgalos", "Dulces", "Caramelos masticables con un sabor intenso a uva", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2Pze0pV1DWPFRBYbt4WvvzF-RzJXKXgRYRg&s", "Flynn Paff", 200 },
                    { 14, "Frito-Lay", "Snacks", "Botana de maíz con queso de 200 g", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJlxjpsPbLtpSJUOIfhLRCADGuKQfM5TqKTA&s", "Doritos", 1800 },
                    { 15, "Frito-Lay", "Snacks", "Botana de queso de 200 g", "https://www.casa-segal.com/wp-content/uploads/2023/01/cheetos-queso-94-g-snacks-casa-segal-mendoza-ofertas-en-mendoza-casa-segal-min.jpg", "Cheetos", 1500 },
                    { 16, "Frito-Lay", "Snacks", "Papas fritas clásicas de 150 g", "https://f2h.shop/media/catalog/product/cache/ab45d104292f1bb63d093e6be8310c97/l/a/lays_clasicas_150gx15_uy.png", "Lays", 1400 },
                    { 17, "Pringles", "Snacks", "Papas fritas de diferentes sabores de 150 g", "https://jumboargentina.vtexassets.com/arquivos/ids/800601/Papas-Fritas-Pringles-Original-X104gs-1-1000004.jpg?v=638355837787270000", "Pringles", 2000 },
                    { 18, "Arcor", "Snacks", "Galletitas saladas de diferentes sabores de 100 g", "https://jumboargentina.vtexassets.com/arquivos/ids/766461/Galletitas-Saladix-Jam-n-100-Gr-Galletitas-Saladix-Jam-n-100-Gr-1-3368.jpg?v=638104413673200000", "Saladix", 1000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true),
                    PagesAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }
    }
}
