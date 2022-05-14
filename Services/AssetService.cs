using System;
using System.Collections.Generic;
using System.Linq;
using AssetManager.Data;
using AssetManager.Interfaces;
using AssetManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManager.Services
{
    public class AssetService : IAssetRepository
    {
        private readonly AssetsDbContext _context;

        public AssetService(AssetsDbContext context)
        {
            _context = context;
        }
        
        public void CreateAsset(Asset newAsset)
        {
            if (newAsset == null)
                throw new ArgumentNullException(nameof(newAsset));
            
            _context.Assets.Add(newAsset);
            _context.SaveChanges();
        }

        public bool DeleteAsset(int id)
        {
            var assetToDelete = _context.Assets.FirstOrDefault(p => p.Id == id);
            if (assetToDelete != null) 
            {
                _context.Assets.Remove(assetToDelete);
                _context.SaveChanges();
            }
            else
                return false;

            return true;
        }

        public IEnumerable<Asset> GetAllAssets()
        {
            return _context.Assets;
        }

        public Asset GetAssetById(int id)
        {
            return _context.Assets.FirstOrDefault(p => p.Id == id);
        }

        public bool ReplaceAssetById(int id, Asset replacementAsset)
        {
            _context.Entry(replacementAsset).State = EntityState.Modified;

            try 
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.Assets.FirstOrDefault(p => p.Id == id) == null)
                    return false;
                else
                    throw;                
            }

            return true;
        }

        public void UpdateAssetbyId(int id, Asset asset)
        {
            throw new System.NotImplementedException();
        }
    }
}