using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Review
    {
        [Key]public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Users UserId { get; set; }
        public Recipe RecipeId { get; set; }
    }
}
