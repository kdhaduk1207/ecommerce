using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreDbContext storeDbContext;

        public ProductController(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(storeDbContext.Products);
        }
    }
}
