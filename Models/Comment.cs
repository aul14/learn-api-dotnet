using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
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
    }
}