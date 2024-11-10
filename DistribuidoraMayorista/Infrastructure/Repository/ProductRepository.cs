using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int productId)
        {
            return _dbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public int AddProduct(Product product)
        {
            _dbContext.Products.Add(product);

            _dbContext.SaveChanges();

            return product.ProductId;
        }

        public void UpdateProduct(int productid, Product product)
        {
            var existingProduct = _dbContext.Products.FirstOrDefault(p => p.ProductId == productid);

            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                existingProduct.ProductBrand = product.ProductBrand;
                existingProduct.ProductDetail = product.ProductDetail;
                existingProduct.ProductPrice = product.ProductPrice;
                existingProduct.ProductImageUrl = product.ProductImageUrl;
                existingProduct.ProductCategory = product.ProductCategory;

                _dbContext.SaveChanges();
            }
        }

        public void DeleteProduct(int productid)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.ProductId == productid);

            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }
    }
}
