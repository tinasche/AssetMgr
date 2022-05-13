using Microsoft.AspNetCore.Mvc;

namespace AssetManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> GetAllUsers()
        {
            return Ok("Welcome to the Users controller");
        }
        
    }
}