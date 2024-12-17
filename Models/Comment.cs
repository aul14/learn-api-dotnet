using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        // Pastikan CreatedOn disimpan dalam UTC
        private DateTime _createdOn = DateTime.UtcNow; // Default ke UTC
        public DateTime CreatedOn
        {
            get => _createdOn;
            set => _createdOn = value.Kind == DateTimeKind.Utc ? value : value.ToUniversalTime();
        }
        public int? StockId { get; set; }
        //Navigation
        public Stock? Stock { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}