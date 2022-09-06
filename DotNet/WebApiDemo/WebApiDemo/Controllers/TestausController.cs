using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestausController : ControllerBase
    {
        [HttpGet]
        [Route("kellonaika")]
        public DateTime Kellonaika()
        {
            return DateTime.Now;
        }

        [HttpGet]
        [Route("luvut")]
        public int[] Luvut()
        {
            int[] luvut = { 1, 3, 5, 7, 9 };
            return luvut;
        }

        [HttpGet]
        [Route("anonyymi")]
        public object AnonyymiOlio()
        {
            return new
            {
                Ominaisuus1 = 9876,
                Ominaisuus2 = "ABCD"
            };
        }
    }
}
