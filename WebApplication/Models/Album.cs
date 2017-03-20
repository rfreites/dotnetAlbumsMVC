using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string AlbumName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { get; set; }
        [Required]
        public DateTime RelaseData { get; set; }
        [Required]
        [Range(0, 100.00)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 100)]
        public int Rank { get; set; }
    }
}
