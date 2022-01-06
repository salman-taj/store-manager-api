using Microsoft.AspNetCore.Mvc;

namespace StoreManager.Host.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {
    }
}