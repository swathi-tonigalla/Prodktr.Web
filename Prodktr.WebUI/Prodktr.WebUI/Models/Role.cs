using System;
using System.ComponentModel.DataAnnotations;

namespace Prodktr.WebUI.Models
{
    public class Role
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}