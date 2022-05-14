using System;
using System.ComponentModel.DataAnnotations;

namespace AssetManager.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public DateTime AcquiredOn { get; set; }
        public int CurrentUser { get; set; }
    }
}
