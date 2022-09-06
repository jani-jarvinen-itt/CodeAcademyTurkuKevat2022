using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Entities;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsiakasController : ControllerBase
    {
        public List<Customer> KaikkiAsikkaat()
        {
            NorthwindContext context = new();
            List<Customer> asiakkaat = context.Customers.ToList();

            return asiakkaat;
        }
    }
}
