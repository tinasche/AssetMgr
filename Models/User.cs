using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssetManager.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Department { get; set; }
        public Guid UserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinedOn { get; set; }
    }
}