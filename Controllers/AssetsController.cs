using Microsoft.AspNetCore.Mvc;

namespace AssetManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {

        
        [HttpGet]
        public ActionResult<string> GetAllAssets()
        {
            return Ok("Welcome to the Assets controller");
        }
        
    }
}