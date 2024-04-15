using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class UserFavorite
    {
        public int UserFavoriteId { get; set; }
        public int RecipeId { get; set; }
        public int UserId { get; set; }
    }
}
