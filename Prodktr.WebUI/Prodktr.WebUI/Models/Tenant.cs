using System;
using System.ComponentModel.DataAnnotations;

namespace Prodktr.WebUI.Models
{
    public class Tenant
    {
        [Key, Required]
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}