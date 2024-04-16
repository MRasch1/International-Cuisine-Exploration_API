using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICE_Repository.Models
{
    public class RecipeTag
    {
        public int RecipeTagId { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipes { get; set; }
        public string Tag { get; set; }
    }

}
