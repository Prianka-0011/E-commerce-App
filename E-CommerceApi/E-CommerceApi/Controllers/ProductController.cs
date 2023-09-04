
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public String getProduct()
        {
            return "This method will return list of product";
        }
        [HttpGet("{id}")]

        public String getProduct(int id) 
        {
            return "This method will return one product";
        }
    }
}
