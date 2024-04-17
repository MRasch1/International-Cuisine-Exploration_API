using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class UserFavorite
    {
        public int UserFavoriteId { get; set; }
        [JsonIgnore] public List<UserFavoriteRecipeJOIN>? RecipeId { get; set; }
        public int UserId { get; set; }
        [JsonIgnore] public Users? User { get; set; }
    }

    public class UserFavoriteRecipeJOIN
    {
        [Key] public int UserFavoriteRecipeJOINId { get; set; }

        public int UserFavoriteId { get; set; }
        [JsonIgnore] public UserFavorite? UserFavorite { get; set; }

        public int RecipeId { get; set; }
        [JsonIgnore] public Recipe? Recipe { get; set; }
    }
}
