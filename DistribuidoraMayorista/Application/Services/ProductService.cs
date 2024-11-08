using Application.Models;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductDto> GetProducts()
        {

            var products = _productRepository.GetProducts();

            return products
                .Select(product => new ProductDto
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ProductBrand = product.ProductBrand,
                    ProductDetail = product.ProductDetail,
                    ProductPrice = product.ProductPrice,
                    ProductImageUrl = product.ProductImageUrl,
                    ProductCategory = product.ProductCategory,
                })
                .ToList();
        }

        public int AddProduct(ProductDto productDto)
        {
            return _productRepository.AddProduct(new Product
            {
                ProductName = productDto.ProductName,
                ProductBrand = productDto.ProductBrand,
                ProductDetail = productDto.ProductDetail,
                ProductPrice = productDto.ProductPrice,
                ProductImageUrl = productDto.ProductImageUrl,
                ProductCategory = productDto.ProductCategory,
            });
        }

        public ProductDto UpdateProduct(int productid, ProductDto productDto)
        {
            var product = new Product
            {
                ProductId = productid,
                ProductName = productDto.ProductName,
                ProductBrand = productDto.ProductBrand,
                ProductDetail = productDto.ProductDetail,
                ProductPrice = productDto.ProductPrice,
                ProductImageUrl = productDto.ProductImageUrl,
                ProductCategory = productDto.ProductCategory
            };

            _productRepository.UpdateProduct(productid, product);

            return productDto;
        }

        public void DeleteProduct(int productid)
        {
            _productRepository.DeleteProduct(productid);
        }


    }
}
