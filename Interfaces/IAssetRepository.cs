using System.Collections.Generic;
using AssetManager.Models;

namespace AssetManager.Interfaces
{
    public interface IAssetRepository
    {
        // GET: Returns all assets
        public IEnumerable<Asset> GetAllAssets();

        // GET: Returns an asset by its id
        public Asset GetAssetById();

        // POST: Create a new asset record
        public void CreateAsset(Asset asset);
        
        // PUT: Full update of entire asset record 
        public void ReplaceAssetById(int id, Asset asset);

        // PATCH: Partial update of asset record
        public void UpdateAssetbyId(int id, Asset asset);

        // DELETE: Delete a record by its id
        public void DeleteAsset(int id);
    }
}