using ICE_Repository.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class UserHistory
    {
        [Key]
        public int UserHistoryId { get; set; }

        public Users UserId { get; set; }

        public Recipe RecipeId { get; set; }
    }
}
