using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repository.Models
{
    public class Kitchen
    {
        [Key]
        public int KitchenId { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
    }
}
