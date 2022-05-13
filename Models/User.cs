using System;
using System.Collections.Generic;

namespace AssetManager.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public Guid UserId { get; set; }
        public DateTime JoinedOn { get; set; }
        public List<Asset> AssetsInCustody { get; set; }
    }
}