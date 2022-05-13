using System;

namespace AssetManager.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public DateTime AcquiredOn { get; set; }
        public User CurrentUser { get; set; }
    }
}