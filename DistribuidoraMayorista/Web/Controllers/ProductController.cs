using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_productService.GetProducts());
        }

        [HttpGet("{productid:int}")]
        public IActionResult GetById(int productid)
        {
            var product = _productService.GetProductById(productid);

            if (product == null)
            {
                return NotFound($"Producto con ID {productid} no encontrado.");
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post(ProductDto productDto)
        {
            return Ok(_productService.AddProduct(productDto));
        }

        [HttpPut("{productid:int}")]
        public IActionResult Put(int productid, [FromBody] ProductDto productDto)
        {
            var updatedProduct = _productService.UpdateProduct(productid, productDto);

            if (updatedProduct == null)
            {
                return NotFound($"Producto con ID {productid} no encontrado.");
            }

            return Ok(updatedProduct);
        }


        [HttpDelete("{productid:int}")]
        public IActionResult Delete(int productid)
        {
            _productService.DeleteProduct(productid);
            return Ok();
        }

    }
}
