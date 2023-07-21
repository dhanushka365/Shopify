using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shofipy.Infrastructure.Command.Product;

namespace Shopify.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;
            return Accepted("Get Product Method Called");
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromForm] CreateProduct product)
        {
            await Task.CompletedTask;
            return Accepted("product Created");
        }
    }
}
