using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;

        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(productRepo.GetProducts());
        }
    }
}
