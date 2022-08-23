using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "to bedzie lista produktow";
        }


        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "pojedynbczyt produklt";
        }
    }
}