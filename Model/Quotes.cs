using System;
using System.ComponentModel.DataAnnotations;

namespace QuestAPI.Model
{
    public class Quotes
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
