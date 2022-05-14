using System.Collections.Generic;
using AssetManager.Interfaces;
using AssetManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssetManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetRepository _repo;

        public AssetsController(IAssetRepository repository)
        {   
            _repo = repository;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<Asset>> GetAllAssets()
        {
            var assets = _repo.GetAllAssets();
            return Ok(assets);
        }
        
    }
}