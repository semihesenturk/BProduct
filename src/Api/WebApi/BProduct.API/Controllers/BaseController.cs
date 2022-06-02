using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BProduct.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public Guid? UserId => Guid.NewGuid(); // new Guid(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
    }
}
