using Microsoft.AspNetCore.Mvc;
namespace WebApiTesti.Controllers;

[ApiController]
[Route("api/omajuttu")]
public class OmaController : ControllerBase
{
    [HttpGet]
    public string SanoMoi()
    {
        return "Moikka C# ja Web API!";
    }


    [HttpGet]
    public int[] LaskeLukuja()
    {
        return new int[] {1, 2, 3};
    }
}
