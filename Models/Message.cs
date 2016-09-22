
using System;
using System.ComponentModel.DataAnnotations; 
namespace TheWall.Models
{
    public partial class Message
    {
        [Required]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}