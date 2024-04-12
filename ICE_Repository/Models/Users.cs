using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public int Username { get; set; }
        public int Email { get; set; }
        public string Password { get; set; }
        public int DietaryPreferenceId { get; set; }
    }
}
