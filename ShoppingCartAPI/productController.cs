using AUTHENTICATED_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Authorize]
namespace MyApp.Namespace
{
    [Route("[controller]/Action")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDataContext _context;

        public ProductController(AppDataContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProductsByCategory(int id)
        {
            var products = await _context.Products.Where(p => p.CategoryId == id).ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult<ProductModel>> PostProduct(ProductModel product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
 }
