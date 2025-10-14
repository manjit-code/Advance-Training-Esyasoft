using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Week_2_Classwork_1.Model;

namespace Week_2_Classwork_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManager : Controller
    {
        // GET all products
        [HttpGet("All")]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<ProductDTO>> getAllProducts()
        {
            var products = new List<ProductDTO>();
            foreach (var item in ProductRepository.Products)
            {
                products.Add(item);
            }
            return Ok(products);
        }

        // GET product by ID
        [HttpGet("{productId:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]

        public ActionResult<ProductDTO> getProduct(int productId)
        {
            if(productId == null || productId <= 0)
            {
                return BadRequest();
            }
            var product = ProductRepository.Products.Where(p => p.ProductID == productId).FirstOrDefault();

            if (product == null)
            {
                return NotFound($"Product with id {productId} is not found.");
            }
            return Ok(product);
        }

        // POST → Add new product
        [HttpPost("AddProduct")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public ActionResult addProduct([FromBody] ProductDTO product)
        {
            if (product == null)
            {
                return BadRequest($"Null Body");
            }

            if(product.Price <= 0 || product.StockQuantity < 0)
            {
                return BadRequest($"Invalid price:{product.Price} or stock quantity: {product.StockQuantity}");
            }

            int productId = ProductRepository.Products.LastOrDefault().ProductID + 1;
            var newProduct = new ProductDTO
            {
                ProductID = productId,
                Name = product.Name,
                Category = product.Category,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
            };
            ProductRepository.Products.Add(newProduct);

            return NoContent();
        }

        // PUT → Replace product details completely
        [HttpPost("{id:int}/updateAll")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)]

        public ActionResult<ProductDTO> updateProductById([FromBody] ProductDTO product)
        {
            if (product == null || product.ProductID <= 0)
            {
                return BadRequest($"Null/Invalid Body");
            }

            var existingProduct = ProductRepository.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
            if (existingProduct == null)
            {
                return NotFound($"Product with id: {product.ProductID} is nor found.");
            }

            existingProduct.Name = product.Name;
            existingProduct.Category = product.Category;
            existingProduct.Price = product.Price;
            existingProduct.StockQuantity = product.StockQuantity;

            return Ok(existingProduct);
        }

        // PATCH → Update price or stock quantity only
        [HttpPatch("{id:int}/updatePartial")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)]

        public ActionResult UpdatePartial(int id, [FromBody] JsonPatchDocument<ProductDTO> patchDocument)
        {
            if(patchDocument == null || id <= 0)
            {
                return BadRequest("Invalid Body or ID");
            }
            var existingProduct = ProductRepository.Products.Where(p => p.ProductID == id).FirstOrDefault();
            if (existingProduct == null)
            {
                return NotFound($"Product with id:{id} is not found.");
            }

            var tempProduct = new ProductDTO
            {
                Name = existingProduct.Name,
                Category = existingProduct.Category,
                Price = existingProduct.Price,
                StockQuantity = existingProduct.StockQuantity,
            };

            patchDocument.ApplyTo(tempProduct, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest("State Error in Body");
            }

            existingProduct.Name = tempProduct.Name;
            existingProduct.Category = tempProduct.Category;
            existingProduct.Price = tempProduct.Price;
            existingProduct.StockQuantity = tempProduct.StockQuantity;

            return NoContent();
        }

    }
}
