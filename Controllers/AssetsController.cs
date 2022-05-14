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
            if (assets != null)
                return Ok(assets);

            return NotFound();
        }

        [HttpGet("{id}", Name = "GetAssetById")]
        public ActionResult<Asset> GetAssetById(int id)
        {
            var asset = _repo.GetAssetById(id);
            if (asset == null)
                return NotFound(asset);

            return Ok(asset);
        }

        [HttpPost]
        public ActionResult <Asset> CreateAsset(Asset newAsset)
        {
            if (newAsset != null)
                _repo.CreateAsset(newAsset);

            return CreatedAtRoute(nameof(GetAssetById), new { Id = newAsset.Id }, newAsset);
        }
        
        [HttpPut("{id}")]
        public ActionResult ReplaceAssetById(int id, Asset replacementAsset)
        {
            if (id != replacementAsset.Id)
                return BadRequest();

            if (! _repo.ReplaceAssetById(id, replacementAsset))
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteAssetById(int id)
        {
            if (! _repo.DeleteAsset(id))
                return NotFound();

            return NoContent();
        }

        [HttpPatch]
        public ActionResult UpdateAssetById(int id, Asset updatedAsset)
        {
            return Ok();
        }
    }
}