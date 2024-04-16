using ICE_Repository.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class DietaryPreference
    {
        public Users UserId { get; set; }

        public UserPreference PreferenceId { get; set; }
    }
}
