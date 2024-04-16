using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICE_Repository.Models
{
    public class RecipeTag
    {
        [Key]
        public int RecipeTagId { get; set; }

        public Recipe RecipeId { get; set; }

        public string Tag { get; set; }
    }
}
